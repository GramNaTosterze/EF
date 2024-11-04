using Bogus;
using EF.Domain;
using EF.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EF.Application;

public class EmploymentService(DomainContext context)
{
    private readonly DomainContext _context = context;

    public Employment Create(Employment employment)
    {
        _context.Employments.Add(employment);
        _context.SaveChanges();
        
        return employment;
    }
    
    public List<Employment> GetAll()
    {
        return _context.Employments
            .AsNoTracking()
            .ToList();
    }
    
    public void DeleteById(int employmentId)
    {
        var employment = _context.Employments.Find(employmentId);
        if (employment is null)
        {
            throw new InvalidOperationException("Employment does not exist");
        }

        _context.Employments.Remove(employment);
        _context.SaveChanges();
    }
    
    public void UpdateCompany(int employmentId, String company)
    {
        var employment = _context.Employments.Find(employmentId);
        if (employment is null)
        {
            throw new InvalidOperationException("Employment does not exist");
        }
        employment.Company = company;
        _context.SaveChanges();
    }

    public void UpdateContract(int employmentId, String contract)
    {
        var employment = _context.Employments.Find(employmentId);
        if (employment is null)
        {
            throw new InvalidOperationException("Employment does not exist");
        }

        employment.Contract = contract;
        _context.SaveChanges();
    }
    
    public void UpdatePay(int employmentId, double pay)
    {
        var employment = _context.Employments.Find(employmentId);
        if (employment is null)
        {
            throw new InvalidOperationException("Employment does not exist");
        }

        employment.Pay = pay;
        _context.SaveChanges();
    }

    public void UpdateEmployee(int employmentId, int personId)
    {
        var employment = _context.Employments.Find(employmentId);
        if (employment is null)
        {
            throw new InvalidOperationException("Employment does not exist");
        }
        var person = _context.People.Find(personId);
        if (person is null)
        {
            throw new InvalidOperationException("Person does not exist");
        }
        employment.Employee = person;
        _context.SaveChanges();
    }

    public void RemoveEmployee(int employmentId)
    {
        var employment = _context.Employments.Find(employmentId);
        if (employment is null)
        {
            throw new InvalidOperationException("Employment does not exist");
        }
        employment.Employee = null;
        _context.SaveChanges();
    }

    public void Random(int i, int employmentPerc)
    {
        if (employmentPerc is < 0 or > 100)
        {
            throw new Exception("Percentage needs to be in the 0..100 range");
        }
        Randomizer.Seed = new Random();

        string[] contractTypes = ["contract1", "contract2", "contract3"];
        string[] companies = ["Company1", "Company2", "Company3"];
        var employmentFaker = new Faker<Employment>()
            .RuleFor(e => e.Contract, f => f.PickRandom(contractTypes))
            .RuleFor(e => e.Pay, f => f.Random.Double())
            .RuleFor(e => e.Company, f => f.PickRandom(companies));
        foreach (var employment in employmentFaker.Generate(i))
        {
            var rand = Randomizer.Seed.Next(100);
            if (rand < employmentPerc)
            {
                employment.Employee = _context.People.Find(Randomizer.Seed.Next(i));
            }
            _context.Employments.Add(employment);
        }

        _context.SaveChanges();
    }

    public dynamic AveragePerContractType()
    {
        var query =
            _context.Employments
                .AsNoTracking()
                .GroupBy(e => new { e.Company, e.Contract })
                .Select(g => new
                {
                    Company = g.Key.Company,
                    Contract = g.Key.Contract,
                    AveragePay = g.Average(e => e.Pay)
                });

        return query;
    }
}