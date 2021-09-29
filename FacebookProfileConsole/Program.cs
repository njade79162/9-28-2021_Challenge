using _9_28_2021_Challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookProfileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookProfile facebookProfile = new FacebookProfile("Jade", "Neff", new DateTime(2003, 09, 17), "None");

            string fullName = facebookProfile.getFullName();
            Console.WriteLine(fullName);

            Console.ReadKey();

            string profile = facebookProfile.getProfile();
            Console.WriteLine(profile);

            Console.ReadKey();
        }
    }
}
