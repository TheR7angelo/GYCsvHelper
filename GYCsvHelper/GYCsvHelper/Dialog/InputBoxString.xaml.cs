using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace GYCsvHelper.Dialog;

public partial class InputBoxString : INotifyPropertyChanged
{
    private string? _answer;

    public string? Answer
    {
        get => _answer;
        set
        {
            _answer = value;
            OnPropertyChanged();
        }
    }

    public InputBoxString(string question)
    {
        InitializeComponent();
        LabelQuestion.Content = question;
    }

    private void BtnDialogOk_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}