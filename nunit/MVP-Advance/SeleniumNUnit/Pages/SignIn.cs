﻿using OpenQA.Selenium;
using SeleniumNUnit.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumNUnit.Global.GlobalDefinitions;

namespace SeleniumNUnit.Pages
{
    internal class SignIn
    {
        #region Initialize Web Elements
        //Finding the Sign Link
        private IWebElement SignIntab => driver.FindElement(By.XPath("//a[contains(text(),'Sign')]"));

        // Finding the Email Field
        private IWebElement Email => driver.FindElement(By.Name("email"));

        //Finding the Password Field
        private IWebElement Password => driver.FindElement(By.Name("password"));

        //Finding the Login Button
        private IWebElement LoginBtn => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
        #endregion

        public void LoginSteps()
        {
            //Populate excel data
            ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            //Click on Signin button
            SignIntab.Click();

            //Enter email
            Email.SendKeys(ExcelLib.ReadData(2, "Username"));

            //Enter password
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));

            //Click Login button
            LoginBtn.Click();
            wait(3);
        }
    }
}
