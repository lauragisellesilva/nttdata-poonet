using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorProject.PensionPlan.Tests
{
    [TestClass()]
    public class CalculatePensionPlanSpainTests
    {
        [TestMethod()]
        public void CalculatePercentageSpainTest()
        {
            Assert.IsTrue(CalculatePensionPlanSpain.CalculatePercentageSpain(12449f, 10000f) == 1900.0f);
            Assert.IsTrue(CalculatePensionPlanSpain.CalculatePercentageSpain(20199f, 10000f) == 2400.0f);
            Assert.IsTrue(CalculatePensionPlanSpain.CalculatePercentageSpain(35199f, 10000f) == 3000.0f);
            Assert.IsTrue(CalculatePensionPlanSpain.CalculatePercentageSpain(59999f, 10000f) == 3700.0f);
            Assert.IsTrue(CalculatePensionPlanSpain.CalculatePercentageSpain(349999f, 10000f) == 4500.0f);
            Assert.IsTrue(CalculatePensionPlanSpain.CalculatePercentageSpain(350000f, 10000f) == 4700.0f);
            Assert.IsTrue(CalculatePensionPlanSpain.CalculatePercentageSpain(0f, 0f) == 0.0f);
        }
    }
}