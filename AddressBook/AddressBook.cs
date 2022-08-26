using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        Dictionary<string, List<Person>> addressDictionary = new Dictionary<string, List<Person>>();
        public Dictionary<string, List<Person>> Createuser()
        {
            List<Person> personList = new List<Person>();
            string? next = string.Empty;
            bool anotheruser = true;
            try
            {
                Console.WriteLine("Enter the country you want to add address");
                var addressBook = Console.ReadLine();

                while (anotheruser)
                {
                    var personNewObj = new Person();
                    Console.WriteLine("Enter first name");
                    personNewObj.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    personNewObj.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    personNewObj.Address = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    personNewObj.City = Console.ReadLine();
                    Console.WriteLine("Enter State");
                    personNewObj.State = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    personNewObj.Email = Console.ReadLine();
                    Console.WriteLine("Enter  Zip Code");
                    personNewObj.Zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number ");
                    personNewObj.PhoneNumber = Console.ReadLine();
                    if (personList.Count == 0)
                    {
                        personList.Add(personNewObj);
                    }
                    else
                    {
                        personList = AddDistinctPersonInList(personList, personNewObj);
                    }
                    do
                    {
                        Console.WriteLine("Do you want to add again? press yes/no");
                        next = Console.ReadLine();
                    } while (next != "yes" && next != "no" && next != "Yes" && next != "No");
                    anotheruser = (next == "Yes" || next == "yes");
                }
                addressDictionary.Add(addressBook, personList);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
            return addressDictionary;
        }
        public List<Person> AddDistinctPersonInList(List<Person> list, Person person)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstName != person.FirstName)
                {
                    list.Add(person);
                }
            }
            var listOfPerson = list.GroupBy(x => x.FirstName).Select(x => x.First()).ToList();
            return listOfPerson;
        }
        public void Display()
        {
            if (addressDictionary.Count != 0)
            {
                foreach (KeyValuePair<string, List<Person>> kvp in addressDictionary)
                {
                    Console.WriteLine("Key = {0}", kvp.Key);
                    foreach (var person in kvp.Value)
                    {
                        Console.WriteLine("First Name : {0} , Last Name : {1} , Address : {2} , City : {3} , State : {4} , Zip : {5} , Phone Number : {6} ",
                        person.FirstName, person.LastName, person.Address, person.City, person.State, person.Zip, person.PhoneNumber);
                    }
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
                    foreach (KeyValuePair<string, List<Person>> kvp in addressDictionary)
                    {
                        foreach (var person in kvp.Value)
                        {
                            if (fName.Equals(person.FirstName))
                            {
                                Console.WriteLine("choose field you want to edit");
                                int input = Convert.ToInt32(Console.ReadLine());
                                switch (input)
                                {
                                    case 1:
                                        Console.WriteLine("Re-corect your First name");
                                        person.FirstName = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("Re-corect your last name");
                                        person.LastName = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.WriteLine("Re-corect your address");
                                        person.Address = Console.ReadLine();
                                        break;
                                    case 4:
                                        Console.WriteLine("Re-corect your City Name");
                                        person.City = Console.ReadLine();
                                        break;
                                    case 5:
                                        Console.WriteLine("Re-corect your State Name");
                                        person.State = Console.ReadLine();
                                        break;
                                    case 6:
                                        Console.WriteLine("Re-corect your Zip Code");
                                        person.Zip = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    case 7:
                                        Console.WriteLine("Re-corect your Phone Number");
                                        person.PhoneNumber = Console.ReadLine();
                                        break;
                                }
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
                if (addressDictionary.Count > 0)
                {
                    Console.WriteLine("Enter your first name");
                    string? fName = Console.ReadLine();
                    if (fName != null)
                    {
                        foreach (KeyValuePair<string, List<Person>> kvp in addressDictionary)
                        {
                            foreach (var person in kvp.Value)
                            {
                                if (fName.Equals(person.FirstName))
                                {
                                    addressDictionary.Remove(kvp.Key);
                                    Console.WriteLine("data removed successfully");
                                }
                                else
                                {
                                    Console.WriteLine("Data is not available");
                                }
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
                foreach (KeyValuePair<string, List<Person>> kvp in addressDictionary)
                {
                    Console.WriteLine("Name of Address Book : " + kvp.Key);
                    foreach (var persons in kvp.Value)
                    {
                        var search = addressDictionary.Where(p => persons.FirstName.Contains(person));
                        foreach (KeyValuePair<string, List<Person>> dict in search)
                        {
                            Console.WriteLine("Address Book Name " + dict.Key);
                            Console.WriteLine("First Name : {0} , Last Name : {1} , Address : {2} , City : {3} , State : {4} , Zip : {5} , Phone Number : {6} ",
                                persons.FirstName, persons.LastName, persons.Address, persons.City, persons.State, persons.Zip, persons.PhoneNumber);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter person name");
            }
        }

        public void SearchPersonBasedOnCityAndState()
        {
            Console.WriteLine("Enter city or state to search person");
            string? cityOrState = Console.ReadLine();
            int cnt = 0;
            if (cityOrState != null)
            {
                foreach (KeyValuePair<string, List<Person>> kvp in addressDictionary)
                {
                    Console.WriteLine("Name of Address Book : " + kvp.Key);
                    foreach (var personObj in kvp.Value)
                    {
                        if(personObj.City.Equals(cityOrState) || personObj.State.Equals(cityOrState))
                        {
                            Console.WriteLine("First Name : {0} , Last Name : {1} , Address : {2} , City : {3} , State : {4} , Zip : {5} , Phone Number : {6} ",
                                personObj.FirstName, personObj.LastName, personObj.Address, personObj.City, personObj.State, personObj.Zip, personObj.PhoneNumber);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter the city or state");
            }
        }
    }
}
