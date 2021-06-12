using System;
using System.Collections.Generic;
using CommonServiceLocator;
using StarDev.ViewModels;
using Xamarin.Forms;

namespace StarDev.Views
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance(typeof(ListPageViewModel));
        }
    }
}
