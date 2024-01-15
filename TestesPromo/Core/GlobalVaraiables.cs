using OpenQA.Selenium;
using System;


namespace TestesPromo.Core
{
    public class GlobalVaraiables
    {
        //Define 'driver' como trigger para os WebDrivers
        public IWebDriver driver;

        //Define 'Ferchar navegador' ao Final como True
        public bool driverQuit = true;

        //Habilita /Desabilita modo Headless 
        public bool headLessTest = false;
    }
}
