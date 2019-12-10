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
	public class Contact : INotifyPropertyChanged
	{
		private string leNom;
		private string lePrenom;
		private string leMail;
		private string leMobile;



		public Contact()
		{

		}
		public Contact(string unNom, string unPrenom, string unMail, string unMobile)
		{
			leNom = unNom;
			lePrenom = unPrenom;
			leMail = unMail;
			leMobile = unMobile;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public string Nom
		{
			get { return leNom; }
			set
			{
				leNom = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs(leNom));
			}
		}
		public string Prenom
		{
			get { return lePrenom; }
			set
			{
				lePrenom = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs(lePrenom));
			}
		}
		public string Email
		{
			get { return leMail; }
			set
			{
				leMail = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs(leMail));
			}
		}
		public string Mobile
		{
			get { return leMobile; }
			set
			{
				leMobile = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs(leMobile));
			}
		}
	}
}
