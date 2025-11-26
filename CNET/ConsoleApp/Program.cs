using System.Globalization;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Model;

PeopleDbContext context = new PeopleDbContext();

var person = context.Persons
            .Include(p => p.Address)
            .AsNoTracking()
            .Take(5)
            .ToList()
            .Where(p => p.IsFile())
            .SingleOrDefault();








//Person[] people= [
//        new Person{ FirstName = "John",
//            LastName = "Doe",
//            Email= ""},
//            new Person{ FirstName = "Pavel",
//            LastName = "Novák",
//            Email= ""},
//        ];