using System.Windows.Data;
using LibsPlaningAChaud.Sql;
using LibsPlaningAChaud.Sql.Struc;

namespace GYCsvHelper.UserControls;

public partial class Contacts
{
    private SqlHandler _sqlHandler;
    private Contact _contactSelected;

    private CollectionView _collectionContacts;
    public Contacts(SqlHandler sqlHandler)
    {
        InitializeComponent();
        _sqlHandler = sqlHandler;
        _contactSelected = new Contact();

        var contact = sqlHandler.GetAllContact();
        _collectionContacts = new CollectionView(contact);
    }
}