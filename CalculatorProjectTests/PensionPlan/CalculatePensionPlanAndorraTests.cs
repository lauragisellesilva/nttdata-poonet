using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorProject.PensionPlan.Tests
{
    [TestClass()]
    public class CalculatePensionPlanAndorraTests
    {
        [TestMethod()]
        public void CalculatePercentageAndorraTest()
        {
            Assert.IsTrue(CalculatePensionPlanAndorra.CalculatePercentageAndorra(24000f, 10000f) == 0);
            Assert.IsTrue(CalculatePensionPlanAndorra.CalculatePercentageAndorra(39999f, 10000f) == 500);
            Assert.IsTrue(CalculatePensionPlanAndorra.CalculatePercentageAndorra(40000f, 10000f) == 1000);
            Assert.IsTrue(CalculatePensionPlanAndorra.CalculatePercentageAndorra(0f, 0f) == 0);
        }
    }
}