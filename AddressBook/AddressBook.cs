using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        List<Person> persons = new List<Person>();
        public List<Person> createuser()
        {
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
                    Console.WriteLine("Do you want to add again? press y/n");
                    string next = Console.ReadLine();
                   anotheruser = (next == "Y" || next== "y");
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
            var listOfPerson = persons;
            foreach (var obj in listOfPerson)
            {
                Console.WriteLine(obj.FirstName + " " + obj.LastName + "  " + obj.Address + " " + obj.City + " " + obj.State + " " + obj.Zip + " " + obj.PhoneNumber + " " + obj.Email);
            }
        }

        public void EditPersonInfo()
        {
            Console.WriteLine("Enter your first name");
            string fName = Console.ReadLine();
            foreach (var obj in persons)
            {
                if (fName.Equals(obj.FirstName))
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("choose field you want to edit");
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Re-corect your last name");
                            obj.LastName = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Re-corect your address");
                            obj.Address = Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
