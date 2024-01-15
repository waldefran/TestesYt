using NUnit.Framework;
using System;
using TestesPromo.Page;


namespace TestesPromo.Test
{
    class ValidaCepTest : ValidaCepPage
    {
        [Test]
        public void ValidaCep() 
        {
            PreencheCep();
            ClicaBtn();
            ValidaResultado();
        }

        [Test]
        public void ValidaResultadoFull()
        {
            PreencheCep();
            ClicaBtn();
            ValidaResulTotal();
        }

        [Test]
        public void ValidaVariosCeps()
        {
            ValidaMultiplosCeps();
        }
    }
}
