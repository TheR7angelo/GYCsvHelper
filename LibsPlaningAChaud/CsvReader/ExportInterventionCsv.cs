using System.ComponentModel;
using System.Runtime.CompilerServices;
using CsvHelper.Configuration.Attributes;

namespace LibsPlaningAChaud.CsvReader;

public class ExportInterventionCsv : INotifyPropertyChanged
{
    private int _activity;

    [Optional]
    public int Activity
    {
        get => _activity;
        set
        {
            _activity = value;
            OnPropertyChanged();
        }
    }
    
    private string _typeInter = string.Empty;

    [Name("Type inter.")]
    public string TypeInter
    {
        get => _typeInter;
        set
        {
            _typeInter = value;
            OnPropertyChanged();
        }
    }
    
    private string _nd = string.Empty;
    [Name("ND")]
    public string Nd
    {
        get => _nd;
        set
        {
            _nd = value;
            OnPropertyChanged();
        }
    }
    
    private string _planifFt = string.Empty;
    [Name("Date cible initiale")]
    public string PlanifFt
    {
        get => _planifFt;
        set
        {
            _planifFt = value;
            OnPropertyChanged();
        }
    }

    private string _ui = string.Empty;
    [Name("UI")]
    public string Ui
    {
        get => _ui;
        set
        {
            _ui = value;
            OnPropertyChanged();
        }
    }
    
    private string _actProd = string.Empty;
    [Name("Act/Prod")]
    public string ActProd
    {
        get => _actProd;
        set
        {
            _actProd = value;
            OnPropertyChanged();
        }
    }
    
    private string _client = string.Empty;
    [Name("Client")]
    public string Client
    {
        get => _client;
        set
        {
            _client = value;
            OnPropertyChanged();
        }
    }
    
    private string _adresse = string.Empty;
    [Name("Adresse")]
    public string Adresse
    {
        get => _adresse;
        set
        {
            _adresse = value;
            OnPropertyChanged();
        }
    }
    
    private string _postalCode = string.Empty;
    [Name("CP")]
    public string PostalCode
    {
        get => _postalCode;
        set
        {
            _postalCode = value;
            OnPropertyChanged();
        }
    }
    
    private string _villeSite = string.Empty;
    [Name("Ville site")]
    public string VilleSite
    {
        get => _villeSite;
        set
        {
            _villeSite = value;
            OnPropertyChanged();
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}