using System;
using System.Windows.Input;
using BudgetApp.Services;
using Xamarin.Forms;

namespace BudgetApp.ViewModels
{
    public class NamePageViewModel : BindableObject
    {
        public INavigationService _navigationService;

        public NamePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NameInputLabel = "Please enter your name";
            NameInputPlaceholder = "Name";
            NameSubmitText = "Submit";
        }

        private string _nameInputLabel;

        public string NameInputLabel {
            get
            {
                return _nameInputLabel;
            }
            private set
            {
                _nameInputLabel = value;
                OnPropertyChanged();
            }
        }

        public string NameInputPlaceholder { get; private set; }

        public string NameSubmitText { get; private set; }

        public string NameInputValue { get; set; }

        public ICommand SubmitCommand => new Command(SubmitNameAndNavigate);


        private void SubmitNameAndNavigate()
        {
            _navigationService.NavigateToAsync<InformationPageViewModel>();
        }


    }
}
