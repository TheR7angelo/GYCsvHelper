using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using LibsPlaningAChaud.Sql;
using LibsPlaningAChaud.Sql.Struc;

namespace GYCsvHelper.UserControls;

public partial class Contacts
{
    private readonly SqlHandler _sqlHandler;
    private readonly List<FrameworkElement> ListContactDefinition;
    private bool _newContact;

    public Contact ContactSelected { get; } = new();

    public ObservableCollection<Contact> CollectionContacts { get; } = new();

    public Contacts(SqlHandler sqlHandler)
    {
        _sqlHandler = sqlHandler;
        _newContact = false;

        InitializeComponent();
        ListContactDefinition = new List<FrameworkElement>(GridContactDefinition.Children.Cast<FrameworkElement>()
            .Where(s => s.GetType() != typeof(Label)));

        var contacts = sqlHandler.GetAllContact();
        foreach (var contact in contacts) CollectionContacts.Add(contact);
    }

    private void ButtonContactName_OnClick(object sender, RoutedEventArgs e)
    {
        var button = (ToggleButton)sender;

        Contact contact;
        if (button.IsChecked ?? false)
        {
            contact = ((sender as FrameworkElement)!.DataContext as Contact)!;
            SetEnableGrid(true);
        }
        else
        {
            contact = new Contact();
            SetEnableGrid(false);
        }

        foreach (var property in typeof(Contact).GetProperties().Where(p => p.CanWrite))
        {
            property.SetValue(ContactSelected, property.GetValue(contact, null), null);
        }
    }

    private void SetEnableGrid(bool enable)
    {
        foreach (var item in ListContactDefinition) item.IsEnabled = enable;
    }

    private void ButtonValidChangeContact_OnClick(object sender, RoutedEventArgs e)
        => _sqlHandler.UpdateCantact(ContactSelected);
}