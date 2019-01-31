using System;
using Xamarin.Forms;

namespace BudgetApp.Models
{
    public class BudgetItem : BindableObject
    {
        public BudgetItem(int id, string labelName)
        {
            Id = id;
            LabelName = labelName;

        }

        public int Id { get; set; }

        public string LabelName { get; set; }

        public string Name { get; set; }

        public int? Amount { get; set; }



    }
}
