using System;
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
    private readonly List<FrameworkElement> _listContactDefinition;
    private bool _newContact;

    public Contact ContactSelected { get; } = new();

    public ObservableCollection<Contact> CollectionContacts { get; } = new();

    public Contacts(SqlHandler sqlHandler)
    {
        _sqlHandler = sqlHandler;
        _newContact = false;

        InitializeComponent();
        _listContactDefinition = new List<FrameworkElement>(GridContactDefinition.Children.Cast<FrameworkElement>()
            .Where(s => s.GetType() != typeof(Label)));

        GetAllContacts();
    }

    private void GetAllContacts()
    {
        var contacts = _sqlHandler.GetAllContact();
        CollectionContacts.Clear();
        foreach (var contact in contacts) CollectionContacts.Add(contact);
    }

    private void ButtonContactName_OnClick(object sender, RoutedEventArgs e)
    {
        var button = (ToggleButton)sender;

        Contact contact;
        if (button.IsChecked ?? false)
        {
            _newContact = false;
            contact = ((sender as FrameworkElement)!.DataContext as Contact)!;
            SetEnableGrid(true);
        }
        else
        {
            contact = new Contact();
            SetEnableGrid(false);
        }

        UpdateGridContactDefinition(contact);
    }

    private void ButtonNewContact_OnClick(object sender, RoutedEventArgs e)
    {
        var button = ListBoxContacts.FindVisualChildren<ToggleButton>().FirstOrDefault(s => s.IsChecked.Equals(true));
        if (button is not null) button.IsChecked = false;

        var contact = new Contact();
        _newContact = true;
        UpdateGridContactDefinition(contact);
        SetEnableGrid(true);
    }

    private void UpdateGridContactDefinition(Contact contact)
    {
        foreach (var property in typeof(Contact).GetProperties().Where(p => p.CanWrite))
        {
            property.SetValue(ContactSelected, property.GetValue(contact, null), null);
        }
    }

    private void SetEnableGrid(bool enable)
    {
        foreach (var item in _listContactDefinition) item.IsEnabled = enable;
    }

    private void ButtonValidChangeContact_OnClick(object sender, RoutedEventArgs e)
    {
        if (_newContact)
        {
            var id = unchecked((int)_sqlHandler.NewContact(ContactSelected));
            GetAllContacts();
            UpdateLayout();

            var p = ListBoxContacts.Items.Count;
            var q = CollectionContacts.Count;
            var buttons = ListBoxContacts.FindVisualChildren<ToggleButton>();
            
            // todo trouver un moyen de sélection le nouveau bouton
            foreach (var button in buttons)
            {
                var contact = (Contact)button.DataContext;
                
                if (!contact.Id.Equals(id)) continue;

                button.IsChecked = true;
                break;
            }
            
        }
        else
        {
            _sqlHandler.UpdateCantact(ContactSelected);
        }
    }

    private void ButtonDeleteContact_OnClick(object sender, RoutedEventArgs e)
    {
        var button = ListBoxContacts.FindVisualChildren<ToggleButton>().FirstOrDefault(s => s.IsChecked.Equals(true));
        
        string msg;
        if (button is null)
        {
            msg = "Aucun contact n'a étais sélectionner";
            
        }
        else
        {
            var contact = (Contact)button.DataContext;
            _sqlHandler.DeleteContact(contact);
            msg = $"Le contact {contact.LastName} {contact.FirstName} a étais supprimer";
            GetAllContacts();
        }
        MessageBox.Show(msg);
    }
}