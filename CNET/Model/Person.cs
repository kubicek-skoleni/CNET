using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Model;

//[Index(nameof(Email),IsUnique = true)]
public class Person
{
    public int Id { get; set; }

    [MaxLength(50)]
    public string? FirstName { get; set; }

    [MaxLength(50)]
    public string? LastName { get; set; }

    [Required]
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Address? Address { get; set; }
    public List<Contract> Contracts { get; set; }

    public bool IsFile()
    {
        return File.Exists("dataset.txt");
    }

    override public string ToString()
    => $"{FirstName} {LastName} ({Email}) {Address}";
   
}
