namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            int userInpute = Convert.ToInt32(Console.ReadLine());
            if (userInpute == 1)
            {
                AddressBook obj = new AddressBook();
                while (true)
                {
                    Console.WriteLine("Enter your choice: \n 1. create new person \n 2. Display Data \n 3. Edit person Data \n 4. Delete Person Data \n 5. Search Person \n 6. Enter city or state to search person \n 7.Enter city or state to search multiple person \n 0 .Exit");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            obj.Createuser();
                            break;
                        case 2:
                            obj.Display();
                            break;
                        case 3:
                            obj.EditPersonInfo();
                            break;
                        case 4:
                            obj.DeletePerson();
                            break;
                        case 5:
                            obj.SearchPerson();
                            break;
                        case 6:
                            obj.SearchPersonBasedOnCityAndState();
                            break;
                        case 7:
                            obj.GetNumberOfPerson();
                            break;
                        case 8:
                            obj.SortingByPersonName();
                            break;
                        case 9:
                            obj.SortingByPersonCityStateOrZip();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else if (userInpute == 2)
            {
                Console.WriteLine("Enter your choice: \n 1. Read Data \n 2. Write Data \n 3 Delete File \n 0 .Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        FileIoReadWrite.ReadData();
                        break;
                        break;
                    case 2:
                        FileIoReadWrite.WriteData();
                        break;
                    case 3:
                        FileIoReadWrite.FileDelete();
                        break;
                }
            }
            else if (userInpute == 3)
            {
                ReadAndWriteJson obj = new ReadAndWriteJson();
                string filePath = "C:\\Users\\kamlesh\\Desktop\\dotNet\\AddressBookProblem\\AddressBook\\PersonData.json";
                Contact data = obj.Read(filePath);
                // Console.WriteLine(data);
                for (int i = 0; i < data.typeOfPerson.Count; i++)
                {
                    Console.WriteLine(data.typeOfPerson[i].FirstName);
                    Console.WriteLine(data.typeOfPerson[i].LastName);
                    Console.WriteLine(data.typeOfPerson[i].Address);
                    Console.WriteLine(data.typeOfPerson[i].Address);
                    Console.WriteLine(data.typeOfPerson[i].City);
                    Console.WriteLine(data.typeOfPerson[i].State);
                    Console.WriteLine(data.typeOfPerson[i].Email);
                    Console.WriteLine(data.typeOfPerson[i].PhoneNumber);
                    Console.WriteLine(data.typeOfPerson[i].Zip);
                    Console.WriteLine("------------------------");
                }
            }
        }
    }
}

