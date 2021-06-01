using System;

namespace Fsc
{
    class inter
    {
        public static string direcdeter()
        {
            Console.WriteLine("Enter \"same\" if the charges have the same sign and \"not\" if they don't");
            string charge = Console.ReadLine();
            switch (charge)
            {
                case "same":
                    charge = "repulsive";
                    break;
                case "not":
                    charge = "attractive";
                    break;
                default:
                    Console.WriteLine("Invalid Input, try again");
                    direcdeter();
                    break;
            }
            return charge;
        }
        public static double chargeprod()
        {
            char e;
            double q1 = 0, q2 = 0;
            Console.WriteLine("What are you using to measure the first charge? Type:");
            Console.WriteLine("e -> amount of charged particles");
            Console.WriteLine("C -> Coulumb");
            e = Console.ReadLine().ToUpper()[0];
            switch (e)
            {
                case 'E':
                    Console.WriteLine("Enter amount of charged particles");
                    q1 = 1.602 * Math.Pow(10, -16) * Convert.ToDouble(Console.ReadLine());
                    break;
                case 'C':
                    Console.WriteLine("Enter amount of miliCoulumbs");
                    q1 = Math.Pow(10, -3) * Convert.ToDouble(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid Input, Try Again");
                    chargeprod();
                    break;
            }
            Console.WriteLine("What are you using to measure the second charge? Type:");
            Console.WriteLine("e -> Amount of Charged Particles");
            Console.WriteLine("C -> Coulumb");
            e = Console.ReadLine().ToUpper()[0];
            switch (e)
            {
                case 'E':
                    Console.WriteLine("Enter amount of charged particles");
                    q2 = 1.602 * Math.Pow(10, -16) * Convert.ToDouble(Console.ReadLine());
                    break;
                case 'C':
                    Console.WriteLine("Enter amount of miliCoulumbs");
                    q2 = Math.Pow(10, -3) * Convert.ToDouble(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    chargeprod();
                    break;
            }
            return (q1 * q2);
        }
    }
    class elecmag
    {
        static void Main(string[] args)
        {
            bool end = false;
            //Calculate electrical force between two charges
            double q12 = 0, r, ef, k = 8.9875517923 * Math.Pow(10, 9);
            while (end == false)
            {
                //Determine direction of force based on if charges have the same 'signal'
                string direction = inter.direcdeter();
                //Get product of 2 charges
                q12 = inter.chargeprod();
                Console.WriteLine("Enter distance in mm");
                r = Math.Pow(10, -3) * Convert.ToDouble(Console.ReadLine());
                ef = k * (q12 / Math.Pow(r, 2));
                Console.WriteLine("The {1} eletrical force in Newtons is {0}", ef, direction);
                Console.WriteLine("To end program type \"end\"");
                end = ("end" == Console.ReadLine());
            }
        }
    }
}
