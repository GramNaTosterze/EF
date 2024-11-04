using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Domain.Models;

[Table("PublicFigure")]
public class PublicFigure: Person
{
    public int Capital { get; set; }
}