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
    public class EditMailFunctions : CommonFunctions
    {
        public EditMailFunctions(Manager manager) : base(manager) //Изменение E-mail
        { }

        public void EditEmail() //Выбирает поле E-mail, и меняет, в данном случае просто вводит тот же E-mail
        {
            driver.FindElement(By.Name("p_email")).Clear();
            driver.FindElement(By.Name("p_email")).SendKeys("erasumus@mail.ru");
            driver.FindElement(By.CssSelector("input[type=\"button\"]")).Click();
        }

    }
}
