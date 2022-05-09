using System;
using System.Collections.Generic;
using System.Text;
using CampaignerAutomation.Framework;
using NUnit.Framework;

[SetUpFixture]
public class Execution
{
    [OneTimeSetUp]
    public void BeforeAll()
    {
        Reporter.Log("Before Test Execution..");

    }

    [OneTimeTearDown]
    public void AfterAll()
    {
        Reporter.Log("Completed Test Execution...");

    }
}

namespace CampaignerAutomation.Campaigner.Tests
{
    [TestFixture]
    public class TestClass
    {
        [OneTimeSetUp]
        public void BeforeClass()
        {
            TestContext.Progress.WriteLine("#####################################");
            Reporter.Log("Now starting execution from TestClass ["+ TestContext.CurrentContext.Test.Name + "]");
        }

        [OneTimeTearDown]
        public void AfterAll()
        {
            Reporter.Log("Completed all the Tests from TestClass ["+ TestContext.CurrentContext.Test.Name + "]");
            TestContext.Progress.WriteLine("#####################################");
        }
    }

    [TestFixture]
    public class BaseTest : TestClass
    {
        [SetUp]
        public void BeforeMethod()
        {
            TestContext.Progress.WriteLine("*******************************************");
            Reporter.Log("Now starting to execute Test [" + TestContext.CurrentContext.Test.MethodName + "]");

        }

        [TearDown]
        public void AfterMethod()
        {
            Reporter.Log("Completed the Test [" + TestContext.CurrentContext.Test.MethodName + "]");
            TestContext.Progress.WriteLine("*******************************************");
        }
    }
    
}
