using System.Collections.ObjectModel;
using LibsPlaningAChaud.Sql;
using LibsPlaningAChaud.Sql.Struc;

namespace GYCsvHelper.UserControls;

public partial class Contacts
{
    private SqlHandler _sqlHandler;
    private Contact _contactSelected;

    public ObservableCollection<Contact> CollectionContacts { get; } = new();

    public Contacts(SqlHandler sqlHandler)
    {
        InitializeComponent();
        _sqlHandler = sqlHandler;
        _contactSelected = new Contact();

        var contacts = sqlHandler.GetAllContact();
        foreach (var contact in contacts) CollectionContacts.Add(contact);
    }
}