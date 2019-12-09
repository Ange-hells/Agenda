using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Agenda
{
    public partial class GestionContact : PhoneApplicationPage
    {
        public GestionContact()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageVoirContact.xaml", UriKind.Relative));
        }

        private void btnAjouterContact_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageAjouterContact.xaml", UriKind.Relative));
        }
    }
}