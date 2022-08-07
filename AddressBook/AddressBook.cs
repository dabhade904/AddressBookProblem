using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        public List<Person> createser()
        {
            List<Person> persons = new List<Person>();
            bool anotheruser = true;
            try
            {
                while (anotheruser)
                {
                    var person = new Person();
                    Console.WriteLine("Enter first name");
                    person.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    person.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    person.Address = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    person.City = Console.ReadLine();
                    Console.WriteLine("Enter State");
                    person.State = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    person.Email = Console.ReadLine();
                    Console.WriteLine("Enter  Zip Code");
                    person.Zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number ");
                    person.PhoneNumber = long.Parse(s: Console.ReadLine());
                    persons.Add(person);
                    Console.WriteLine("Do you want to continue then press Y");
                    string next = Console.ReadLine();
                    
                   anotheruser = (next == "Y" || next== "Yes");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter valid input");
            }
            return persons;
        }
        public void Display()
        {
            var listOfPerson = createser();
            foreach (var obj in listOfPerson)
            {
                Console.WriteLine(obj.FirstName + " " + obj.LastName + "  " + obj.Address + " " + obj.City + " " + obj.State + " " + obj.Zip + " " + obj.PhoneNumber + " " + obj.Email);
            }
        }

    }
}
