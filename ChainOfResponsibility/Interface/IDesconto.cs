using ChainOfResponsability.Entities;

namespace ChainOfResponsability.Interface
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
