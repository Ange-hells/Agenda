﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using agenda.Resources;

namespace agenda
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructeur
		public MainPage()
		{
			InitializeComponent();

			// Exemple de code pour la localisation d'ApplicationBar
			//BuildLocalizedApplicationBar();
		}

		private void AjouterContact_Tap(object sender, System.Windows.Input.GestureEventArgs e)
		{
			NavigationService.Navigate(new Uri("/AjouterContact.xaml", UriKind.Relative));
		}

		private void Rendez_vous_Tap(object sender, System.Windows.Input.GestureEventArgs e)
		{

		}

		private void Contact_Tap(object sender, System.Windows.Input.GestureEventArgs e)
		{
			NavigationService.Navigate(new Uri("/PageContact.xaml", UriKind.Relative));
		}

		private void Info_Tap(object sender, System.Windows.Input.GestureEventArgs e)
		{

		}


		// Exemple de code pour la conception d'une ApplicationBar localisée
		//private void BuildLocalizedApplicationBar()
		//{
		//    // Définit l'ApplicationBar de la page sur une nouvelle instance d'ApplicationBar.
		//    ApplicationBar = new ApplicationBar();

		//    // Crée un bouton et définit la valeur du texte sur la chaîne localisée issue d'AppResources.
		//    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
		//    appBarButton.Text = AppResources.AppBarButtonText;
		//    ApplicationBar.Buttons.Add(appBarButton);

		//    // Crée un nouvel élément de menu avec la chaîne localisée d'AppResources.
		//    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
		//    ApplicationBar.MenuItems.Add(appBarMenuItem);
		//}
	}
}