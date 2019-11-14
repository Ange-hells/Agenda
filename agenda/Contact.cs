using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace agenda
{
	class Contact : INotifyPropertyChanged
	{
		private string leNom;
		private string lePrenom;
		private string leMail;
		private string leMobile;

		public event PropertyChangedEventHandler PropertyChanged;

		//public Contact()
		//{ }

		public Contact(string unNom, string unPrenom, string unEmail, string unMobile)
		{
			leNom = unNom;
			lePrenom = unPrenom;
			leMail = unEmail;
			leMobile = unMobile;
		}

		public string Nom
		{
			get { return leNom; }
			set { leNom = value;}
		}

		public string prenom
		{
			get { return lePrenom; }
			set { lePrenom = value;}
		}

		public string mail
		{
			get { return leMail; }
			set { leMail = value;}
		}

		public string mobile
		{
			get { return leMobile; }
			set { leMobile = value;}
		}
	}
	//PropertyChanged(this, newPropertyChangedEventArgs(propertyName));
}
