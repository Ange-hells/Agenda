using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO.IsolatedStorage;


namespace Agenda
{
    public partial class PageAjouterContact : PhoneApplicationPage
    {
        public ListeContacts listeContact;

        public PageAjouterContact()
        {
            using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (store.FileExists("Agenda/contact.xml"))
                {
                    using (IsolatedStorageFileStream fileStream = store.OpenFile("Agenda/contact.xml", System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(ListeContacts));
                        listeContact = serializer.Deserialize(fileStream) as ListeContacts;
                        
                    }
                }
                else
                    listeContact = new ListeContacts();

            }
            InitializeComponent();

        }

        private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            // Contact contactCourant = new Contact(Nom.Text.ToString(), Prenom.Text.ToString(), Email.Text.ToString(), Mobile.Text.ToString());
            listeContact.Items.Add(new Contact { Nom = Nom.Text.ToString(),Prenom = Prenom.Text.ToString(),Email = Email.Text.ToString(),Mobile = Mobile.Text.ToString() });
    
           // listeContact.AjouterContact(contactCourant);
            listeContact.Sauvegarder();
        }
    }
}