namespace AddressBookProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address book problem");
            AddressBook obj = new AddressBook();
            obj.FirstName = "Sachin";
            obj.LastName = "Dabhade";
            obj.Address = "shekta ";
            obj.City = "Bidkeen";
            obj.State = "Maharashtra";
            obj.Zip = 431105;
            obj.PhoneNumber = 8888948943;
            obj.Email = "dabhade904@gmail.com";
            Console.WriteLine("Name :"+obj.FirstName+ " "+obj.LastName+" Address "+obj.Address+" "+obj.City+" "+obj.State+" Pin code "+obj.Zip+" Contact "+obj.PhoneNumber+" "+obj.Email);
        }
    }
}

