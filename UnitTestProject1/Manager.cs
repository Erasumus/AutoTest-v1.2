﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace MaslavyevAM
{
    public class Manager
    {
        public IWebDriver driver;
        public StringBuilder verificationErrors;
        public string baseURL;
        private AuthFunctions auth;
        private EditMailFunctions mail;
        private NavigationFunctions nav;
        
        public Manager()
        {
            driver = new ChromeDriver(@"C:\");
            baseURL = "http://kpfu.ru/";
            verificationErrors = new StringBuilder();

            auth = new AuthFunctions(this);
            mail = new EditMailFunctions(this);
            nav = new NavigationFunctions(this, baseURL);
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public AuthFunctions Auth
        {
            get
            {
                return auth;
            }
        }

        public EditMailFunctions Mail
        {
            get
            {
                return mail;
            }
        }

        public NavigationFunctions Nav
        {
            get
            {
                return nav;
            }
        }

        public void Stop()
        {
            driver.Quit();
        }
    }
}
