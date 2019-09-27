using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutöö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Hello, " + firstName);
            
            int oldAreYou;
            Console.WriteLine("How old are you?");
            oldAreYou = Int32.Parse(Console.ReadLine());


            if (oldAreYou < 20)
            {
                Console.WriteLine("Sorry, but you don't belong to suitable range");
            }
            else if (oldAreYou > 60)
            {
                Console.WriteLine("Sorry, but you don't belong to suitable range");
            }

            else if (oldAreYou >= 20 || oldAreYou <= 60)


            {
                Console.WriteLine("Enter your height (meters): ");


                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your weight (kg): ");
                double weight = Convert.ToDouble(Console.ReadLine());

                double BMI = weight / (height * height);
                Console.WriteLine("Your BMI is: " + Math.Round(BMI, 2));

                if (BMI <= 16)
                    Console.WriteLine("You're severely underweight ");
                else if (BMI <= 18.5)
                    Console.WriteLine("You are underweight.");
                else if (BMI <= 25)
                    Console.WriteLine("You are at normal weight.");
                else if (BMI <= 30)
                    Console.WriteLine("You are overweight.");
                else if (BMI <= 35)
                    Console.WriteLine("You are moderately obese.");
                else if (BMI > 40.1)
                    Console.WriteLine("You are severely obese.");
            }
            

            Console.ReadLine();
            

            

            


        }
    }
}
