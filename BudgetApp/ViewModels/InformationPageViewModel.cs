using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BudgetApp.Models;
using Xamarin.Forms;

namespace BudgetApp.ViewModels
{
    public class InformationPageViewModel : BindableObject
    {
        public InformationPageViewModel()
        {
            InfoPageLabel = "Information Page";
            budgetItems = new ObservableCollection<BudgetItem>();
        }

        public string InfoPageLabel { get; private set; }

        private ObservableCollection<BudgetItem> _budgetItems;

        public ObservableCollection<BudgetItem> budgetItems {
            get
            {
                return _budgetItems;
            }
            set
            {
                _budgetItems = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand => new Command(AddNewBudgetItem);

        private void AddNewBudgetItem()
        {
            budgetItems.Add(new BudgetItem(6, "Item 2"));
        }
    }
}
