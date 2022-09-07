namespace AddressBookDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            FetchAddressBookDb obj = new FetchAddressBookDb();
            obj.GetAllEmployee();
        }
    }
}