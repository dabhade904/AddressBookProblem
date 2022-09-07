using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        public List<TypeOfPerson> typeOfPerson;
        
    }
    public class TypeOfPerson
    {
        public string? FirstName;
        public string? LastName;
        public string? Address;
        public string? City;
        public string? State;
        public string? Email;
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber;
        public int? Zip;
    }
}
