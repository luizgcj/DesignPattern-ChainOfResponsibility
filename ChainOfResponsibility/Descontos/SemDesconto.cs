using ChainOfResponsability.Entities;
using ChainOfResponsability.Interface;

namespace ChainOfResponsability.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
       
    }
}
