﻿using System;

namespace I_Wrong
{
    public class ImpressoraMultifuncional : IImpressoraMultifuncional
    {
        public void Digitalizar(string conteudo)
        {
            Console.WriteLine($"Digitalizado: '{conteudo}'");
        }

        public void EnviarFax(string conteudo)
        {
            Console.WriteLine($"Fax Enviado: '{conteudo}'");
        }

        public void Imprimir(string conteudo)
        {
            Console.WriteLine($"Impresso: '{conteudo}'");
        }

        public void ImprimirDuplex(string conteudo)
        {
            Console.WriteLine($"Impresso Frente e Verso: '{conteudo}'");
        }
    }
}
