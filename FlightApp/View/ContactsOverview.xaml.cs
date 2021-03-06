﻿using FlightApp.Models;
using FlightApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FlightApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContactsOverview : Page
    {
        public ContactsOverviewViewModel ViewModel { get; set; }
        public ContactsOverview()
        {
            ViewModel = new ContactsOverviewViewModel();
            InitializeComponent();
        }

        private void Contact_Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Passenger contact = ((Passenger)button.DataContext);
            Frame.Navigate(typeof(ChatView), contact);
        }
    }
}
