// Definindo a interface IItemEstoque
public interface IItemEstoque
{
    void Vender();
    void Devolver();
}

// Implementando a interface em uma classe
public class Roupa : IItemEstoque
{
    public void Vender()
    {
        // Implementação específica para vender roupas
    }

    public void Devolver()
    {
        // Implementação específica para devolver roupas
    }
}

// Usando a classe Roupa com a interface IItemEstoque
public class Loja
{
    private List<IItemEstoque> _itensEmEstoque;

    public void AdicionarItem(Roupa item); //problema de acoplamento aqui
}