using ChainOfResponsability.Entities;
using ChainOfResponsability.Helpers;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
        }
    }
}
