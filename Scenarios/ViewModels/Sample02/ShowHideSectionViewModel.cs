using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace Scenarios.ViewModels.Sample02
{
    public class ShowHideSectionViewModel : Scenarios.ViewModels.MasterPageViewModel
    {

        public bool IsCompany { get; set; }

        public string CompanyRegNo { get; set; }

    }
}

