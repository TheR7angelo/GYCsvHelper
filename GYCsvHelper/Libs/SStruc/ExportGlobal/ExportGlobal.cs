using System.ComponentModel;
using System.Runtime.CompilerServices;
using CsvHelper.Configuration.Attributes;

namespace Libs.SStruc;

public class ExportGlobal : INotifyPropertyChanged
{
    private string _creatorType = string.Empty;

    [Name("Type créateur")]
    [Column(Column = "A")]
    public string CreatorType
    {
        get => _creatorType;
        set
        {
            _creatorType = value;
            OnPropertyChanged();
        }
    }

    private string _siteId = string.Empty;

    [Name("Identifiant chantier")]
    [Column(Column = "B")]
    public string SiteId
    {
        get => _siteId;
        set
        {
            _siteId = value;
            OnPropertyChanged();
        }
    }

    private string _siteReference = string.Empty;

    [Name("Référence chantier")]
    [Column(Column = "C")]
    public string SiteReference
    {
        get => _siteReference;
        set
        {
            _siteReference = value;
            OnPropertyChanged();
        }
    }

    private string _codeCbs = string.Empty;

    [Name("Code CBS")]
    [Column(Column = "D")]
    public string CodeCbs
    {
        get => _codeCbs;
        set
        {
            _codeCbs = value;
            OnPropertyChanged();
        }
    }

    private string _entity = string.Empty;

    [Name("Entité")]
    [Column(Column = "E")]
    public string Entity
    {
        get => _entity;
        set
        {
            _entity = value;
            OnPropertyChanged();
        }
    }

    private string _inferredEntity = string.Empty;

    [Name("Entité déduite")]
    [Column(Column = "F")]
    public string InferredEntity
    {
        get => _inferredEntity;
        set
        {
            _inferredEntity = value;
            OnPropertyChanged();
        }
    }

    private string _provider = string.Empty;

    [Name("Fournisseur")]
    [Column(Column = "G")]
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

    [Name("Fournisseur Groupe")]
    [Column(Column = "H")]
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
    [Column(Column = "I")]
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

    [Name("Sous-Domaine")]
    [Column(Column = "J")]
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
    [Column(Column = "K")]
    public string TypeOfBenefit
    {
        get => _typeOfBenefit;
        set
        {
            _typeOfBenefit = value;
            OnPropertyChanged();
        }
    }

    private string _typeOfIntervention = string.Empty;

    [Name("Type d'intervention")]
    [Column(Column = "L")]
    public string TypeOfIntervention
    {
        get => _typeOfIntervention;
        set
        {
            _typeOfIntervention = value;
            OnPropertyChanged();
        }
    }

    private string _typeOfControl = string.Empty;

    [Name("Type de contrôle")]
    [Column(Column = "M")]
    public string TypeOfControl
    {
        get => _typeOfControl;
        set
        {
            _typeOfControl = value;
            OnPropertyChanged();
        }
    }

    private string _commune = string.Empty;

    [Name("Commune")]
    [Column(Column = "N")]
    public string Commune
    {
        get => _commune;
        set
        {
            _commune = value;
            OnPropertyChanged();
        }
    }

    private string _department = string.Empty;

    [Name("Département")]
    [Column(Column = "O")]
    public string Department
    {
        get => _department;
        set
        {
            _department = value;
            OnPropertyChanged();
        }
    }

    private string _address = string.Empty;

    [Name("Adresse")]
    [Column(Column = "P")]
    public string Address
    {
        get => _address;
        set
        {
            _address = value;
            OnPropertyChanged();
        }
    }

    private string _batchNumber = string.Empty;

