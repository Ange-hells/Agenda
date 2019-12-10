using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace agenda
{
	public class ListeContacts
	{
		public List<Contact> ListeItems { get; set; }

		public ListeContacts()
		{
			ListeItems = new List<Contact> { };
		}

		public List<Contact> Items
		{
			get { return ListeItems; }
			set { ListeItems = value;}
		}

		public void Sauvegarder()
		{
			using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication())
			{
				if (!store.DirectoryExists("Agenda"))
				{
					store.CreateDirectory("Agenda");
				}

				//creation d'un flux pour ecrire un fichier
				using (IsolatedStorageFileStream fileStream = store.OpenFile("Agenda/Contact.xml", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
				{
					//serialisation XML du flux dans le fichier
					XmlSerializer Serializer = new XmlSerializer(typeof(ListeContacts));
					Serializer.Serialize(fileStream, this);
				}
			}
		}
	}
}
