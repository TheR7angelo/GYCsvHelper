using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using LibsPlaningAChaud.CsvReader;
using LibsPlaningAChaud.Sql;
using LibsPlaningAChaud.Sql.Struc;

namespace GYCsvHelper.UserControls;

public partial class Zones
{
    private readonly SqlHandler _sqlHandler;
    private int _department;
    private Zone _zone = new();
    private EActivity _activity;

    public ObservableCollection<int> ListDepartment { get; } = new();
    public ObservableCollection<Zone> CollectionZones { get; } = new();
    public List<Contact> ListContact { get; } = new();

    public Zones(SqlHandler sqlHandler)
    {
        _sqlHandler = sqlHandler;
        var contacts = _sqlHandler.GetAllContact();
        ListContact.AddRange(contacts);

        InitializeComponent();
    }

    private void ButtonActivity_OnClick(object sender, RoutedEventArgs e)
    {
        var id = int.Parse(((RadioButton)sender).Tag!.ToString()!);

        if (((EActivity)id).Equals(_activity)) return;

        _activity = (EActivity)id;
        GetAllDepartments();
    }

    private void ButtonDepartment_OnClick(object sender, RoutedEventArgs e)
    {
        _department = int.Parse(((ToggleButton)sender).Content.ToString()!);
        GetAllZones();
    }

    private void ButtonAddZone_OnClick(object sender, RoutedEventArgs e)
    {
        var mode = GetModeUse();

        switch (mode)
        {
            case EMode.Department:
                AddDepartment();
                break;
            case EMode.Ui:
                AddUi();
                break;
            case EMode.None:
            default:
                break;
        }
    }

    private void ButtonDeleteZone_OnClick(object sender, RoutedEventArgs e)
    {
        var mode = GetModeUse();

        int id;
        string column;

        switch (mode)
        {
            case EMode.Department:
                id = _department;
                column = "dept";
                break;
            case EMode.Ui:
                id = _zone.Id;
                column = "id";
                break;
            case EMode.None:
            default:
                return;
        }

        _sqlHandler.DeleteZone(_activity, column, id);
        if (mode.Equals(EMode.Department)) GetAllDepartments();
        else GetAllZones();
    }

    private void ButtonUi_OnClick(object sender, RoutedEventArgs e)
    {
        var button = (ToggleButton)sender;
        var zone = (Zone)button.DataContext;
        _zone = zone;
    }

    private void GetAllDepartments()
    {
        var zones = _sqlHandler.GetAllZones().Where(s => s.Activity.Equals(_activity));

        ListDepartment.Clear();
        CollectionZones.Clear();
        foreach (var dept in zones.Select(s => s.Department).Distinct()) ListDepartment.Add(dept);
    }

    private void GetAllZones()
    {
        var zones = _sqlHandler.GetAllZones()
            .Where(s => s.Activity.Equals(_activity) && s.Department.Equals(_department));
        CollectionZones.Clear();
        foreach (var zone in zones) CollectionZones.Add(zone);
    }

    private void AddUi()
    {
        var ui = Function.GetUi("Quelle est le code ui à utilisé");
        if (ui is null) return;
        _sqlHandler.InsertNewDept(_activity, _department, ui);
        GetAllZones();
    }

    private void AddDepartment()
    {
        var dept = Function.GetDepartment();
        if (dept is null) return;
        if (ListDepartment.Contains((int)dept)) return;

        var ui = Function.GetUi("Quelle est le code ui à utilisé");
        if (ui is null) return;

        _sqlHandler.InsertNewDept(_activity, (int)dept, ui);
        GetAllDepartments();
    }

    private EMode GetModeUse()
    {
        var dept = ListBoxDepartment.FindVisualChildren<ToggleButton>().FirstOrDefault(s => s.IsChecked.Equals(true));
        var ui = ListBoxUi.FindVisualChildren<ToggleButton>().FirstOrDefault(s => s.IsChecked.Equals(true));

        return (dept, ui) switch
        {
            (not null, not null) => EMode.Ui,
            (not null, null) => EMode.Department,
            _ => EMode.None
        };
    }
}

internal enum EMode
{
    None,
    Department,
    Ui
}