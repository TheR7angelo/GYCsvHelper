using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using LibsPlaningAChaud.CsvReader;
using LibsPlaningAChaud.Excel;
using LibsPlaningAChaud.Sql;
using Microsoft.Win32;

namespace GYCsvHelper.UserControls;

public partial class PlaningChaud
{
    private SqlHandler _sqlHandler;
    
    public PlaningChaud()
    {
        InitializeComponent();
        
        var db = Path.GetFullPath("Sql/data.sqlite");
        _sqlHandler = new SqlHandler(db);
    }

    private void ButtonProdR10_OnClick(object sender, RoutedEventArgs e) 
        => ImportData(EActivite.ProdGpCu, CheckBoxProdr10);

    private void ButtonSavGp_OnClick(object sender, RoutedEventArgs e)
        => ImportData(EActivite.SavGpCu, CheckBoxSavgp);

    private void ButtonProdFtth_OnClick(object sender, RoutedEventArgs e)
        => ImportData(EActivite.ProdFtth, CheckBoxProdFtth);

    private void ButtonSavbl_OnClick(object sender, RoutedEventArgs e)
        => ImportData(EActivite.Savbl, CheckBoxSavbl);

    private void ImportData(EActivite activity, ToggleButton checkBox)
    {
        var fileDialog = new OpenFileDialog
        {
            Filter = "Fichier Csv (*.csv)|*.csv"
        };

        if (!fileDialog.ShowDialog().Equals(true)) return;
        var file = fileDialog.FileName;
        
        if (!File.Exists(file)) return;
        
        var rowsCsv = Reader.Read(file, activity);
        _sqlHandler.ImportRows(rowsCsv, activity);
        checkBox.IsChecked = true;
    }

    private void ButtonExport_OnClick(object sender, RoutedEventArgs e)
    {
        var lst = new List<ToggleButton> { CheckBoxProdr10, CheckBoxSavgp, CheckBoxProdFtth, CheckBoxSavbl };
        var valid = lst.Count(s => s.IsChecked.Equals(true)).Equals(4);

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
}