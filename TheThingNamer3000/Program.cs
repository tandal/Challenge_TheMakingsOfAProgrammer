using System;

namespace TheThingNamer3000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            //Store the value of the thing the user entered
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            /*Store the users description*/
            string b = Console.ReadLine();
            string c = "Doom";
            string d = "3000";
            Console.WriteLine("The " + b/*users description*/ + " " + a/*thing user entered*/ + " of " + c/*of Doom*/ + " " + d/*3000*/ + "!");
        }
    }
}
