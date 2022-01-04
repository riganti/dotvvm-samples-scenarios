using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scenarios.Data;

public class Country
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    public string Name { get; set; }

    public string Currency { get; set; }

    public int ContinentId { get; set; }

    public virtual Continent Continent { get; set; }
}