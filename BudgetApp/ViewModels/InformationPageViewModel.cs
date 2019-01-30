using System;
namespace BudgetApp.ViewModels
{
    public class InformationPageViewModel
    {
        public InformationPageViewModel()
        {
            InfoPageLabel = "Information Page";
        }

        public string InfoPageLabel { get; private set; }
    }
}
