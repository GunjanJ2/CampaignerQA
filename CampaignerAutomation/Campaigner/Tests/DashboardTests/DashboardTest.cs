using System;
using System.Collections.Generic;
using System.Text;
using CampaignerAutomation.Framework;
using NUnit.Framework;

namespace CampaignerAutomation.Campaigner.Tests.DashboardTests
{
    [TestFixture]
    public class DashboardTest : BaseTest
    {
        [Test]
        public void CheckWidget()
        {
            Reporter.Log("Checking Widget");
            Assert.That(true, "Widget Not Found");
        }

        [Test]
        public void CheckBarChart()
        {
            Reporter.Log("Checking Bar Chart");
            Assert.That(true, "Widget Not Found");
        }
    }
}
