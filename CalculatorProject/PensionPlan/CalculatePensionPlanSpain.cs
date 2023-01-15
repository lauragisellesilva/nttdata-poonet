using System;

namespace CalculatorProject.PensionPlan
{
    public class CalculatePensionPlanSpain
    {
        public static float CalculatePercentageSpain(float taxBase, float totalInvestedPensionPlan)
        {
            float porcentageDeducted = 0.0f;
            if (taxBase > 0 && taxBase < 12450)
                porcentageDeducted = totalInvestedPensionPlan * 0.19f;
            else if (taxBase > 12450 && taxBase < 20200)
                porcentageDeducted = totalInvestedPensionPlan * 0.24f;
            else if (taxBase > 20200 && taxBase < 35200)
                porcentageDeducted = totalInvestedPensionPlan * 0.30f;
            else if (taxBase > 35200 && taxBase < 60000)
                porcentageDeducted = totalInvestedPensionPlan * 0.37f;
            else if (taxBase > 60000 && taxBase < 350000)
                porcentageDeducted = totalInvestedPensionPlan * 0.45f;
            else if (taxBase >= 350000)
                porcentageDeducted = totalInvestedPensionPlan * 0.47f;
            else
                Console.WriteLine("Error: The tax base is zero or less than 0");

            return porcentageDeducted;
        }
    }
}
