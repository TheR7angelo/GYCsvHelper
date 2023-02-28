using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using LibsPlaningAChaud.CsvReader;
using LibsPlaningAChaud.Sql;
using LibsPlaningAChaud.Sql.Struc;

namespace GYCsvHelper.UserControls;

public partial class Zones : INotifyPropertyChanged
{
    private readonly SqlHandler _sqlHandler;
    private int _department;
    private EActivite _activity;

    private List<int> _listDepartment = new();

    public List<int> ListDepartment
    {
        get => _listDepartment;
        set
        {
            _listDepartment = value;
            OnPropertyChanged();
        }
    }
    
    public ObservableCollection<Zone> CollectionZones { get; } = new();
    
    public Zones(SqlHandler sqlHandler)
    {
        _sqlHandler = sqlHandler;
        InitializeComponent();
    }

    private void ButtonActivity_OnClick(object sender, RoutedEventArgs e)
    {
        var id = int.Parse(((RadioButton)sender).Tag!.ToString()!);
        
        if (((EActivite)id).Equals(_activity)) return;
        
        _activity = (EActivite)id;
        GetAllDepartments();
    }
    
    private void ButtonDepartment_OnClick(object sender, RoutedEventArgs e)
    {
        _department = int.Parse(((ToggleButton)sender).Content.ToString()!);
        GetAllZones();
    }

    private void GetAllDepartments()
    {
        var zones = _sqlHandler.GetAllZones().Where(s => s.Activity.Equals(_activity));
        
        ListDepartment.Clear();
        CollectionZones.Clear();
        foreach (var dept in zones.Select(s => s.Department)) ListDepartment.Add(dept);
    }

    private void GetAllZones()
    {
        var zones = _sqlHandler.GetAllZones().Where(s => s.Activity.Equals(_activity) && s.Department.Equals(_department));
        CollectionZones.Clear();
        foreach (var zone in zones) CollectionZones.Add(zone);
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
            case EMode.None:
            default:
                break;
        }
        
        Console.WriteLine(mode);
    }

    private void AddDepartment()
    {
        var dialog = new Dialog.InputBoxNumeric(minValue:0);
        dialog.ShowDialog();

        var dept = dialog.Value;
        if (!ListDepartment.Contains(dept))
        {
            
        }
    }
    
    private void ButtonDeleteZone_OnClick(object sender, RoutedEventArgs e)
    {
        var mode = GetModeUse();
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
    
    private void ButtonShowContact_OnClick(object sender, RoutedEventArgs e)
    {
        
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

internal enum EMode
{
    None,
    Department,
    Ui
}