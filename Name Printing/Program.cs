using System;

namespace Name_Printing
{
    class Program
    {
    

        static void Main(string[] args)
        {
            String firstName;
            String secondName;

            firstName= Console.ReadLine();
            secondName = Console.ReadLine();
            String myName= MyName(firstName,secondName);
            Console.WriteLine(myName);

            Console.ReadKey();
        }

        static String MyName(String fName, String sName)
        {
            return fName+" "+sName;
        }
    }
}
