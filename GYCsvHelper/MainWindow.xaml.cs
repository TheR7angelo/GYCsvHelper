using System;
using System.Windows;
using System.Windows.Media;
using AutoUpdaterWpf;
using AutoUpdaterWpf.Object.Enum;
using GYCsvHelperWpfApp.UserControls;

namespace GYCsvHelperWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private static Updater _updater = null!;
        private static string? XmlFile { get; set; }
        
        public MainWindow()
        {
            var asembly = System.Reflection.Assembly.GetEntryAssembly()!;
            var applicationName = asembly.GetName().Name!;

            _updater = new Updater("T:\\- 4 Suivi Appuis\\18-Partage\\BARRENTO ANTUNES Raphael\\7_CSharp\\Centre macro.db",
                applicationName);

            Console.WriteLine(applicationName);

            var currentVersion = asembly.GetName().Version!;

            // updater.SetAutoUpdater(AutoUpdaterParameterShowing.ReportErrors, true);
            _updater.SetAutoUpdater(EParameterShowing.ShowSkipButton, false);
            _updater.SetAutoUpdater(EParameterShowing.LetUserSelectRemindLater, true);

            XmlFile = _updater.GenerateXmlFile();
            var lastVersion = _updater.LastVersion;
            
            InitializeComponent();

            Title = applicationName;

            if (XmlFile is null)
            {
                GridFooter.Background = currentVersion < lastVersion ? Brushes.Crimson : Brushes.ForestGreen;
                LabelVersion.Content = currentVersion.ToString();
                return;
            }

            _updater.Start(XmlFile);

            GridFooter.Background = currentVersion < lastVersion ? Brushes.Crimson : Brushes.ForestGreen;
            LabelVersion.Content = currentVersion.ToString();
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e) 
            => TabItemButton.IsSelected = true;

        private void ButtonCompilCsv_OnClick(object sender, RoutedEventArgs e)
            => SelectItem(typeof(ExportGlobalCsv));

        private void ButtonPlaningChaud_OnClick(object sender, RoutedEventArgs e) 
            => SelectItem(typeof(PlaningChaud));

        private void SelectItem(Type type)
        {
            FrameMain.Content = type switch
            {
                _ when type == typeof(PlaningChaud) => Activator.CreateInstance(type, ButtonBack),
                _ => Activator.CreateInstance(type)
            };
            
            TabItemFrame.IsSelected = true;
        }
    }
}