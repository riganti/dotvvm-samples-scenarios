using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenarios.ViewModels.Sample01;
// BEGIN
public class FormControlsViewModel : MasterPageViewModel
{
    public AddressModel EditedAddress { get; set; } = new();

    public List<string> States => new() { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };

    public async Task Submit()
    {
        // TODO: store data in the database
    }
}
//END