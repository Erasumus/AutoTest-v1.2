using System;
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
    public class AuthFunctions : CommonFunctions
    {
        public AuthFunctions(Manager manager) : base(manager)
        { }

        public void Login(Account user) //Вводим аккаунт.
        {
            driver.FindElement(By.LinkText("Вход")).Click();
            FillField("p_login", user.Login); 
            FillField("p_pass", user.Password); 
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
        private void FillField(string field, string value) //Необходимые HTML field, которые вводится значение аккаунта и пароля.
        {
            driver.FindElement(By.Name(field)).Clear(); 
            driver.FindElement(By.Name(field)).SendKeys(value); 
        }

        public void Exit() //Выход.
        {
            driver.FindElement(By.LinkText("Выход")).Click();
        }

    }
}
