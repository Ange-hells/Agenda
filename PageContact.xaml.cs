using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;

namespace agenda
{
	public partial class PageContact : PhoneApplicationPage
	{
		//private object listContact;
		private ListeContacts listeContact;
		private ObservableCollection<Contact> mesContacts = new ObservableCollection<Contact>();

		public PageContact()
		{
			//InitializeComponent();

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
				{
					listeContact = new ListeContacts();
				}
			}

			foreach (var unContact in listeContact.Items)
			{
				mesContacts.Add(unContact);
			}

			listcontact.ItemsSource = mesContacts;

		}


		private void AjouterContact_Tap(object sender, System.Windows.Input.GestureEventArgs e)
		{
			NavigationService.Navigate(new Uri("/AjouterContact.xaml", UriKind.Relative));

		}
	}
}