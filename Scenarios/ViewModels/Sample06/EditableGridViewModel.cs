using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.Controls;
using Scenarios.Model;
using Scenarios.Services;

namespace Scenarios.ViewModels.Sample06
{
    public class EditableGridViewModel : Scenarios.ViewModels.MasterPageViewModel
    {

        private readonly CountriesService countriesService;

        public List<ContinentModel> Continents { get; set; }

        public GridViewDataSet<CountryListModel> Countries { get; set; } = new()
        {
            SortingOptions =
            {
                SortExpression = nameof(CountryListModel.Id)
            },
            PagingOptions =
            {
                PageSize = 10
            },
            RowEditOptions =
            {
                PrimaryKeyPropertyName = nameof(CountryListModel.Id)
            }
        };

        public string Search { get; set; }


        public EditableGridViewModel(CountriesService countriesService)
        {
            this.countriesService = countriesService;
        }

        public override Task PreRender()
        {
            if (!Context.IsPostBack)
            {
                Continents = countriesService.GetContinents();
            }

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

        public void EditRow(CountryListModel item)
        {
            Countries.RowEditOptions.EditRowId = item.Id;
        }

        public void CancelEdit()
        {
            Countries.RowEditOptions.EditRowId = null;
            Countries.RequestRefresh();
        }

        public void SaveRow(CountryListModel item)
        {
            countriesService.SaveCountry(item);
            Countries.RowEditOptions.EditRowId = null;
            Countries.RequestRefresh();
        }

    }
}

