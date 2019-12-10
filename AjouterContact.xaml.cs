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

namespace agenda
{
	public partial class AjouterContact : PhoneApplicationPage
	{
		private ListeContacts listeContact;

		public AjouterContact()
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

		private void BT_Enregistrer_Click(object sender, RoutedEventArgs e)
		{
			// Contact contactCourant = new Contact(Nom.Text.ToString(), Prenom.Text.ToString(), Email.Text.ToString(), Mobile.Text.ToString());
			listeContact.Items.Add(new Contact { Nom = textBox_Nom.Text.ToString(), Prenom = textBox_Prenom.Text.ToString(), Email = textBox_eMail.Text.ToString(), Mobile = textBox_Mobile.Text.ToString() });

			// listeContact.AjouterContact(contactCourant);
			listeContact.Sauvegarder();

		}

		private void SubAjouterContact(string nom, string prenom, string mobile, string eMail)
		{
			

		}

	}

}