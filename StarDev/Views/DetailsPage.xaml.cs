using System;
using System.Collections.Generic;
using CommonServiceLocator;
using StarDev.Models;
using StarDev.ViewModels;
using Xamarin.Forms;

namespace StarDev.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Location location)
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance(typeof(DetailsPageViewModel));
            ((DetailsPageViewModel)BindingContext).Location = location;
        }
    }
}
