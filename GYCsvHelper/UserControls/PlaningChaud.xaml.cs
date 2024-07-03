using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using LibsPlaningAChaud.CsvReader;
using LibsPlaningAChaud.Excel;
using LibsPlaningAChaud.Sql;
using Microsoft.Win32;

namespace GYCsvHelperWpfApp.UserControls;

public partial class PlaningChaud
{
    private SqlHandler _sqlHandler;
    private readonly Button _buttonBack;
    
    public PlaningChaud(Button buttonBack)
    {
        _buttonBack = buttonBack;
        InitializeComponent();
        
        var db = Path.GetFullPath("Sql/data.sqlite");
        _sqlHandler = new SqlHandler(db);
    }

    private void ButtonProdR10_OnClick(object sender, RoutedEventArgs e) 
        => ImportData(EActivity.ProdGpCu, CheckBoxProdr10);

    private void ButtonSavGp_OnClick(object sender, RoutedEventArgs e)
        => ImportData(EActivity.SavGpCu, CheckBoxSavgp);

    private void ButtonProdFtth_OnClick(object sender, RoutedEventArgs e)
        => ImportData(EActivity.ProdFtth, CheckBoxProdFtth);

    private void ButtonSavbl_OnClick(object sender, RoutedEventArgs e)
        => ImportData(EActivity.Savbl, CheckBoxSavbl);

    private void ButtonSavblo_OnClick(object sender, RoutedEventArgs e)
        => ImportData(EActivity.Savblo, CheckBoxSavblo);

    private void ImportData(EActivity activity, ToggleButton checkBox)
    {
        try
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = "Fichier Csv (*.csv)|*.csv",
                Multiselect = true
            };

            if (!fileDialog.ShowDialog().Equals(true)) return;
            var files = fileDialog.FileNames;

            var result = new List<ExportInterventionCsv>();
            foreach (var file in files)
            {
                if (!File.Exists(file)) return;
                var rowsCsv = Reader.Read(file, activity);
                result.AddRange(rowsCsv);
            }
        
            _sqlHandler.ImportRows(result, activity);
            checkBox.IsChecked = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private void ButtonExport_OnClick(object sender, RoutedEventArgs e)
    {
        var lst = new List<ToggleButton> { CheckBoxProdr10, CheckBoxSavgp, CheckBoxProdFtth, CheckBoxSavbl, CheckBoxSavblo };
        var valid = lst.Count(s => s.IsChecked.Equals(true)).Equals(lst.Count);

        if (valid)
        {
            var rowsSql = _sqlHandler.GetRows();
            
            var excelHandler = new ExcelHandler();
            excelHandler.WriteRows(rowsSql);

            var myCi = new CultureInfo("fr-FR");
            var myCal = myCi.Calendar;
            var myCwr = myCi.DateTimeFormat.CalendarWeekRule;
            var myFirstDow = myCi.DateTimeFormat.FirstDayOfWeek;

            var d = myCal.GetWeekOfYear(DateTime.Now, myCwr, myFirstDow);
            var defaultName = $"PLANNING VQSE A CHAUD DOSO Z2 S{d}";

            var dialog = new SaveFileDialog
            {
                Filter = "Fichier Excel (*.xlsx)|*.xlsx",
                FileName = defaultName
            };

            if (!dialog.ShowDialog().Equals(true)) return;
        
            excelHandler.Save(dialog.FileName);
        }
        else
        {
            MessageBox.Show("Tous les imports non pas étais éffectuée");
        }
    }

    private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
    {
        _buttonBack.Visibility = Visibility.Visible;
        TabItemMenu.IsSelected = true;
    }

    private void ButtonContact_OnClick(object sender, RoutedEventArgs e) 
        => SetFrameSecond(typeof(Contacts));

    private void ButtonZones_OnClick(object sender, RoutedEventArgs e) 
        => SetFrameSecond(typeof(Zones));

    private void SetFrameSecond(Type type)
    {
        _buttonBack.Visibility = Visibility.Hidden;
        FrameSecond.Content = Activator.CreateInstance(type, _sqlHandler);
        TabItemSecond.IsSelected = true;
    }
}