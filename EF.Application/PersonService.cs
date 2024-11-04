using Bogus;
using EF.Domain;
using EF.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Person = EF.Domain.Models.Person;

namespace EF.Application;

public class PersonService(DomainContext context)
{
    protected readonly DomainContext Context = context;

    public Person Create(Person person)
    {
        Context.People.Add(person);
        Context.SaveChanges();
        
        return person;
    }

    public List<Person> GetAll()
    {
        return Context.People
            .Include(p => p.Partner)
            .Include(p => p.Parents)
            .Include(p => p.Children)
            .Include(p => p.Siblings)
            .Include(p => p.SiblingTo)
            .Include(p => p.Employments)
            .AsNoTracking()
            .ToList();
    }

    public Person? GetById(int id)
    {
        return Context.People
            .Include(p => p.Partner)
            .Include(p => p.Parents)
            .Include(p => p.Siblings)
            .AsNoTracking()
            .SingleOrDefault(p => p.Id == id);
    }

    public List<Person> GetByEmployment(Employment employment)
    {
        return Context.People
            .AsNoTracking()
            .Where(p => p.Employments.Count(e => e.Id == employment.Id) != 0)
            .ToList();
    }
    
    public void UpdateName(int personId, String name)
    {
        var person = Context.People.Find(personId);
        if (person is null)
            throw new InvalidOperationException("Person does not exist");
        

        person.Name = name;
        Context.SaveChanges();
        
    }
    
    public void UpdateSurname(int personId, String surname)
    {
        var person = Context.People.Find(personId);
        if (person is null)
        {
            throw new InvalidOperationException("Person does not exist");
        }

        person.Surname = surname;
        Context.SaveChanges();
    }
    
    public void UpdatePhoneNumber(int personId, String phoneNumber)
    {
        var person = Context.People.Find(personId);
        if (person is null)
        {
            throw new InvalidOperationException("Person does not exist");
        }

        person.PhoneNumber = phoneNumber;
        Context.SaveChanges();
    }

    public void UpdateGender(int personId, Gender gender)
    {
        var person = Context.People.Find(personId);
        if (person is null)
        {
            throw new InvalidOperationException("Person does not exist");
        }

        person.Gender = gender;
        Context.SaveChanges();   
    }
    
    public void UpdatePartner(int personId, int partnerId)
    {
        var person = Context.People.Find(personId);
        var partner = Context.People.Find(partnerId);

        if (person is null || partner is null)
        {
            throw new InvalidOperationException("Pizza or sauce does not exist");
        }

        person.Partner = partner;
        partner.Partner = person;

        Context.SaveChanges();
    }

    public void AddParent(int personId, int parentId)
    {
        var person = Context.People.Find(personId);
        var parent = Context.People.Find(parentId);

        if (person is null || parent is null)
        {
            throw new InvalidOperationException("Person or parent does not exist");
        }

        person.Parents.Add(parent);

        Context.SaveChanges();
    }
    
    public void AddChild(int personId, int childId)
    {
        var person = Context.People.Find(personId);
        var child = Context.People.Find(childId);

        if (person is null || child is null)
        {
            throw new InvalidOperationException("Person or parent does not exist");
        }

        person.Children.Add(child);

        Context.SaveChanges();
    }

    public void AddSibling(int personId, int siblingId)
    {
        var person = Context.People.Find(personId);
        var sibling = Context.People.Find(siblingId);

        if (person is null || sibling is null)
        {
            throw new InvalidOperationException("Person or parent does not exist");
        }

        person.Siblings.Add(sibling);

        Context.SaveChanges();
    }

    public void RemoveParent(int personId, int parentId)
    {
        var person = Context.People.Find(personId);
        var parent = Context.People.Find(parentId);

        if (person is null || parent is null)
        {
            throw new InvalidOperationException("Person or parent does not exist");
        }

        person.Parents.Remove(parent);

        Context.SaveChanges();
    }

    public void RemoveChild(int personId, int childId)
    {
        var person = Context.People.Find(personId);
        var child = Context.People.Find(childId);

        if (person is null || child is null)
        {
            throw new InvalidOperationException("Person or parent does not exist");
        }

        person.Children.Remove(child);

        Context.SaveChanges();
    }

    public void RemoveSibling(int personId, int siblingId)
    {
        var person = Context.People.Find(personId);
        var sibling = Context.People.Find(siblingId);

        if (person is null || sibling is null)
        {
            throw new InvalidOperationException("Person or parent does not exist");
        }

        person.Siblings.Remove(sibling);

        Context.SaveChanges();
    }

    public void UpdateParent(int personId, int parentId)
    {
        var person = Context.People.Find(personId);
        var parent = Context.People.Find(parentId);

        if (person is null || parent is null)
        {
            throw new InvalidOperationException("Person or parent does not exist");
        }
        
        var oldParent = person.Parents.Find(p => p.Gender == parent.Gender);
        if (oldParent != null)
            person.Parents.Remove(oldParent);
        person.Parents.Add(parent);

        Context.SaveChanges();
    }
    
    public void AddEmployment(int personId, int employmentId)
    {
        var person = Context.People.Find(personId);
        var employment = Context.Employments.Find(employmentId);
        
        if (person is null || employment is null)
        {
            throw new InvalidOperationException("Person or employment does not exist");
        }

        person.Employments.Add(employment);

        Context.SaveChanges();
    }

    public void RemoveEmployment(int personId, int employmentId)
    {
        var person = Context.People.Find(personId);
        var employment = Context.Employments.Find(employmentId);

        if (person is null || employment is null)
        {
            throw new InvalidOperationException("Person or employment does not exist");
        }

        person.Employments.Remove(employment);

        Context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        var personToDelete = Context.People.Find(id);
        if (personToDelete == null) return;
        Context.People.Remove(personToDelete);
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
        
      
        var personFaker = new Faker<Person>()
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(p => p.Gender, f => f.PickRandom(Enum.GetValues<Gender>()));
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

            Context.People.Add(person);
        }

        Context.SaveChanges();
    }

    public Person? FindPersonWithTheMostGrandkids(Gender gender)
    {
        var grandkidsCount =
            Context.People
                .Include(p => p.Children)
                .ThenInclude(c => c.Children) // grandchildren
                .AsNoTracking()
                .Select(person => new
                {
                    Person = person,
                    GrandKidCount = person.Children
                        .SelectMany(child => child.Children)
                        .Count(grandchild => grandchild.Gender == gender)
                });

        return grandkidsCount.OrderByDescending(gc => gc.GrandKidCount).First().Person;
        
    }
}