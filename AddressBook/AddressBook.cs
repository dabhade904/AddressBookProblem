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
        public Dictionary<string, Person> createuser()
        {
            string? next = string.Empty;
            bool anotheruser = true;
            try
            {
                while (anotheruser)
                {
                    var person = new Person();
                    Console.WriteLine("Enter book name");
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
                    person.PhoneNumber =Console.ReadLine();
                    addresses.Add(person.FirstName, person);
                    do
                    {
                        Console.WriteLine("Do you want to add again? press yes/no");
                        next = Console.ReadLine();
                    } while (next != "yes" && next != "no" && next != "Yes" && next != "No");
                    anotheruser = (next == "Yes" || next == "yes");
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
            if (addresses.Count != 0)
            {
                foreach (KeyValuePair<string, Person> dict in addresses)
                {
                    Console.WriteLine("Address Book Name " + dict.Key);
                    Person person = dict.Value;
                    Console.WriteLine("First Name : {0} , Last Name : {1} , Address : {2} , City : {3} , State : {4} , Zip : {5} , Phone Number : {6} ",
                        person.FirstName, person.LastName, person.Address, person.City, person.State, person.Zip, person.PhoneNumber);
                }
            }
            else
            {
                Console.WriteLine("Dictionary is empty");
            }

        }
        public void EditPersonInfo()
        {
            try
            {
                Console.WriteLine("Enter your first name");
                string? fName = Console.ReadLine();
                if (fName != null)
                {
                    foreach (KeyValuePair<string, Person> obj in addresses)
                    {
                        if (fName.Equals(obj.Value.FirstName))
                        {
                            Console.WriteLine("choose field you want to edit");
                            int input = Convert.ToInt32(Console.ReadLine());
                            switch (input)
                            {
                                case 1:
                                    Console.WriteLine("Re-corect your First name");
                                    obj.Value.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Re-corect your last name");
                                    obj.Value.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Re-corect your address");
                                    obj.Value.Address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Re-corect your City Name");
                                    obj.Value.City = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Re-corect your State Name");
                                    obj.Value.State = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Re-corect your Zip Code");
                                    obj.Value.Zip = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 7:
                                    Console.WriteLine("Re-corect your Phone Number");
                                    obj.Value.PhoneNumber =Console.ReadLine();
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter Person name");
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
                if (addresses.Count > 0)
                {
                    Console.WriteLine("Enter your first name");
                    string? fName = Console.ReadLine();
                    if (fName != null)
                    {
                        foreach (KeyValuePair<string, Person> obj in addresses)
                        {
                            if (fName.Equals(obj.Key))
                            {
                                addresses.Remove(obj.Key);
                                Console.WriteLine("data removed successfully");
                            }
                            else
                            {
                                Console.WriteLine("Data is not available");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter any name");
                    }
                }
                else
                {
                    Console.WriteLine("Dictionary is empty");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
        }

        public void SearchPerson()
        {
            Console.WriteLine("Enter person you want to search");
            string? person = Console.ReadLine();
            if (person != null)
            {
                var search = addresses.Where(p => p.Value.FirstName.Contains(person));
                foreach (KeyValuePair<string, Person> dict in search)
                {
                    Console.WriteLine("Address Book Name " + dict.Key);
                    Person personResult = dict.Value;
                    Console.WriteLine("First Name : {0} , Last Name : {1} , Address : {2} , City : {3} , State : {4} , Zip : {5} , Phone Number : {6} ",
                        personResult.FirstName, personResult.LastName, personResult.Address, personResult.City, personResult.State, personResult.Zip, personResult.PhoneNumber);
                }
            }
            else
            {
                Console.WriteLine("Please enter person name");
            }
        }
    }
}
