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
            FavoriteFood("Uncle Artie", "sauage and peppers");

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
        }

    public static double WageCalculator(double HoursWorked, double HourlyWage)
        {
            double monthlyWage = HoursWorked * HourlyWage;
            Console.WriteLine("The monthly wages are $" + monthlyWage);
            return monthlyWage;
        }
    }
}
