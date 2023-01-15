using CalculatorProject.PensionPlan;
using System;

namespace Program.PensionPlan
{
    public class CheckPensionPlanByCountry
    {
        public static float Calculate(Person person)
        {
            float totalInvestedPensionPlan = person.PensionPlanLegalPerson + person.PensionPlanCompany;
            float porcentageDeducted = 0f;

            if (person.Country.ToLower() == "spain")
                porcentageDeducted = CalculatePensionPlanSpain.CalculatePercentageSpain(person.TaxBase, totalInvestedPensionPlan);
            else if (person.Country.ToLower() == "andorra")
                porcentageDeducted = CalculatePensionPlanAndorra.CalculatePercentageAndorra(person.TaxBase, totalInvestedPensionPlan);
            else
                Console.WriteLine("Error: The country's name is wrong");

            return porcentageDeducted;
        }
    }
}
