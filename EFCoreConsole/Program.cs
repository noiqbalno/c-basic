using EFCoreLibrary;
using EFCoreLibrary.AdventureContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static IConfigurationRoot _configuration;
    private static DbContextOptionsBuilder<AdventureWorks2019Context> _optionBuilder;

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BuildConfiguration();
        BuildOptions();
        ListPerson();
        CrudPerson();
    }

    private static void BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        _configuration = builder.Build();

        Console.WriteLine(_configuration.GetConnectionString("AdventureWorksDS"));

    }

    static void BuildOptions()
    {
        _optionBuilder = new DbContextOptionsBuilder<AdventureWorks2019Context>();
        _optionBuilder.UseSqlServer(_configuration.GetConnectionString("AdventureWorksDS"));
    }

    static void ListPerson()
    {
        using (var db = new AdventureWorks2019Context(_optionBuilder.Options))
        {
            var persons = db.People.OrderByDescending(x => x.FirstName).Take(20).ToList();
            foreach (var item in persons)
            {
                Console.WriteLine($"namaewa: {item.FirstName} {item.LastName}");
            }
        }
    }

    static void CrudPerson()
    {

        using (var db = new AdventureWorks2019Context(_optionBuilder.Options))
        {
            //insert data into table businessentity
            BusinessEntity businessEntity = new BusinessEntity();
            db.Add(businessEntity);
            //db.SaveChanges();

            Console.WriteLine($"bussId: {businessEntity.BusinessEntityId}");

            var person = new Person()
            {
                FirstName = "Kang 3",
                LastName = "Dian 3",
                PersonType = "EM",
                BusinessEntity = businessEntity
            };

            db.Add(person);
            db.SaveChanges();

            Console.WriteLine($"New Person: {person.BusinessEntityId} {person.FirstName} {person.LastName} {person.PersonType}");

            //find
            var foundPerson = db.People.Find(businessEntity.BusinessEntityId);
            Console.WriteLine($"Find Person: {foundPerson.BusinessEntityId} {foundPerson.FirstName} {foundPerson.LastName} {foundPerson.PersonType}");

            //update person
            person.FirstName = "Rini";
            person.LastName = "Marlina";
            db.Update(person);
            db.SaveChanges();
            
            Console.WriteLine($"Update Person: {person.BusinessEntityId} {person.FirstName} {person.LastName} {person.PersonType}");

            // delete person

            db.People.Remove(foundPerson);
            db.SaveChanges();
        }
    }
}