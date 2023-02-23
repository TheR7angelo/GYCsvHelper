using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Libs.PlaningAChaud.Sql.Struc;

public class VProdData
{
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

    private string _activity = string.Empty;
    
    public string Activity
    {
        get => _activity;
        set
        {
            _activity = value;
            OnPropertyChanged();
        }
    }

    private string _onglet = string.Empty;

    public string Onglet
    {
        get => _onglet;
        set
        {
            _onglet = value;
            OnPropertyChanged();
        }
    }

    private string? _typeInter;
    
    public string? TypeInter
    {
        get => _typeInter;
        set
        {
            _typeInter = value;
            OnPropertyChanged();
        }
    }
    
    private string? _nd;
    public string? Nd
    {
        get => _nd;
        set
        {
            _nd = value;
            OnPropertyChanged();
        }
    }
    
    private string? _planifFt;
    public string? PlanifFt
    {
        get => _planifFt;
        set
        {
            _planifFt = value;
            OnPropertyChanged();
        }
    }

    private string? _ui;
    public string? Ui
    {
        get => _ui;
        set
        {
            _ui = value;
            OnPropertyChanged();
        }
    }
    
    private string? _actProd;
    public string? ActProd
    {
        get => _actProd;
        set
        {
            _actProd = value;
            OnPropertyChanged();
        }
    }
    
    private string? _client;
    public string? Client
    {
        get => _client;
        set
        {
            _client = value;
            OnPropertyChanged();
        }
    }
    
    private string? _adresse;
    public string? Adresse
    {
        get => _adresse;
        set
        {
            _adresse = value;
            OnPropertyChanged();
        }
    }
    
    private string? _postalCode;
    public string? PostalCode
    {
        get => _postalCode;
        set
        {
            _postalCode = value;
            OnPropertyChanged();
        }
    }
    
    private string? _villeSite;
    public string? VilleSite
    {
        get => _villeSite;
        set
        {
            _villeSite = value;
            OnPropertyChanged();
        }
    }

    private string? _contact;

    public string? Contact
    {
        get => _contact;
        set
        {
            _contact = value;
            OnPropertyChanged();
        }
    }

    private string? _escaladeN1;

    public string? EscaladeN1
    {
        get => _escaladeN1;
        set
        {
            _escaladeN1 = value;
            OnPropertyChanged();
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}