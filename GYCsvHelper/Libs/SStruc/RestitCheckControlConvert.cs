using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using CsvHelper.Configuration.Attributes;

namespace Libs.SStruc;

public class RestitCheckControlConvert : INotifyPropertyChanged
{
    private readonly PropertyInfo[] _propsMain;
    
    private string _fileId = string.Empty;

    [Name("Identifiant fiche")]
    public string FileId
    {
        get => _fileId;
        set
        {
            _fileId = value;
            OnPropertyChanged();
        }
    }

    private string _siteReference = string.Empty;

    [Name("Réference chantier")]
    public string SiteReference
    {
        get => _siteReference;
        set
        {
            _siteReference = value;
            OnPropertyChanged();
        }
    }

    private string _state = string.Empty;

    [Name("Etat")]
    public string State
    {
        get => _state;
        set
        {
            _state = value;
            OnPropertyChanged();
        }
    }

    private string _validationResult = string.Empty;

    [Name("Résultat validation")]
    public string ValidationResult
    {
        get => _validationResult;
        set
        {
            _validationResult = value;
            OnPropertyChanged();
        }
    }

    private string _motherFileIdentifier = string.Empty;

    [Name("Identifiant fiche mère")]
    public string MotherFileIdentifier
    {
        get => _motherFileIdentifier;
        set
        {
            _motherFileIdentifier = value;
            OnPropertyChanged();
        }
    }

    private DateTime? _validationDate;

    [Name("Date de validation")]
    [Format("yyyy-MM-dd", "dd/MM/yyyy")]
    public DateTime? ValidationDate
    {
        get => _validationDate;
        set
        {
            _validationDate = value;
            OnPropertyChanged();
        }
    }

    private DateTime? _auditDate;

    [Name("Date de vérification")]
    [Format("yyyy-MM-dd", "dd/MM/yyyy")]
    public DateTime? AuditDate
    {
        get => _auditDate;
        set
        {
            _auditDate = value;
            OnPropertyChanged();
        }
    }

    private DateTime? _dateOfCreation;

    [Name("Date de création")]
    [Format("yyyy-MM-dd", "dd/MM/yyyy")]
    public DateTime? DateOfCreation
    {
        get => _dateOfCreation;
        set
        {
            _dateOfCreation = value;
            OnPropertyChanged();
        }
    }

    private DateTime? _dateOfResumption;

    [Name("Date de reprise")]
    [Format("yyyy-MM-dd HH:mm:ss.fff", "yyyy-MM-dd HH:mm:ss.ff", "yyyy-MM-dd HH:mm:ss.f", "yyyy-MM-dd HH:mm:ss")]
    public DateTime? DateOfResumption
    {
        get => _dateOfResumption;
        set
        {
            _dateOfResumption = value;
            OnPropertyChanged();
        }
    }

    private DateTime? _expectedResumptionDate;

    [Name("Date de reprise attendue")]
    [Format("yyyy-MM-dd HH:mm:ss.fff", "yyyy-MM-dd HH:mm:ss.ff", "yyyy-MM-dd HH:mm:ss.f", "yyyy-MM-dd HH:mm:ss")]
    public DateTime? ExpectedResumptionDate
    {
        get => _expectedResumptionDate;
        set
        {
            _expectedResumptionDate = value;
            OnPropertyChanged();
        }
    }

    private bool _seriousMisconduct;

    [Name("Manquement grave")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool SeriousMisconduct
    {
        get => _seriousMisconduct;
        set
        {
            _seriousMisconduct = value;
            OnPropertyChanged();
        }
    }

    private bool _billingToBeCorrected;

    [Name("Facturation à corriger ")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool BillingToBeCorrected
    {
        get => _billingToBeCorrected;
        set
        {
            _billingToBeCorrected = value;
            OnPropertyChanged();
        }
    }

    private bool _securityToBeFixed;

    [Name("Sécurité à corriger ")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool SecurityToBeFixed
    {
        get => _securityToBeFixed;
        set
        {
            _securityToBeFixed = value;
            OnPropertyChanged();
        }
    }

    private string _entity = string.Empty;

    [Name("Entité")]
    public string Entity
    {
        get => _entity;
        set
        {
            _entity = value;
            OnPropertyChanged();
        }
    }

    private string _infraEntity = string.Empty;

    [Name("Infra-Entité")]
    public string InfraEntity
    {
        get => _infraEntity;
        set
        {
            _infraEntity = value;
            OnPropertyChanged();
        }
    }

    private string _provider = string.Empty;

    [Name("Fournisseur")]
    public string Provider
    {
        get => _provider;
        set
        {
            _provider = value;
            OnPropertyChanged();
        }
    }

    private string _groupSupplier = string.Empty;

    [Name("Fournisseur groupe")]
    public string GroupSupplier
    {
        get => _groupSupplier;
        set
        {
            _groupSupplier = value;
            OnPropertyChanged();
        }
    }

    private string _domain = string.Empty;

    [Name("Domaine")]
    public string Domain
    {
        get => _domain;
        set
        {
            _domain = value;
            OnPropertyChanged();
        }
    }

    private string _subdomain = string.Empty;

    [Name("Sous-domaine")]
    public string Subdomain
    {
        get => _subdomain;
        set
        {
            _subdomain = value;
            OnPropertyChanged();
        }
    }

    private string _typeOfBenefit = string.Empty;

    [Name("Type de prestation")]
    public string TypeOfBenefit
    {
        get => _typeOfBenefit;
        set
        {
            _typeOfBenefit = value;
            OnPropertyChanged();
        }
    }

    private float _tiencTct;

    [Name("TIENC / TCT")]
    public float TiencTct
    {
        get => _tiencTct;
        set
        {
            _tiencTct = value;
            OnPropertyChanged();
        }
    }

    private void OnPropertyChanged([CallerMemberName] string? name=null) 
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public RestitCheckControlConvert(RestitCheckControl restitCheckControl)
    {
        _propsMain = GetType().GetProperties();
        var instance = this;
        SetValue(restitCheckControl, instance);
    }
    
    public RestitCheckControlConvert()
    {
        _propsMain = GetType().GetProperties();
    }

    private void SetValue(RestitCheckControl restitCheckControl, RestitCheckControlConvert instance)
    {
        foreach (var prop in _propsMain)
        {
            if (!_propsMain.Contains(prop)) continue;

            var value = typeof(RestitCheckControl).GetProperty(prop.Name)?.GetValue(restitCheckControl, null);
            instance.GetType().GetProperty(prop.Name)?.SetValue(null, value);
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    
}