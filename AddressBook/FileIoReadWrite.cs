using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public static class FileIoReadWrite
    {
        public static string filePath = "C:\\Users\\kamlesh\\Desktop\\dotNet\\AddressBookProblem\\AddressBook\\data.txt";
        public static List<String> lines = new List<String>();
        public static void ReadData()
        {
            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath).ToList();
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public static void WriteData()
        {
            lines.Add("mahi, gaikwad, nandgaon, nandgoan, mh, harsh@gmail.com, 431133");
            File.WriteAllLines(filePath, lines);
            Console.ReadLine();
        }
        
        public static void FileDelete()
        {
            if (File.Exists(filePath))
            {
                 File.Delete(filePath);
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
