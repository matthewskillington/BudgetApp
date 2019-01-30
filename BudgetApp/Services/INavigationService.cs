using System;
namespace BudgetApp.Services
{
    public interface INavigationService
    {
        void NavigateToAsync<TViewModel>();
    }
}
