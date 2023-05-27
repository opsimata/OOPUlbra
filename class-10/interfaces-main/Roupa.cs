namespace interfaces_main
{
    public class Roupa : IItemEstoque // A interface obriga a implementar os metodos nela contidos na classe roupa
    {
        public int Tamanho { get; protected set; }
        public void Vender()
        {
            // Implementação específica para vender roupas
        }
        public void Devolver()
        {
            // Implementação específica para devolver roupas
        }
    }
}