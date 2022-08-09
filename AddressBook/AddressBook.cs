using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        Dictionary<string, Person> addresses = new Dictionary<string, Person>();
        List<Person> persons = new List<Person>();
        public Dictionary<string, Person> createuser()
        {

            bool anotheruser = true;
            try
            {
                while (anotheruser)
                {
                    var person = new Person();
                    Console.WriteLine("Enter book name");
                    //addresses.Add(person.BookName, person);
                    person.BookName = Console.ReadLine();
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
                    person.PhoneNumber = long.Parse(Console.ReadLine());
                    //persons.Add(person);
                    addresses.Add(person.BookName, person);
                    Console.WriteLine("Do you want to add again? press y/n");
                    string next = Console.ReadLine();
                    anotheruser = (next == "Y" || next == "y");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
            return addresses;
        }
        public void Display()
        {
            foreach (KeyValuePair<string, Person> dict in addresses)
            {
                Console.WriteLine("Address Book Name " + dict.Key);
                foreach (var kvp in addresses.Values)
                {
                    Console.WriteLine("First Name: " + kvp.FirstName);
                    Console.WriteLine("Last Name: " + kvp.LastName);
                    Console.WriteLine("Address : " + kvp.Address);
                    Console.WriteLine("City : " + kvp.City);
                    Console.WriteLine("State : " + kvp.State);
                    Console.WriteLine("Zip : " + kvp.Zip);
                    Console.WriteLine("Phone Number: " + kvp.PhoneNumber);
                }

            }
        }
        public void EditPersonInfo()
        {
            try
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
                                Console.WriteLine("Re-corect your First name");
                                obj.FirstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Re-corect your last name");
                                obj.LastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Re-corect your address");
                                obj.Address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Re-corect your City Name");
                                obj.City = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Re-corect your State Name");
                                obj.State = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Re-corect your Zip Code");
                                obj.Zip = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 7:
                                Console.WriteLine("Re-corect your Phone Number");
                                obj.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
        }
        public void DeletePerson()
        {
            try
            {
                Console.WriteLine("Enter your first name");
                string fName = Console.ReadLine();
                if (persons.Count == 0)
                {
                    for (int i = persons.Count - 1; i >= 0; i--)
                    {
                        persons.Remove(persons[i]);
                        Console.WriteLine("data removed successfully");
                    }
                    Console.WriteLine("Data is not available");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
        }
    }
}
