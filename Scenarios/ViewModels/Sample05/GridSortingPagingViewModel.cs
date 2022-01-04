using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.Controls;
using Scenarios.Model;
using Scenarios.Services;

namespace Scenarios.ViewModels.Sample05;

public class GridSortingPagingViewModel : Scenarios.ViewModels.MasterPageViewModel
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

    public GridSortingPagingViewModel(CountriesService countriesService)
    {
        this.countriesService = countriesService;
    }

    public override Task PreRender()
    {
        if (Countries.IsRefreshRequired)
        {
            Countries.LoadFromQueryable(countriesService.GetCountriesQueryable());
        }
        return base.PreRender();
    }
}