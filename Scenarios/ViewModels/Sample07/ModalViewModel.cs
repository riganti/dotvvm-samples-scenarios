using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.Controls;
using DotVVM.Framework.ViewModel;
using Scenarios.Model;
using Scenarios.Services;

namespace Scenarios.ViewModels.Sample07
{
    public class ModalViewModel : Scenarios.ViewModels.MasterPageViewModel
    {
        private readonly CountriesService countriesService;

        public GridViewDataSet<CountryListModel> Countries { get; set; } = new()
        {
            SortingOptions =
            {
                SortExpression = nameof(CountryListModel.Id)
            },
            PagingOptions =
            {
                PageSize = 10
            }
        };

        public string Search { get; set; }

        public CountryListModel ItemToDelete { get; set; }


        public ModalViewModel(CountriesService countriesService)
        {
            this.countriesService = countriesService;
        }

        public override Task PreRender()
        {
            if (Countries.IsRefreshRequired)
            {
                var query = countriesService.GetCountriesQueryable();
                if (!string.IsNullOrEmpty(Search))
                {
                    query = query.Where(c => c.Name.ToLower().Contains(Search.ToLower()));
                }

                Countries.LoadFromQueryable(query);
            }
            return base.PreRender();
        }

        public void Delete()
        {
            countriesService.DeleteCountry(ItemToDelete);
            ItemToDelete = null;
            Countries.RequestRefresh();
        }
    }
}

