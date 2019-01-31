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
            BudgetItemIdCount = 0;
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

        private int BudgetItemIdCount { get; set; }


        //Adds new item to the budgetItems array and checks for duplicates
        private void AddNewBudgetItem()
        {
            if (!CheckBudgetItemIdDoesntExist())
            {
                budgetItems.Add(new BudgetItem(BudgetItemIdCount, "Item" + (BudgetItemIdCount + 1)));
                BudgetItemIdCount++;
            }
            else
            {
                throw new Exception($"Couldn't add budget item because one already exists with this ID");
            }

        }

        // Checks budget item doesnt already exist with that ID
        // True means item does exist, false means item does not exist
        private bool CheckBudgetItemIdDoesntExist()
        {
            bool result = false;

            for (int i = 0; i < budgetItems.Count; i++)
            {
                if (budgetItems[i].Id == BudgetItemIdCount)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
