using System;
using System.Collections.Generic;
using BudgetApp.ViewModels;
using Xamarin.Forms;

namespace BudgetApp.Views
{
    public partial class InformationPageView : ContentPage
    {
        public InformationPageView()
        {
            InitializeComponent();
            BindingContext = new InformationPageViewModel();
        }
    }
}
