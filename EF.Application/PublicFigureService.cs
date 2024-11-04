using Bogus;
using EF.Domain;
using EF.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Person = EF.Domain.Models.Person;

namespace EF.Application;

public class PublicFigureService(DomainContext context) : PersonService(context)
{
    public void UpdateCapital(int personId, int capital)
    {
        
        var person = Context.PublicFigures.Find(personId);
        if (person is null)
        {
            throw new InvalidOperationException("Person does not exist");
        }

        person.Capital = capital;
        Context.SaveChanges();
        
    }

    public void Random(int i, int partnerPerc, int parentPerc, int siblingPerc)
    {
        if (partnerPerc < 0 || partnerPerc > 100 ||
            parentPerc < 0 || parentPerc > 100 ||
            siblingPerc < 0 || siblingPerc > 100)
        {
            throw new Exception("Percentage needs to be in the 0..100 range");
        }

        Randomizer.Seed = new Random();


        var personFaker = new Faker<PublicFigure>()
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(p => p.Gender, f => f.PickRandom(Enum.GetValues<Gender>()))
            .RuleFor(p => p.Capital, f => f.Random.Int(min: 0, max: 100));
        var people = personFaker.Generate(i);

        foreach (var person in people)
        {
            var rand = 0;

            // add second parent based on the gender of the first one
            rand = Randomizer.Seed.Next(100);
            if (rand < parentPerc)
            {
                var parent = people[Randomizer.Seed.Next(people.Count)];
                if (parent != person && !person.Children.Contains(parent))
                    person.Parents.Add(parent);
            }

            rand = Randomizer.Seed.Next(100);
            if (rand < siblingPerc)
            {
                var sibling = people[Randomizer.Seed.Next(people.Count)];
                if (sibling != person && !person.Parents.Contains(sibling) && !person.Children.Contains(sibling))
                    person.Siblings.Add(sibling);
            }


            rand = Randomizer.Seed.Next(100);
            if (rand < partnerPerc)
            {
                var partner = people[Randomizer.Seed.Next(people.Count)];
                if (partner != person && !person.Parents.Contains(partner) && !person.Children.Contains(partner) && !person.Siblings.Contains(partner) && !person.SiblingTo.Contains(partner))
                    person.Partner = partner;
            }

            Context.PublicFigures.Add(person);
        }

        Context.SaveChanges();
    }

    public Person Query()
    {
        var publicFigures = Context.People
            .Include(pf => pf.Parents)
            .Include(pf => pf.Children)
            .Include(pf => pf.Partner)
            .ThenInclude(partner => partner!.Parents)
            .Include(pf => pf.Partner)
            .ThenInclude(partner => partner!.Children)
            .AsNoTracking();

        var richestFamilyMember = publicFigures
            .Select(p => new
            {
                Person = p,
                FamilyCapital = 
                    (p as PublicFigure)!.Capital +
                    (p.Partner == null ? 0 : (p.Partner as PublicFigure)!.Capital) + 
                    p.Parents
                    .Concat(p.Children)
                    .Concat(p.Partner!.Parents)
                    .Concat(p.Partner!.Children)
                    .Distinct()
                    .OfType<PublicFigure>()
                    .Sum(pf => pf.Capital)
            });

        return richestFamilyMember.OrderByDescending(f => f.FamilyCapital).First().Person;
    }
}