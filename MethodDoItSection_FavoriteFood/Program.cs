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
            Console.WriteLine("Enter your name.");
            string userName = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Enter your favorite food.");
            string userFood = Console.ReadLine().Trim().ToLower();

            FavoriteFood(userName, userFood);

            RetirementCalculator(36);

            WageCalculator(40.0, 24.79);
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
    }
}
