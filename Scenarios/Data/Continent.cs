using System.ComponentModel.DataAnnotations.Schema;

namespace Scenarios.Data;

public class Continent
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    public string Name { get; set; }
}