    [Name("Numéro de lot")]
    [Column(Column = "Q")]
    public string BatchNumber
    {
        get => _batchNumber;
        set
        {
            _batchNumber = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfOccurrences = string.Empty;

    [Name("Nombre d'occurences")]
    [Column(Column = "R")]
    public string NumberOfOccurrences
    {
        get => _numberOfOccurrences;
        set
        {
            _numberOfOccurrences = value;
            OnPropertyChanged();
        }
    }

    private string _costOfTheConstructionSite = string.Empty;

    [Name("Coùt du chantier")]
    [Column(Column = "S")]
    public string CostOfTheConstructionSite
    {
        get => _costOfTheConstructionSite;
        set
        {
            _costOfTheConstructionSite = value;
            OnPropertyChanged();
        }
    }

    private string _countedInSamples = string.Empty;

    [Name("Compté dans les echantillons")]
    [Column(Column = "T")]
    public string CountedInSamples
    {
        get => _countedInSamples;
        set
        {
            _countedInSamples = value;
            OnPropertyChanged();
        }
    }

    private string _dateCreationDite = string.Empty;

    [Name("Date création chantier")]
    [Column(Column = "U")]
    public string DateCreationDite
    {
        get => _dateCreationDite;
        set
        {
            _dateCreationDite = value;
            OnPropertyChanged();
        }
    }

    private string _siteCreator = string.Empty;

    [Name("Créateur chantier")]
    [Column(Column = "V")]
    public string SiteCreator
    {
        get => _siteCreator;
        set
        {
            _siteCreator = value;
            OnPropertyChanged();
        }
    }

    private string _siteCommentary = string.Empty;

    [Name("Commentaire chantier")]
    [Column(Column = "W")]
    public string SiteCommentary
    {
        get => _siteCommentary;
        set
        {
            _siteCommentary = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfFilesAttachedToTheSite = string.Empty;

    [Name("Nbre de fichiers joint chantier")]
    [Column(Column = "X")]
    public string NumberOfFilesAttachedToTheSite
    {
        get => _numberOfFilesAttachedToTheSite;
        set
        {
            _numberOfFilesAttachedToTheSite = value;
            OnPropertyChanged();
        }
    }

    private string _typeOfConnection = string.Empty;

    [Name("Type de raccordement")]
    [Column(Column = "Y")]
    public string TypeOfConnection
    {
        get => _typeOfConnection;
        set
        {
            _typeOfConnection = value;
            OnPropertyChanged();
        }
    }

    private string _buildingOperator = string.Empty;

    [Name("Opérateur immeuble")]
    [Column(Column = "Z")]
    public string BuildingOperator
    {
        get => _buildingOperator;
        set
        {
            _buildingOperator = value;
            OnPropertyChanged();
        }
    }

    private string _commercialOperator = string.Empty;

    [Name("Opérateur commercial")]
    [Column(Column = "AA")]
    public string CommercialOperator
    {
        get => _commercialOperator;
        set
        {
            _commercialOperator = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfDwellings = string.Empty;

    [Name("Nbre de logements")]
    [Column(Column = "AB")]
    public string NumberOfDwellings
    {
        get => _numberOfDwellings;
        set
        {
            _numberOfDwellings = value;
            OnPropertyChanged();
        }
    }

    private string _checklistId = string.Empty;

    [Name("Identifiant fiche de contrôle")]
    [Column(Column = "AC")]
    public string ChecklistId
    {
        get => _checklistId;
        set
        {
            _checklistId = value;
            OnPropertyChanged();
        }
    }

    private string _identifierMasterFile = string.Empty;

    [Name("Identifiant fiche mére")]
    [Column(Column = "AD")]
    public string IdentifierMasterFile
    {
        get => _identifierMasterFile;
        set
        {
            _identifierMasterFile = value;
            OnPropertyChanged();
        }
    }

    private string _daughterFileId = string.Empty;

    [Name("Identifiant fiche fille")]
    [Column(Column = "AE")]
    public string DaughterFileId
    {
        get => _daughterFileId;
        set
        {
            _daughterFileId = value;
            OnPropertyChanged();
        }
    }

    private string _recordNumber = string.Empty;

    [Name("Numéro de la fiche")]
    [Column(Column = "AF")]
    public string RecordNumber
    {
        get => _recordNumber;
        set
        {
            _recordNumber = value;
            OnPropertyChanged();
        }
    }

    private string _conditionOfTheCard = string.Empty;

    [Name("Etat de la fiche")]
    [Column(Column = "AG")]
    public string ConditionOfTheCard
    {
        get => _conditionOfTheCard;
        set
        {
            _conditionOfTheCard = value;
            OnPropertyChanged();
        }
    }

    private string _validationResult = string.Empty;

    [Name("Résultat de validation")]
    [Column(Column = "AH")]
    public string ValidationResult
    {
        get => _validationResult;
        set
        {
            _validationResult = value;
            OnPropertyChanged();
        }
    }

    private string _resultOfTheRecoveryAnalysis = string.Empty;

    [Name("Résultat de l'analyse de reprise")]
    [Column(Column = "AI")]
    public string ResultOfTheRecoveryAnalysis
    {
        get => _resultOfTheRecoveryAnalysis;
        set
        {
            _resultOfTheRecoveryAnalysis = value;
            OnPropertyChanged();
        }
    }

    private string _presenceOfTheSupplier = string.Empty;

    [Name("Présence founisseur")]
    [Column(Column = "AJ")]
    public string PresenceOfTheSupplier
    {
        get => _presenceOfTheSupplier;
        set
        {
            _presenceOfTheSupplier = value;
            OnPropertyChanged();
        }
    }

    private string _contradictoryVisit = string.Empty;

    [Name("Visite contradictoire")]
    [Column(Column = "AK")]
    public string ContradictoryVisit
    {
        get => _contradictoryVisit;
        set
        {
            _contradictoryVisit = value;
            OnPropertyChanged();
        }
    }

    private string _billingToBeCorrected = string.Empty;

    [Name("Facturation à corriger")]
    [Column(Column = "AL")]
    public string BillingToBeCorrected
    {
        get => _billingToBeCorrected;
        set
        {
            _billingToBeCorrected = value;
            OnPropertyChanged();
        }
    }

    private string _securityToBeFixed = string.Empty;

    [Name("Sécurité à corriger")]
    [Column(Column = "AM")]
    public string SecurityToBeFixed
    {
        get => _securityToBeFixed;
        set
        {
            _securityToBeFixed = value;
            OnPropertyChanged();
        }
    }

    private string _seriousMisconduct = string.Empty;

    [Name("Manquement grave")]
    [Column(Column = "AN")]
    public string SeriousMisconduct
    {
        get => _seriousMisconduct;
        set
        {
            _seriousMisconduct = value;
            OnPropertyChanged();
        }
    }

    private string _rightOfReply = string.Empty;

    [Name("Droit de réponse réalisé")]
    [Column(Column = "AO")]
    public string RightOfReply
    {
        get => _rightOfReply;
        set
        {
            _rightOfReply = value;
            OnPropertyChanged();
        }
    }

    private string _sumOfTheEconomicImpactAward = string.Empty;

    [Name("Somme du prix impacts économiques")]
    [Column(Column = "AP")]
    public string SumOfTheEconomicImpactAward
    {
        get => _sumOfTheEconomicImpactAward;
        set
        {
            _sumOfTheEconomicImpactAward = value;
            OnPropertyChanged();
        }
    }

    private string _tienc = string.Empty;

    [Name("TIENC")]
    [Column(Column = "AQ")]
    public string Tienc
    {
        get => _tienc;
        set
        {
            _tienc = value;
            OnPropertyChanged();
        }
    }

    private string _tct = string.Empty;

    [Name("TCT")]
    [Column(Column = "AR")]
    public string Tct
    {
        get => _tct;
        set
        {
            _tct = value;
            OnPropertyChanged();
        }
    }

    private string _sumOfTheWeightsOfTheCompliantPointsOfTheTechnicalItems = string.Empty;

    [Name("Somme des poids des points conformes  des items techniques")]
    [Column(Column = "AS")]
    public string SumOfTheWeightsOfTheCompliantPointsOfTheTechnicalItems
    {
        get => _sumOfTheWeightsOfTheCompliantPointsOfTheTechnicalItems;
        set
        {
            _sumOfTheWeightsOfTheCompliantPointsOfTheTechnicalItems = value;
            OnPropertyChanged();
        }
    }

    private string _sumOfTheWeightsOfThePointsCheckedOfTheTechnicalItems = string.Empty;

    [Name("Somme des poids des points vérifiés des items techniques")]
    [Column(Column = "AT")]
    public string SumOfTheWeightsOfThePointsCheckedOfTheTechnicalItems
    {
        get => _sumOfTheWeightsOfThePointsCheckedOfTheTechnicalItems;
        set
        {
            _sumOfTheWeightsOfThePointsCheckedOfTheTechnicalItems = value;
            OnPropertyChanged();
        }
    }

    private string _sumOfThePricesOfTheCompliantPointsOfTheTechnicalItems = string.Empty;

    [Name("Somme des prix des points conformes  des items techniques")]
    [Column(Column = "AU")]
    public string SumOfThePricesOfTheCompliantPointsOfTheTechnicalItems
    {
        get => _sumOfThePricesOfTheCompliantPointsOfTheTechnicalItems;
        set
        {
            _sumOfThePricesOfTheCompliantPointsOfTheTechnicalItems = value;
            OnPropertyChanged();
        }
    }

    private string _sumOfThePricesOfThePointsCheckedForTechnicalItems = string.Empty;

    [Name("Somme des prix des points vérifiés des items techniques")]
    [Column(Column = "AV")]
    public string SumOfThePricesOfThePointsCheckedForTechnicalItems
    {
        get => _sumOfThePricesOfThePointsCheckedForTechnicalItems;
        set
        {
            _sumOfThePricesOfThePointsCheckedForTechnicalItems = value;
            OnPropertyChanged();
        }
    }

    private string _dateOfWork = string.Empty;

    [Name("Date des travaux")]
    [Column(Column = "AW")]
    public string DateOfWork
    {
        get => _dateOfWork;
        set
        {
            _dateOfWork = value;
            OnPropertyChanged();
        }
    }

    private string _dateVerified = string.Empty;

    [Name("Date vérification")]
    [Column(Column = "AX")]
    public string DateVerified
    {
        get => _dateVerified;
        set
        {
            _dateVerified = value;
            OnPropertyChanged();
        }
    }

    private string _dateCreationForm = string.Empty;

    [Name("Date création fiche")]
    [Column(Column = "AY")]
    public string DateCreationForm
    {
        get => _dateCreationForm;
        set
        {
            _dateCreationForm = value;
            OnPropertyChanged();
        }
    }

    private string _dateValidation = string.Empty;

    [Name("Date validation")]
    [Column(Column = "AZ")]
    public string DateValidation
    {
        get => _dateValidation;
        set
        {
            _dateValidation = value;
            OnPropertyChanged();
        }
    }

    private string _urgencyCriteria = string.Empty;

    [Name("Critére d'urgence")]
    [Column(Column = "BA")]
    public string UrgencyCriteria
    {
        get => _urgencyCriteria;
        set
        {
            _urgencyCriteria = value;
            OnPropertyChanged();
        }
    }

    private string _expectedResumptionDateAndTime = string.Empty;

    [Name("Date et heure de reprise attendue")]
    [Column(Column = "BB")]
    public string ExpectedResumptionDateAndTime
    {
        get => _expectedResumptionDateAndTime;
        set
        {
            _expectedResumptionDateAndTime = value;
            OnPropertyChanged();
        }
    }

    private string _dateAndTimeOfResumption = string.Empty;

    [Name("Date et heure de reprise")]
    [Column(Column = "BC")]
    public string DateAndTimeOfResumption
    {
        get => _dateAndTimeOfResumption;
        set
        {
            _dateAndTimeOfResumption = value;
            OnPropertyChanged();
        }
    }

    private string _dateRecoveryScan = string.Empty;

    [Name("Date analyse de reprise")]
    [Column(Column = "BD")]
    public string DateRecoveryScan
    {
        get => _dateRecoveryScan;
        set
        {
            _dateRecoveryScan = value;
            OnPropertyChanged();
        }
    }

    private string _endDate = string.Empty;

    [Name("Date clôture")]
    [Column(Column = "BE")]
    public string EndDate
    {
        get => _endDate;
        set
        {
            _endDate = value;
            OnPropertyChanged();
        }
    }

    private string _cancellationDate = string.Empty;

    [Name("Date annulation")]
    [Column(Column = "BF")]
    public string CancellationDate
    {
        get => _cancellationDate;
        set
        {
            _cancellationDate = value;
            OnPropertyChanged();
        }
    }

    private string _dateArchived = string.Empty;

    [Name("Date archivage")]
    [Column(Column = "BG")]
    public string DateArchived
    {
        get => _dateArchived;
        set
        {
            _dateArchived = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfPartsAttachedToTheVerification = string.Empty;

    [Name("Nbre piéces jointes à la vérification")]
    [Column(Column = "BH")]
    public string NumberOfPartsAttachedToTheVerification
    {
        get => _numberOfPartsAttachedToTheVerification;
        set
        {
            _numberOfPartsAttachedToTheVerification = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfPartsAttachedToTheResumption = string.Empty;

    [Name("Nbre piéces jointes à la reprise")]
    [Column(Column = "BI")]
    public string NumberOfPartsAttachedToTheResumption
    {
        get => _numberOfPartsAttachedToTheResumption;
        set
        {
            _numberOfPartsAttachedToTheResumption = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfPointsOk = string.Empty;

    [Name("Nbre points OK")]
    [Column(Column = "BJ")]
    public string NumberOfPointsOk
    {
        get => _numberOfPointsOk;
        set
        {
            _numberOfPointsOk = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfPointsKo = string.Empty;

    [Name("Nbre points KO")]
    [Column(Column = "BK")]
    public string NumberOfPointsKo
    {
        get => _numberOfPointsKo;
        set
        {
            _numberOfPointsKo = value;
            OnPropertyChanged();
        }
    }

    private string _verifiedCommentary = string.Empty;

    [Name("Commentaire vérif.")]
    [Column(Column = "BL")]
    public string VerifiedCommentary
    {
        get => _verifiedCommentary;
        set
        {
            _verifiedCommentary = value;
            OnPropertyChanged();
        }
    }

    private string _commentTakenUp = string.Empty;

    [Name("Commentaire reprise")]
    [Column(Column = "BM")]
    public string CommentTakenUp
    {
        get => _commentTakenUp;
        set
        {
            _commentTakenUp = value;
            OnPropertyChanged();
        }
    }

    private string _billingAcknowledgementRequirementProcessingDate = string.Empty;

    [Name("Date de traitement du besoin d'acquittement en facturation ")]
    [Column(Column = "BN")]
    public string BillingAcknowledgementRequirementProcessingDate
    {
        get => _billingAcknowledgementRequirementProcessingDate;
        set
        {
            _billingAcknowledgementRequirementProcessingDate = value;
            OnPropertyChanged();
        }
    }

    private string _commentOnTheTreatmentOfTheNeedForBillingAcknowledgement = string.Empty;

    [Name("Commentaire de traitement du besoin d'acquittement en facturation ")]
    [Column(Column = "BO")]
    public string CommentOnTheTreatmentOfTheNeedForBillingAcknowledgement
    {
        get => _commentOnTheTreatmentOfTheNeedForBillingAcknowledgement;
        set
        {
            _commentOnTheTreatmentOfTheNeedForBillingAcknowledgement = value;
            OnPropertyChanged();
        }
    }

    private string _actionOfProcessingTheNeedForAcknowledgmentInInvoicing = string.Empty;

    [Name("Action de traitement du besoin d'acquittement en facturation ")]
    [Column(Column = "BP")]
    public string ActionOfProcessingTheNeedForAcknowledgmentInInvoicing
    {
        get => _actionOfProcessingTheNeedForAcknowledgmentInInvoicing;
        set
        {
            _actionOfProcessingTheNeedForAcknowledgmentInInvoicing = value;
            OnPropertyChanged();
        }
    }

    private string _dateOfProcessingTheNeedForSecureAcquittal = string.Empty;

    [Name("Date de traitement du besoin d'acquittement  en sécurité")]
    [Column(Column = "BQ")]
    public string DateOfProcessingTheNeedForSecureAcquittal
    {
        get => _dateOfProcessingTheNeedForSecureAcquittal;
        set
        {
            _dateOfProcessingTheNeedForSecureAcquittal = value;
            OnPropertyChanged();
        }
    }

    private string _commentOnTheTreatmentOfTheNeedForSecureAcquittal = string.Empty;

    [Name("Commentaire de traitement du besoin d'acquittement  en sécurité")]
    [Column(Column = "BR")]
    public string CommentOnTheTreatmentOfTheNeedForSecureAcquittal
    {
        get => _commentOnTheTreatmentOfTheNeedForSecureAcquittal;
        set
        {
            _commentOnTheTreatmentOfTheNeedForSecureAcquittal = value;
            OnPropertyChanged();
        }
    }

    private string _actionToAddressTheNeedForSecureAcquittal = string.Empty;

    [Name("Action de traitement du besoin d'acquittement  en sécurité")]
    [Column(Column = "BS")]
    public string ActionToAddressTheNeedForSecureAcquittal
    {
        get => _actionToAddressTheNeedForSecureAcquittal;
        set
        {
            _actionToAddressTheNeedForSecureAcquittal = value;
            OnPropertyChanged();
        }
    }

    private string _dateOfProcessingTheNeedForAcquittalOfSeriousBreach = string.Empty;

    [Name("Date de traitement du besoin d'acquittement de manquement grave")]
    [Column(Column = "BT")]
    public string DateOfProcessingTheNeedForAcquittalOfSeriousBreach
    {
        get => _dateOfProcessingTheNeedForAcquittalOfSeriousBreach;
        set
        {
            _dateOfProcessingTheNeedForAcquittalOfSeriousBreach = value;
            OnPropertyChanged();
        }
    }

    private string _commentOnTheTreatmentOfTheNeedForAcquittalOfSeriousBreach = string.Empty;

    [Name("Commentaire de traitement du besoin d'acquittement de manquement grave")]
    [Column(Column = "BU")]
    public string CommentOnTheTreatmentOfTheNeedForAcquittalOfSeriousBreach
    {
        get => _commentOnTheTreatmentOfTheNeedForAcquittalOfSeriousBreach;
        set
        {
            _commentOnTheTreatmentOfTheNeedForAcquittalOfSeriousBreach = value;
            OnPropertyChanged();
        }
    }

    private string _treatmentActionNeedAcknowledgmentOfSeriousBreach = string.Empty;

    [Name("Action de traitement besoin d'acquittement  de manquement grave")]
    [Column(Column = "BV")]
    public string TreatmentActionNeedAcknowledgmentOfSeriousBreach
    {
        get => _treatmentActionNeedAcknowledgmentOfSeriousBreach;
        set
        {
            _treatmentActionNeedAcknowledgmentOfSeriousBreach = value;
            OnPropertyChanged();
        }
    }

    private string _typeOfContract = string.Empty;

    [Name("Type de contrat")]
    [Column(Column = "BW")]
    public string TypeOfContract
    {
        get => _typeOfContract;
        set
        {
            _typeOfContract = value;
            OnPropertyChanged();
        }
    }

    private string _interventionCreatedInGpc = string.Empty;

    [Name("Intervention créée dans GPC ")]
    [Column(Column = "BX")]
    public string InterventionCreatedInGpc
    {
        get => _interventionCreatedInGpc;
        set
        {
            _interventionCreatedInGpc = value;
            OnPropertyChanged();
        }
    }

    private string _poidsRcc = string.Empty;

    [Name("poids RCC ")]
    [Column(Column = "BY")]
    public string PoidsRcc
    {
        get => _poidsRcc;
        set
        {
            _poidsRcc = value;
            OnPropertyChanged();
        }
    }

    private string _controlCategory = string.Empty;

    [Name("Catégorie de contrôle")]
    [Column(Column = "BZ")]
    public string ControlCategory
    {
        get => _controlCategory;
        set
        {
            _controlCategory = value;
            OnPropertyChanged();
        }
    }

    private string _nameItemQredic = string.Empty;

    [Name("Nom item Qredic")]
    [Column(Column = "CA")]
    public string NameItemQredic
    {
        get => _nameItemQredic;
        set
        {
            _nameItemQredic = value;
            OnPropertyChanged();
        }
    }

    private string _checkpoint = string.Empty;

    [Name("Point de contrôle")]
    [Column(Column = "CB")]
    public string Checkpoint
    {
        get => _checkpoint;
        set
        {
            _checkpoint = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfOccurrencesKo = string.Empty;

    [Name("Nbre occurence KO")]
    [Column(Column = "CC")]
    public string NumberOfOccurrencesKo
    {
        get => _numberOfOccurrencesKo;
        set
        {
            _numberOfOccurrencesKo = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfOccurrencesOk = string.Empty;

    [Name("Nbre occurences OK")]
    [Column(Column = "CD")]
    public string NumberOfOccurrencesOk
    {
        get => _numberOfOccurrencesOk;
        set
        {
            _numberOfOccurrencesOk = value;
            OnPropertyChanged();
        }
    }

    private string _checkpointComment = string.Empty;

    [Name("Commentaire pour le point de contrôle")]
    [Column(Column = "CE")]
    public string CheckpointComment
    {
        get => _checkpointComment;
        set
        {
            _checkpointComment = value;
            OnPropertyChanged();
        }
    }

    private string _weight = string.Empty;

    [Name("Poids")]
    [Column(Column = "CF")]
    public string Weight
    {
        get => _weight;
        set
        {
            _weight = value;
            OnPropertyChanged();
        }
    }

    private string _price = string.Empty;

    [Name("Prix")]
    [Column(Column = "CG")]
    public string Price
    {
        get => _price;
        set
        {
            _price = value;
            OnPropertyChanged();
        }
    }

    private string _percentage = string.Empty;

    [Name("Pourcentage")]
    [Column(Column = "CH")]
    public string Percentage
    {
        get => _percentage;
        set
        {
            _percentage = value;
            OnPropertyChanged();
        }
    }

    private string _theoreticalImpactOfTheCheckpoint = string.Empty;

    [Name("Impact théorique du point de contrôle")]
    [Column(Column = "CI")]
    public string TheoreticalImpactOfTheCheckpoint
    {
        get => _theoreticalImpactOfTheCheckpoint;
        set
        {
            _theoreticalImpactOfTheCheckpoint = value;
            OnPropertyChanged();
        }
    }

    private string _numberOfOccurrencesKoOfTheConstructionSite = string.Empty;

    [Name("Nbre d'occurrences KO du chantier")]
    [Column(Column = "CJ")]
    public string NumberOfOccurrencesKoOfTheConstructionSite
    {
        get => _numberOfOccurrencesKoOfTheConstructionSite;
        set
        {
            _numberOfOccurrencesKoOfTheConstructionSite = value;
            OnPropertyChanged();
        }
    }

    private string _cancellationCommentSheet = string.Empty;

    [Name("Commentaire d'annulation fiche")]
    [Column(Column = "CK")]
    public string CancellationCommentSheet
    {
        get => _cancellationCommentSheet;
        set
        {
            _cancellationCommentSheet = value;
            OnPropertyChanged();
        }
    }

    private string _nameCancellCard = string.Empty;

    [Name("Nom annuleur fiche")]
    [Column(Column = "CL")]
    public string NameCancellCard
    {
        get => _nameCancellCard;
        set
        {
            _nameCancellCard = value;
            OnPropertyChanged();
        }
    }

    private string _dateRightOfReply = string.Empty;

    [Name("Date droit de réponse")]
    [Column(Column = "CM")]
    public string DateRightOfReply
    {
        get => _dateRightOfReply;
        set
        {
            _dateRightOfReply = value;
            OnPropertyChanged();
        }
    }

    private string _decisionFollowingRightOfReply = string.Empty;

    [Name("Décision suite droit réponse")]
    [Column(Column = "CN")]
    public string DecisionFollowingRightOfReply
    {
        get => _decisionFollowingRightOfReply;
        set
        {
            _decisionFollowingRightOfReply = value;
            OnPropertyChanged();
        }
    }

    private string _commentCorrectionSheet = string.Empty;

    [Name("Commentaire correction fiche")]
    [Column(Column = "CO")]
    public string CommentCorrectionSheet
    {
        get => _commentCorrectionSheet;
        set
        {
            _commentCorrectionSheet = value;
            OnPropertyChanged();
        }
    }

    private string _controlCategoryComment = string.Empty;

    [Name("Commentaire de catégorie de contrôle")]
    [Column(Column = "CP")]
    public string ControlCategoryComment
    {
        get => _controlCategoryComment;
        set
        {
            _controlCategoryComment = value;
            OnPropertyChanged();
        }
    }

    private string _url = string.Empty;

    [Name("Url")]
    [Column(Column = "CQ")]
    public string Url
    {
        get => _url;
        set
        {
            _url = value;
            OnPropertyChanged();
        }
    }

    private string _respectForQualityIndicator = string.Empty;

    [Name("Indicateur Respect de la Qualité")]
    [Column(Column = "CR")]
    public string RespectForQualityIndicator
    {
        get => _respectForQualityIndicator;
        set
        {
            _respectForQualityIndicator = value;
            OnPropertyChanged();
        }
    }

    private string _securityIndicator = string.Empty;

    [Name("Indicateur Sécurité")]
    [Column(Column = "CS")]
    public string SecurityIndicator
    {
        get => _securityIndicator;
        set
        {
            _securityIndicator = value;
            OnPropertyChanged();
        }
    }

    private string _environmentIndicator = string.Empty;

    [Name("Indicateur Environnement")]
    [Column(Column = "CT")]
    public string EnvironmentIndicator
    {
        get => _environmentIndicator;
        set
        {
            _environmentIndicator = value;
            OnPropertyChanged();
        }
    }

    private string _customerRelationshipIndicator = string.Empty;

    [Name("Indicateur relation Client")]
    [Column(Column = "CU")]
    public string CustomerRelationshipIndicator
    {
        get => _customerRelationshipIndicator;
        set
        {
            _customerRelationshipIndicator = value;
            OnPropertyChanged();
        }
    }

    private string _compositeIndicator = string.Empty;

    [Name("Indicateur Composite")]
    [Column(Column = "CV")]
    public string CompositeIndicator
    {
        get => _compositeIndicator;
        set
        {
            _compositeIndicator = value;
            OnPropertyChanged();
        }
    }

    private string _typeOfRestitution = string.Empty;

    [Name("Type de restitution")]
    [Column(Column = "CW")]
    public string TypeOfRestitution
    {
        get => _typeOfRestitution;
        set
        {
            _typeOfRestitution = value;
            OnPropertyChanged();
        }
    }

    private string _perimeterOfControl = string.Empty;

    [Name("Périmètre de contrôle")]
    [Column(Column = "CX")]
    public string PerimeterOfControl
    {
        get => _perimeterOfControl;
        set
        {
            _perimeterOfControl = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}