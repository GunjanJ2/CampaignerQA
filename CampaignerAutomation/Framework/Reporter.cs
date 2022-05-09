using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CampaignerAutomation.Framework
{
    public class Reporter
    {
        public static void Log(string msg)
        {
            
            TestContext.Progress.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff") + "] : " + msg);
            //TestContext.Out.WriteLine(msg);
        }
    }
}
