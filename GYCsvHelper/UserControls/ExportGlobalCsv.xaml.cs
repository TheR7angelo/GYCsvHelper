using System.Linq;
using System.Windows;
using LibsExportGlobal.CsvReader;
using LibsExportGlobal.ExportGlobal.SStruc.ExportGlobal;
using LibsExportGlobal.ExportGlobal.SStruc.RestitCheckControl;
using Microsoft.Win32;

namespace GYCsvHelperWpfApp.UserControls;

public partial class ExportGlobalCsv
{

    public ExportGlobalCsv()
    {
        InitializeComponent();
    }

    private void ButtonExportFicheModifier_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog { Filter = "CSV (séparateur : point-virgule) (*.csv) | *.csv" };
        if (!dialog.ShowDialog().Equals(true)) return;

        var savePathDialog = new SaveFileDialog
        {
            Filter = "CSV (séparateur : point-virgule) (*.csv) | *.csv",
            FileName = "Restitution_Fiches_Validees_complet.csv",
            AddExtension = true
        };
        if (!savePathDialog.ShowDialog().Equals(true)) return;

        using var worker = new RestitCheckControlReader(dialog.FileName);
        worker.SetSavePath(savePathDialog.FileName);

        worker.CleanFirstRow(14, false);
        var data = worker.Read<RestitCheckControl>();

        var convert = worker.Convert<RestitCheckControlConvert>(data.Cast<object>().ToList());

        worker.Write(convert);
    }

    private void ButtonFichesGlobalModifier_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog
        {
            Filter = "CSV (séparateur : point-virgule) (*.csv) | *.csv",
            Multiselect = true
        };
        if (!dialog.ShowDialog().Equals(true)) return;

        var savePathDialog = new SaveFileDialog
        {
            Filter = "CSV (séparateur : point-virgule) (*.csv) | *.csv",
            FileName = "ExportGlobal.csv",
            AddExtension = true
        };
        if (!savePathDialog.ShowDialog().Equals(true)) return;

        var files = dialog.FileNames.ToList();

        using var worker = new ExportGlobalReader(files);
        worker.SetSavePath(savePathDialog.FileName);

        worker.CleanFirstRow(8, false);
        var data = worker.Read<ExportGlobal>();

        var convert = worker.Convert<ExportGlobalConvert>(data.Cast<object>().ToList());

        worker.Write(convert);
    }

    private void ButtonExportFiche_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog { Filter = "CSV (séparateur : point-virgule) (*.csv) | *.csv" };
        if (!dialog.ShowDialog().Equals(true)) return;

        var savePathDialog = new SaveFileDialog
        {
            Filter = "CSV (séparateur : point-virgule) (*.csv) | *.csv",
            FileName = "Restitution_Fiches_Validees_complet.csv",
            AddExtension = true
        };
        if (!savePathDialog.ShowDialog().Equals(true)) return;

        using var worker = new RestitCheckControlReader(dialog.FileName);
        worker.SetSavePath(savePathDialog.FileName);

        worker.CleanFirstRow(14, false);
        var data = worker.Read<RestitCheckControl>();
        worker.Write(data);
    }

    private void ButtonFichesGlobal_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog
        {
            Filter = "CSV (séparateur : point-virgule) (*.csv) | *.csv",
            Multiselect = true
        };
        if (!dialog.ShowDialog().Equals(true)) return;

        var savePathDialog = new SaveFileDialog
        {
            Filter = "CSV (séparateur : point-virgule) (*.csv) | *.csv",
            FileName = "ExportGlobal.csv",
            AddExtension = true
        };
        if (!savePathDialog.ShowDialog().Equals(true)) return;

        var files = dialog.FileNames.ToList();

        using var worker = new ExportGlobalReader(files);
        worker.SetSavePath(savePathDialog.FileName);

        worker.CleanFirstRow(8, false);
        var data = worker.Read<ExportGlobal>();
        worker.Write(data);
    }
}