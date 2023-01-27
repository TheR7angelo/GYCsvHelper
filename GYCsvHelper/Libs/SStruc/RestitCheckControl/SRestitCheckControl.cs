using System.ComponentModel;
using System.Runtime.CompilerServices;
using CsvHelper.Configuration.Attributes;

namespace Libs.SStruc;

public class RestitCheckControl : INotifyPropertyChanged
{
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
    [Column(Column = "K")]
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

    [Name("TIENC / TCT"), CultureInfo("FR-fr")]
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

    private bool _countedInTheSample;

    [Name("Compté dans l'échantillon")]
    [Column(Column = "W")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool CountedInTheSample
    {
        get => _countedInTheSample;
        set
        {
            _countedInTheSample = value;
            OnPropertyChanged();
        }
    }

    private string _validationComment = string.Empty;

    [Name("Commentaire validation")]
    [Column(Column = "X")]
    public string ValidationComment
    {
        get => _validationComment;
        set
        {
            _validationComment = value;
            OnPropertyChanged();
        }
    }

    private string _commentTakenUp = string.Empty;

    [Name("Commentaire reprise")]
    [Column(Column = "Y")]
    public string CommentTakenUp
    {
        get => _commentTakenUp;
        set
        {
            _commentTakenUp = value;
            OnPropertyChanged();
        }
    }

    private string _analyticalResult = string.Empty;

    [Name("Resultat d'analyse")]
    [Column(Column = "Z")]
    public string AnalyticalResult
    {
        get => _analyticalResult;
        set
        {
            _analyticalResult = value;
            OnPropertyChanged();
        }
    }

    private bool _times;

    [Name("DELAIS")]
    [Column(Column = "AA")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool Times
    {
        get => _times;
        set
        {
            _times = value;
            OnPropertyChanged();
        }
    }

    private bool _realTimeEcvhangesWithOrange;

    [Name("ECHANGES EN TEMPS REEL AVEC ORANGE")]
    [Column(Column = "AB")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool RealTimeEcvhangesWithOrange
    {
        get => _realTimeEcvhangesWithOrange;
        set
        {
            _realTimeEcvhangesWithOrange = value;
            OnPropertyChanged();
        }
    }

    private bool _complianceWithTheDelegationFramewprk;

    [Name("RESPECT DU CADRE DE DELEGATION")]
    [Column(Column = "AC")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool ComplianceWithTheDelegationFramewprk
    {
        get => _complianceWithTheDelegationFramewprk;
        set
        {
            _complianceWithTheDelegationFramewprk = value;
            OnPropertyChanged();
        }
    }

    private bool _safety;

    [Name("SECURITE")]
    [Column(Column = "AD")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool Safety
    {
        get => _safety;
        set
        {
            _safety = value;
            OnPropertyChanged();
        }
    }

    private bool _damageToStructures;

    [Name("DOMMAGES AUX OUVRAGES")]
    [Column(Column = "AE")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool DamageToStructures
    {
        get => _damageToStructures;
        set
        {
            _damageToStructures = value;
            OnPropertyChanged();
        }
    }

    private bool _technicalCompliabce;

    [Name("CONFORMITE TECHNIQUE")]
    [Column(Column = "AF")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool TechnicalCompliabce
    {
        get => _technicalCompliabce;
        set
        {
            _technicalCompliabce = value;
            OnPropertyChanged();
        }
    }

    private bool _postWorkDocumentation;

    [Name("DOCUMENTATION APRES TRAVAUX")]
    [Column(Column = "AG")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool PostWorkDocumentation
    {
        get => _postWorkDocumentation;
        set
        {
            _postWorkDocumentation = value;
            OnPropertyChanged();
        }
    }

    private bool _invoicing;

    [Name("FACTURATION")]
    [Column(Column = "AH")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool Invoicing
    {
        get => _invoicing;
        set
        {
            _invoicing = value;
            OnPropertyChanged();
        }
    }

    private bool _customerRelationsThirdPartiesAndCommunities;

    [Name("RELATION CLIENTS, TIERS ET COLLECTIVITES")]
    [Column(Column = "AI")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool CustomerRelationsThirdPartiesAndCommunities
    {
        get => _customerRelationsThirdPartiesAndCommunities;
        set
        {
            _customerRelationsThirdPartiesAndCommunities = value;
            OnPropertyChanged();
        }
    }

    private bool _environment;

    [Name("ENVIRONNEMENT")]
    [Column(Column = "AJ")]
    [BooleanTrueValues("OUI"), BooleanFalseValues("NON")]
    public bool Environment
    {
        get => _environment;
        set
        {
            _environment = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}