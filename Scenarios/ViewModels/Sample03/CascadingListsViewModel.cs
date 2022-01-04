using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using Scenarios.Model;
using Scenarios.Services;

namespace Scenarios.ViewModels.Sample03
{
    public class CascadingListsViewModel : Scenarios.ViewModels.MasterPageViewModel
    {
        private readonly CountriesService countriesService;


        public List<ContinentModel> Continents { get; set; }

        public int SelectedContinentId { get; set; } = 1;

        public List<CountryModel> Countries { get; set; }

        public int? SelectedCountryId { get; set; }


        public CascadingListsViewModel(CountriesService countriesService)
        {
            this.countriesService = countriesService;
        }

        public override Task PreRender()
        {
            if (!Context.IsPostBack)
            {
                Continents = countriesService.GetContinents();
                RefreshCountries();
            }
            return base.PreRender();
        }

        public void RefreshCountries()
        {
            Countries = countriesService.GetCountries(SelectedContinentId);
        }
    }
}

