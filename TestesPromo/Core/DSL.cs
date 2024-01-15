using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Xml.Linq;

// Divida em 3,
// ,Interação   - Iterage com elementos Web
// ,Atribuição  - Retorna valor e armazena em variável
// ,Manipulação - Manipulação Auxilia as demais função, como limpa campo, espera elemento aparecer
namespace TestesPromo.Core
{
    public class DSL : GlobalVaraiables
    {
        #region Funções de Manipulação

        public static void Wait(int time) => Thread.Sleep(time); 

        public void ClearData(string element) => driver.FindElement(By.XPath(element)).Clear();

        public void ClickOut() => driver.FindElement(By.XPath("//html")).Click();

        public void WaitElement(string element,int seconds =90)
        { 
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until((d) => { return d.FindElements(By.XPath(element)); });
        }

        public void WaitElementGone(string element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            wait.Until(d => d.FindElements(By.XPath(element)).Count ==0);
        }

        public bool ValidaElementoExistente(string xPath)
        {
            try
            { driver.FindElement(By.XPath(xPath)); return true; }
            catch (NoSuchElementException){ return false; }
        }

        #endregion

        #region Funções de Interação 
        public void EscreveTexto(string xpath, string value) 
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void ClicaElemento(string element)
        {
            driver.FindElement(By.XPath(element)).Click();
        }

        public void ValidaDados(string xpath, string value)
        {
            Assert.That( driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));

        }
        #endregion

        #region Funções de Atribuição
        #endregion
    }
}
