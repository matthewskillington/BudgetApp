using System;
using System.Collections.Generic;
using BudgetApp.Services;
using BudgetApp.ViewModels;
using Xamarin.Forms;

namespace BudgetApp.Views
{
    public partial class NamePageView : ContentPage
    {
        public NamePageView()
        {
            InitializeComponent();
            BindingContext = new NamePageViewModel(new NavigationService());
        }
    }
}
