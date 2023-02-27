using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibsPlaningAChaud.CsvReader;

namespace LibsPlaningAChaud.Sql.Struc;

public class Zone : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public readonly char Separator = ';';
    
    private int _id;

    public int Id
    {
        get => _id;
        set
        {
            _id = value;
            OnPropertyChanged();
        }
    }

    private EActivite _activity;

    public EActivite Activity
    {
        get => _activity;
        set
        {
            _activity = value;
            OnPropertyChanged();
        }
    }

    private int _department;

    public int Department
    {
        get => _department;
        set
        {
            _department = value;
            OnPropertyChanged();
        }
    }

    private string _ui = string.Empty;

    public string Ui
    {
        get => _ui;
        set
        {
            _ui = value;
            OnPropertyChanged();
        }
    }

    private Contact _contact = new();

    public Contact Contact
    {
        get => _contact;
        set
        {
            _contact = value;
            OnPropertyChanged();
        }
    }

    private Contact _escaladeN1 = new();

    public Contact EscaladeN1
    {
        get => _escaladeN1;
        set
        {
            _escaladeN1 = value;
            OnPropertyChanged();
        }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}