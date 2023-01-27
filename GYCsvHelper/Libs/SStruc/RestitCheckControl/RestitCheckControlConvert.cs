using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using CsvHelper.Configuration.Attributes;
using Libs.CsvReader;

namespace Libs.SStruc;

public class RestitCheckControlConvert : INotifyPropertyChanged, IConvert
{
    private readonly PropertyInfo[] _propsMain;

    private string _fileId = string.Empty;

    [Name("Identifiant fiche")]
    [Column(Column = "A")]
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
    [Column(Column = "B")]
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
    [Column(Column = "C")]
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
    [Column(Column = "D")]
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
    [Column(Column = "E")]
    public string MotherFileIdentifier
    {
        get => _motherFileIdentifier;
        set
        {
            _motherFileIdentifier = value;
            OnPropertyChanged();
        }
    }
    
    private string _daughterFileIdentifier = string.Empty;

    [Name("Identifiant fiche fille")]
    [Column(Column = "F")]
    public string DaughterFileIdentifier
    {
        get => _daughterFileIdentifier;
        set
        {
            _daughterFileIdentifier = value;
            OnPropertyChanged();
        }
    }

    private DateTime? _validationDate;

    [Name("Date de validation")]
    [Column(Column = "G")]
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
    [Column(Column = "H")]
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
    [Column(Column = "I")]
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
    [Column(Column = "J")]
    [Format("yyyy-MM-dd HH:mm:ss")]
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
    [Column(Column = "K")]
    [Format("yyyy-MM-dd HH:mm:ss")]
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
    [Column(Column = "L")]
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
    [Column(Column = "M")]
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
    [Column(Column = "N")]
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
    [Column(Column = "O")]
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
    [Column(Column = "P")]
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
    [Column(Column = "Q")]
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
    [Column(Column = "R")]
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
    [Column(Column = "S")]
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
    [Column(Column = "T")]
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
    [Column(Column = "U")]
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
    [Column(Column = "V")]
    public float TiencTct
    {
        get => _tiencTct;
        set
        {
            _tiencTct = value;
            OnPropertyChanged();
        }
    }

    public RestitCheckControlConvert()
    {
        _propsMain = GetType().GetProperties();
    }

    public void ConvertInit(object record, IConvert instance) => SetValue((RestitCheckControl)record);

    private void SetValue(RestitCheckControl restitCheckControl)
    {
        foreach (var prop in _propsMain)
        {
            if (!_propsMain.Contains(prop)) continue;

            var value = restitCheckControl.GetType().GetProperty(prop.Name)?.GetValue(restitCheckControl, null);
            GetType().GetProperty(prop.Name)?.SetValue(this, value);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}