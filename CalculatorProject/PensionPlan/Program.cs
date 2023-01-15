using Program.PensionPlan;
using System;
using System.Net.NetworkInformation;

namespace CalculatorProject.PensionPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UP and runnign");

            var person = Print.PrintQuestions();

            float porcentageDeducted = CheckPensionPlanByCountry.Calculate(person);

            Print.PrintPorcentageDeducted(porcentageDeducted);
        }
    }
}