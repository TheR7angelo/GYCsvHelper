using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace GYCsvHelper.Dialog;

public sealed partial class InputBoxNumeric : INotifyPropertyChanged
{
    private readonly int _minValue;
    private readonly int _maxValue;
    
    private readonly int _foot;

    private int _value;
    public int Value
    {
        get => _value;
        set
        {
            _value = value;
            OnPropertyChanged();
        }
    }

    public InputBoxNumeric(int foot = 1, int startValue = 0, int minValue = int.MinValue, int maxValue = int.MaxValue)
    {
        _foot = foot;
        _minValue = minValue;
        _maxValue = maxValue;

        if (startValue < _minValue) startValue = _minValue;
        
        Value = startValue;

        InitializeComponent();
    }

    private void ButtonUp_OnClick(object sender, RoutedEventArgs e) => AddValue(_foot);

    private void ButtonDown_OnClick(object sender, RoutedEventArgs e) => AddValue(-_foot);

    private void AddValue(int valueToAdd)
    {
        var tmp = Value + valueToAdd;
        if (_minValue <= tmp && tmp <= _maxValue) Value = tmp;
    }

    private void UIElement_OnMouseWheel(object sender, MouseWheelEventArgs e)
    {
        if (e.Delta > 0) AddValue(_foot);
        else AddValue(-_foot);
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}