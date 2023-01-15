using System;

namespace Program.PensionPlan
{
    public class Print
    {
        public static Person PrintQuestions()
        {
            string country = AskCountry();
            float taxBase = AskTaxeBase();
            float pensionPlanLegalPerson = AskIndividualContribution();
            float pensionPlanCompany = AskCompanyContribution();

            var person = new Person(taxBase, pensionPlanLegalPerson, pensionPlanCompany, country);
            return person;
        }

        public static string AskCountry()
        {
            string country = "";
            do
            {
                Console.WriteLine("What is your country?");
                country = Console.ReadLine();
            } while (country != "spain" && country != "andorra");

            return country;
        }

        public static float AskTaxeBase()
        {
            float taxbase = 0f;
            do
            {
                Console.WriteLine("What is your tax base?");
                taxbase = float.Parse(Console.ReadLine());
            } while (taxbase <= 0);
            return taxbase;
        }

        public static float AskIndividualContribution()
        {
            float pensionPlanLegalPerson = 0f;
            do
            {
                Console.WriteLine("What is your individual pension contribution?");
                pensionPlanLegalPerson = float.Parse(Console.ReadLine());
            } while (pensionPlanLegalPerson <= 0);

            return pensionPlanLegalPerson;
        }

        public static float AskCompanyContribution()
        {
            float pensionPlanCompany = 0f;
            do
            {
                Console.WriteLine("What is your company pension contribution?");
                pensionPlanCompany = float.Parse(Console.ReadLine());
            } while (pensionPlanCompany <= 0);

            return pensionPlanCompany;
        }

        public static void PrintPorcentageDeducted(float porcentageDeducted)
        {
            Console.WriteLine("The porcentage deducted is " + porcentageDeducted);
        }
    }
}
