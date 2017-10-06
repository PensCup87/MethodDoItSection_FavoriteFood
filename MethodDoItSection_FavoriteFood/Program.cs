using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDoItSection_FavoriteFood
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name.");
            //string userName = Console.ReadLine().ToLower().Trim();

            //Console.WriteLine("Enter your favorite food.");
            //string userFood = Console.ReadLine().Trim().ToLower();

            //FavoriteFood(userName, userFood);

            //RetirementCalculator(36);

            //WageCalculator(40.0, 24.79);

            //Greetings("Earthling", "leader");

            //BattingAverage(234, 659);

            //BeingPolite("Hello", "Goodbye");

            //GreetingSpecificUser("Bobo");

            Console.WriteLine(SumIt(8.7, 7.1));

            Console.WriteLine(DoubleIt(7));

        }
        public static void FavoriteFood(string chef, string food)
        {
            Console.WriteLine(chef + "'s favorite dish is " + food);
        }
    public static void RetirementCalculator(int UserAge)
        {
            int retirementAge = 65 - UserAge;
            Console.WriteLine("The user will retire in " + retirementAge + " years.");
            return;

            //Teacher Answer
            //int retirementAge = Math.Max(0, 65 - UserAge)
            //if someone is over 65, the retirement age is negative, but with
            //Math.Max there would not be a negative number returned
            //Could Conditional Statements, but this was a 1 line fix
        }

    public static double WageCalculator(double HoursWorked, double HourlyWage)
        {
            double monthlyWage = HoursWorked * HourlyWage;
            Console.WriteLine("The monthly wages are $" + monthlyWage);
            return monthlyWage;
        }
    public static void Greetings(string name, string title)
        {
            Console.WriteLine("Greetings " + name + " take me to your " + title);
        }

    public static double BattingAverage(double hits, double atBats)
        {
            double average = hits / atBats;
            Console.WriteLine("Your batting average is " + average);
            return average;
        }


        //Additional Method Practice Problems
        public static void BeingPolite(string arriving, string leaving)
        {
            Console.WriteLine(arriving + " Program User thank you for joining us.");
            Console.WriteLine(leaving + " Program User seen you again.");
        }

        //Greeting a Specific User
        public static string GreetingSpecificUser(string specificUser)
        {
            Console.WriteLine("Enter your first name.");
            string userName = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Hello " + userName);
            Console.WriteLine("Goodbye " + userName);
            return specificUser;
        }
        //Creating an Addition Method with 2 numbers

        public static double SumIt(double digitOne, double digitTwo)
        {
            double SumIt = digitOne + digitTwo;
            return SumIt;
        }

        ////Performing ADDITION on an ARRAY
        ////string[] example = {"20", "10", "5", "2" };
        ////possible = Convert.ToInt32(example);???????????????HELP???????????
        //static void arrayExample();
        //int[] array = {20, 10, 5, 2 };
        //for(int i = 0; i < array.Length; i++)
        //    {
        //}

        public static int DoubleIt(int iDigit)
        {
            int doubleDigit = iDigit * 2;
            return doubleDigit;
        }










    }
}
