using System;
using System.Windows;
using System.Windows.Media;
using GYCsvHelperWpfApp.Function;
using GYCsvHelperWpfApp.UserControls;

namespace GYCsvHelperWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            if (GetVersion.GetUpdate())
            {
                GetVersion.Update();
                GridFooter.Background = Brushes.Crimson;
            }
            else
            {
                GridFooter.Background = Brushes.ForestGreen;
            }

            LabelVersion.Content = AssemblyCl.GetVersionDeploy().ToString();
            Title = AssemblyCl.GetNameDeploy();
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