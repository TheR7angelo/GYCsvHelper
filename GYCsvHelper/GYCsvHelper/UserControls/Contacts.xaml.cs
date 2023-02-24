using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using LibsPlaningAChaud.Sql;
using LibsPlaningAChaud.Sql.Struc;

namespace GYCsvHelper.UserControls;

public partial class Contacts
{
    private SqlHandler _sqlHandler;

    public Contact ContactSelected { get; } = new();

    public ObservableCollection<Contact> CollectionContacts { get; } = new();

    public Contacts(SqlHandler sqlHandler)
    {
        InitializeComponent();
        _sqlHandler = sqlHandler;

        var contacts = sqlHandler.GetAllContact();
        foreach (var contact in contacts) CollectionContacts.Add(contact);
    }

    private void ButtonContactName_OnClick(object sender, RoutedEventArgs e)
    {
        var contact = ((sender as FrameworkElement)!.DataContext as Contact)!;

        foreach (var property in typeof(Contact).GetProperties().Where(p => p.CanWrite))
        {
            property.SetValue(ContactSelected, property.GetValue(contact, null), null);
        }
    }


    private void ButtonValidChangeContact_OnClick(object sender, RoutedEventArgs e) 
        => _sqlHandler.UpdateCantact(ContactSelected);
}