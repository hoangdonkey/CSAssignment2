using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public static class ExA1
    {
        private static String name;
        private static int birthYear;
        private static int Age;
        private static int from2010;
        static ExA1()
        {
        }

        public static void run()
        {

            System.Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            System.Console.WriteLine("Enter year of birth: ");
            birthYear = int.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;
            Age = int.Parse(now.ToString("yyyy")) - birthYear;

            from2010 = 2010 - birthYear;

            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Birth year: " + birthYear);
            System.Console.WriteLine("Age: " + Age);
            System.Console.WriteLine("Age at 2010: " + from2010);
        }

    }
}
