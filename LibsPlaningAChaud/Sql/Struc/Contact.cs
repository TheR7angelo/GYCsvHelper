using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibsPlaningAChaud.Sql.Struc;

public class Contact : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private readonly int _id;

    public int Id
    {
        get => _id;
        init
        {
            _id = value;
            OnPropertyChanged();
        }
    }

    private string _firstName = string.Empty;
    
    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            OnPropertyChanged();
        }
    }
    
    private string _lastName = string.Empty;
    
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            OnPropertyChanged();
        }
    }

    private string _number = string.Empty;

    public string Number
    {
        get => _number;
        set
        {
            _number = value;
            OnPropertyChanged();
        }
    }
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}