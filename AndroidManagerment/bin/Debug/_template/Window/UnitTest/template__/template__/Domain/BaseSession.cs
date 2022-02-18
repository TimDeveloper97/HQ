using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace template__
{
    public class BaseSession : BaseConstant
    {

        protected static LogHelper Log;
        protected static WindowsDriver<WindowsElement> Session;
        protected static Actions Actions;

        protected static void Init(string url, string id, TestContext context)
        {
            if (Session == null)
            {
                Close();

                //check url
                if (url == null)
                    url = WindowsApplicationDriverUrl;

                //check log create
                if (Log == null)
                    Log = new LogHelper();

                //check winappdriver
                if (!DriverExecute.IsProcessRunning(NameWinAppDriver))
                    DriverExecute.RunProcess(PathWinAppDriver);

                AppiumOptions appCapabilities = new AppiumOptions();
                appCapabilities.AddAdditionalCapability("app", id);
                Session = new WindowsDriver<WindowsElement>(new Uri(url), appCapabilities);
                Assert.IsNotNull(Session);
                Assert.IsNotNull(Session.SessionId);

                // time to init session
                Session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                var currentWindowHandle = Session.CurrentWindowHandle;

                // Wait for 5 seconds or however long it is needed for the right window to appear/for the splash screen to be dismissed
                Thread.Sleep(TimeSpan.FromSeconds(5));

                // Return all window handles associated with this process/application.
                // At this point hopefully you have one to pick from. Otherwise you can
                // simply iterate through them to identify the one you want.
                var allWindowHandles = Session.WindowHandles;

                // Assuming you only have only one window entry in allWindowHandles and it is in fact the correct one,
                // switch the session to that window as follows. You can repeat this logic with any top window with the same
                // process id (any entry of allWindowHandles)
                Session.SwitchTo().Window(allWindowHandles[0]);

                //loading homepage
                Thread.Sleep(TimeSpan.FromSeconds(10));

                //create actions
                if (Actions == null)
                    Actions = new Actions(Session);
            }
        }

        protected static void Init(string id, TestContext context)
        {
            Init(null, id, context);
        }

        protected static void Init(string id)
        {
            Init(null, id, null);
        }

        protected static void Close()
        {
            //write log file
            if (Log != null)
                Log.GetLogs();

            // quit
            if (Session != null)
            {
                Session.Quit();
                Session = null;
            }

        }
    }
}