using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student
    {
        //field
        public string? _name;

        //property
        public string Name 
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace.");
                }
                _name = value;
            }
        }

        public DateOnly DateOfBirht { get; set; }

        public int Age() =>
                DateTime.Now.Year - DateOfBirht.Year;
        


    }
}
