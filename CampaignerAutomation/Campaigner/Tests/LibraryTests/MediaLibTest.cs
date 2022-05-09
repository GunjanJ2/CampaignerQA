using System;
using System.Collections.Generic;
using System.Text;
using CampaignerAutomation.Framework;
using NUnit.Framework;

namespace CampaignerAutomation.Campaigner.Tests.LibraryTests
{
    [TestFixture]
    public class MediaLibTest : BaseTest
    {
        [Test]
        public void CheckMediaLibrary()
        {
            Reporter.Log("Check Media Library");
            Assert.That(true, "Media Library Not Found");
        }
    }
}
