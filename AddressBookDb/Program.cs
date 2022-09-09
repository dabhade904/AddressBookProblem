namespace AddressBookDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            FetchAddressBookDb fetchAddressBookDb = new FetchAddressBookDb();
            AddressDataModel addressDataModel = new AddressDataModel();
            while (true)
            {
                Console.WriteLine("Enter your choice");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        fetchAddressBookDb.GetAllEmployee();
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name");
                        addressDataModel.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        addressDataModel.LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address ");
                        addressDataModel.Address = Console.ReadLine();
                        Console.WriteLine("Enter City");
                        addressDataModel.City = Console.ReadLine();
                        Console.WriteLine("Enter State");
                        addressDataModel.State = Console.ReadLine();
                        Console.WriteLine("Enter Zip ");
                        addressDataModel.Zip = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Phone Number");
                        addressDataModel.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email ID");
                        addressDataModel.Email = Console.ReadLine();
                        Console.WriteLine("Enter Type Of Person ");
                        addressDataModel.TypeOf = Console.ReadLine();
                        fetchAddressBookDb.AddDataToTable(addressDataModel);
                        break;
                }
            }  
        }
    }
}