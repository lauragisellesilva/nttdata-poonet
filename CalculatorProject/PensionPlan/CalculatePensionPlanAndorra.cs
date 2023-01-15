using System;

namespace CalculatorProject.PensionPlan
{
    public class CalculatePensionPlanAndorra
    {
        public static float CalculatePercentageAndorra(float taxBase, float totalInvestedPensionPlan)
        {
            float porcentageDeducted = 0.0f;
            if (taxBase <= 24000)
                porcentageDeducted = 0;
            else if (taxBase > 24001 && taxBase < 40000)
                porcentageDeducted = totalInvestedPensionPlan * 0.05f;
            else if (taxBase >= 40000)
                porcentageDeducted = totalInvestedPensionPlan * 0.10f;
            else
                Console.WriteLine("Error: The tax base is zero or less than 0");

            return porcentageDeducted;
        }
    }
}
