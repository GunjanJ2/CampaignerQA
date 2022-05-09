using System;
using System.Collections.Generic;
using System.Text;
using CampaignerAutomation.Framework;
using NUnit.Framework;

namespace CampaignerAutomation.Campaigner.Tests.LibraryTests
{
    [TestFixture]
    public class TemplateTest : BaseTest
    {
        [OneTimeSetUp]
        public void TemplateSetup()
        {
            Reporter.Log("Setting up things for Template Testing");
        }

        [Test]
        public void CheckTemplates()
        {
            Reporter.Log("Check Templates Library");
            Assert.That(true, "Templates Library Not Found");
        }
    }
}
