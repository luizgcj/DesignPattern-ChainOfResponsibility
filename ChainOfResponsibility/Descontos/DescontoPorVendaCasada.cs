using ChainOfResponsability.Entities;
using ChainOfResponsability.Interface;

namespace ChainOfResponsability.Descontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("LAPIS", orcamento) || Existe("CANETA", orcamento))
                return orcamento.Valor * 0.05;
            else
                return Proximo.Desconta(orcamento);
        }
       

        private bool Existe (string nomeItem, Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome == nomeItem)
                    return true;
            }
            return false;
        }
    }
}
