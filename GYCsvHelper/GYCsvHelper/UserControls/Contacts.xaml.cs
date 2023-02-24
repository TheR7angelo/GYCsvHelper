using System.Collections.ObjectModel;
using System.Windows;
using LibsPlaningAChaud.Sql;
using LibsPlaningAChaud.Sql.Struc;

namespace GYCsvHelper.UserControls;

public partial class Contacts
{
    private SqlHandler _sqlHandler;
    private Contact ContactSelected { get; set; }

    public ObservableCollection<Contact> CollectionContacts { get; } = new();

    public Contacts(SqlHandler sqlHandler)
    {
        InitializeComponent();
        _sqlHandler = sqlHandler;
        ContactSelected = new Contact();

        var contacts = sqlHandler.GetAllContact();
        foreach (var contact in contacts) CollectionContacts.Add(contact);
    }

    private void ButtonContactName_OnClick(object sender, RoutedEventArgs e) 
        => ContactSelected = ((sender as FrameworkElement)!.DataContext as Contact)!;
}