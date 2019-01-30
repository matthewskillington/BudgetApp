using System;
using System.Collections.Generic;
using BudgetApp.ViewModels;
using BudgetApp.Views;
using Xamarin.Forms;

namespace BudgetApp.Services
{
    public class NavigationService : INavigationService
    {
        protected Application CurrentApplication => Application.Current;

        private readonly Dictionary<Type, Type> _mappings;

        public NavigationService()
        {
            _mappings = new Dictionary<Type, Type>();
            CreatePageViewModelMappings();
        }

        public void NavigateToAsync<TViewModel>()
        {
            var page = CreatePage(typeof(TViewModel));
        }

        private object CreatePage(Type viewModelType)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);

            if (pageType == null)
            {
                throw new Exception($"Mapping type for {viewModelType} is not a page registered in the mappings");
            }
            Page page = Activator.CreateInstance(pageType) as Page;
            return page;
        }

        private Type GetPageTypeForViewModel (Type viewModelType)
        {
            if (!_mappings.ContainsKey(viewModelType))
            {
                throw new Exception($"No map found for ${viewModelType} was found on navigation mappings");
            }
            return _mappings[viewModelType];
        }

        private void CreatePageViewModelMappings()
        {
            _mappings.Add(typeof(NamePageViewModel), typeof(NamePageView));
        }
    }
}
