namespace Exercicios;

public interface IProcessadorPagamento
{
    void ProcessarPagamento(decimal valor);
    void CancelarPagamento();
}
