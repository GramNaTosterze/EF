using System.ComponentModel.DataAnnotations;

namespace EF.Domain.Models;
public class Employment
{
    [Key]
    public int Id { get; set; }

    [Required] 
    public required string Company { get; set; }
    [Required]
    public required string Contract { get; set; }
    [Required]
    public required double Pay { get; set; }
    public Person? Employee { get; set; }

    public override string ToString()
    {
        return $"{Contract} - {Pay}";
    }
}