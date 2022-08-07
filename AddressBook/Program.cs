namespace AddressBook
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            AddressBook obj = new AddressBook();
            
            while (true)
            {
                Console.WriteLine("Enter number: \n 1. create new person \n 2. Display info \n 3. Edit person info \n 4. Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        obj.createuser();
                        break;
                    case 2:
                        obj.Display();
                        break;
                    case 3:
                        obj.EditPersonInfo();
                    break;
                }
            }     
        }
    }
}

