using NUnit.Framework;
using System;
using OpenQA.Selenium.Chrome;


namespace TestesPromo.Core
{
    public class Begin : DSL
    {
        #region Pode Instaciar o navegador em Modo Headless ou não
        private void AbreNavegador()
        {
            var headlessMode = new ChromeOptions();
            headlessMode.AddArgument("window-size=1366x768");
            headlessMode.AddArgument("disk-cache-size=0");
            headlessMode.AddArgument("headless");

            var devMode = new ChromeOptions();
            devMode.AddArgument("start-maximized");
            devMode.AddArgument("disk-cache-size=0");

            if (headLessTest) { driver = new ChromeDriver(headlessMode); }
            else { driver = new ChromeDriver(devMode); driverQuit = false; }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }
        #endregion

        [SetUp]
        public void InicioTeste()
        {
            AbreNavegador();
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br/app/endereco/index.php");

        }

        [TearDown]
        public void FimTeste()
        {
            if(driverQuit) driver.Quit();
        }
    }
}