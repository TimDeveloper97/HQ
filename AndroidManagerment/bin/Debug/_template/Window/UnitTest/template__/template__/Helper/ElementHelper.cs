using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace template__
{
    public static class ElementHelper
    {
        private static int _move = 10;
        private static int _heightMenu = 25;
        private static int _loop = 3;
        public static WindowsElement FindElementWithScroll(
            this WindowsDriver<WindowsElement> session,
            string ScrollAccessibilityId, By by)
        {
            WindowsElement element = null;
            var MouseY = 0;

            //move mouse to scroll
            var scroll = session.FindElementByAccessibilityId(ScrollAccessibilityId);
            if (scroll == null) return null;

            MouseY = scroll.Location.Y;
            Actions actions = new Actions(session);
            actions.MoveToElement(scroll);
            actions.MoveByOffset((scroll.Size.Width / 2) - 8, ((scroll.Size.Height / 2) - 5));
            actions.Perform();

            //loop find element
            int y = - _move;
            actions = new Actions(session);
            actions.Click();

            while (y < scroll.Size.Height - _heightMenu)
            {
                //action
                for (int i = 0; i < _loop; i++)
                {
                    actions.Perform();
                    y += _move;
                }

                //find element
                element = session.FindElement(by);
                if (element != null && element.Location.Y < y && element.Displayed)
                {
                    break;
                }
            }

            actions.Release();
            return element;
        }

        public static WindowsElement FindElementWithScroll(
            this WindowsDriver<WindowsElement> session,
            string ScrollAccessibilityId, String accesibilityID)
        {
            WindowsElement element = null;
            var MouseY = 0;

            //move mouse to scroll
            var scroll = session.FindElementByAccessibilityId(ScrollAccessibilityId);
            if (scroll == null) return null;

            MouseY = scroll.Location.Y;
            Actions actions = new Actions(session);
            actions.MoveToElement(scroll);
            actions.MoveByOffset((scroll.Size.Width / 2) - 8, ((scroll.Size.Height / 2) - 5));
            actions.Perform();

            //loop find element
            int y = -_move;
            actions = new Actions(session);
            actions.Click();

            while (y < scroll.Size.Height - _heightMenu)
            {
                //action
                for (int i = 0; i < _loop; i++)
                {
                    actions.Perform();
                    y += _move;
                }

                //find element
                try
                {
                    element = session.FindElementByAccessibilityId(accesibilityID);
                    if (element != null && element.Location.Y < y && element.Displayed)
                    {
                        break;
                    }
                }
                catch (Exception)
                { 
                }
            }

            actions.Release();
            return element;
        }
    }
}
