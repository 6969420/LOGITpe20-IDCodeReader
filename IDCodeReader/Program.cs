using System;
using System.Data.SqlTypes;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your ID code");
            string usersID = Console.ReadLine();
            if(Validate(usersID))
            {
                Console.WriteLine("Welcome");
                HelloUser(usersID)
            }else
            {
                Console.WriteLine("wrong format. Try again");
            }
        }

        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"wrong format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static void HelloUser(string idCOde)
        {
            int firstNum = Int32.Parse(idCOde[0].ToString());
            if(firstNum == 1 || firstNum == 3 || firstNum == 5 )
            {
                Console.WriteLine("Hello, sir");
            }else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, madam");
            }
        }
    }
}
