using System;
using System.Windows;
using System.Windows.Media;
using GYCsvHelper.UserControls;

namespace GYCsvHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            if (Function.GetVersion.GetUpdate())
            {
                Function.GetVersion.Update();
                GridFooter.Background = Brushes.Crimson;
            }
            else
            {
                GridFooter.Background = Brushes.ForestGreen;
            }

            LabelVersion.Content = Function.AssemblyCl.GetVersionDeploy().ToString();
            Title = Function.AssemblyCl.GetNameDeploy();
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e) 
            => TabItemButton.IsSelected = true;

        private void ButtonCompilCsv_OnClick(object sender, RoutedEventArgs e)
            => SelectItem(typeof(Csv));

        private void ButtonPlaningChaud_OnClick(object sender, RoutedEventArgs e) 
            => SelectItem(typeof(PlaningChaud));

        private void SelectItem(Type type)
        {
            FrameMain.Content = Activator.CreateInstance(type);
            TabItemFrame.IsSelected = true;
        }
    }
}