using NUnit.Framework;
using System;
using System.IO;
using System.Security.Cryptography;
using TestesPromo.Core;

namespace TestesPromo.Page
{
    class ValidaCepPage : Begin
    {
        public void PreencheCep() 
        {
            EscreveTexto("//*[@id = 'endereco']","64077815");
        }

        public void ClicaBtn()
        {
            ClicaElemento("//*[@id = 'btn_pesquisar']");
        }

        public void ValidaResultado()
        {
            ValidaDados("//*[@id= 'resultado-DNEC']/tbody/tr/td[1]", "Rua Alexandre Gomes Chaves - de 1/2 ao fim");
        }

        public void ValidaResulTotal()
        {
            string[] dados =
            {
            "Rua Alexandre Gomes Chaves - de 1/2 ao fim"
            ,"Parque Ideal"
            ,"Teresina/PI"
            ,"64077-815"
            };

            for (int i = 0; i < dados.Length; i++)
            {
                ValidaDados("//*[@id= 'resultado-DNEC']/tbody/tr/td[" +(i+1)+ "]", dados[i]);
            }
        }

        public void ValidaMultiplosCeps()
        {
            string[] ceps = File.ReadAllLines(@"C:\QA\DataTestMoq\Ceps.txt");
            string[] ruas = File.ReadAllLines(@"C:\QA\DataTestMoq\Logradouros.txt");

            for (int i = 0;i < ceps.Length;i++)
            {
                EscreveTexto("//*[@id = 'endereco']", ceps[i]);
                ClicaElemento("//*[@id = 'btn_pesquisar']");
                ValidaDados("//*[@id= 'resultado-DNEC']/tbody/tr/td[1]", ruas[i]);

                ClicaElemento("//*[@id = 'btn_nbusca']");

            }
        }
    }
}
