using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Domain.Models;

public enum Gender
{
    Male,
    Female,
    Other,
}

[Table("Person")]
public class Person
{

    [Key]  
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public required string Name { get; set; }
    [Required]
    [MaxLength(50)]
    public required string Surname { get; set; }

    [Required] 
    public required Gender Gender { get; set; } = Gender.Other;
    
    [RegularExpression("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]\\d{3}[\\s.-]\\d{4}$")]
    public string? PhoneNumber { get; set; }
    
    public virtual Person? Partner { get; set; }
    public virtual Person? PartnerTo { get; set; }
    public virtual List<Person> Parents { get; set; } = [];
    public virtual List<Person> Children { get; set; } = [];
    public virtual List<Person> SiblingTo { get; set; } = [];
    public virtual List<Person> Siblings { get; set; } = [];
    public virtual List<Employment> Employments { get; set; } = [];

    public override string ToString()
    {
        return $"{Name} {Surname}";
    }
}