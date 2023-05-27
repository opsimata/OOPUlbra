namespace interfaces_main
{
    public class Loja
    {
        private List<IItemEstoque> _itensEmEstoque;

        private IItemEstoque item;

        public Loja()
        {
            item = new Roupa();
            item = new Calcado();
        }

        public void AdicionarItem(IItemEstoque item)
        {
            _itensEmEstoque.Add(item);
        }
        public void VenderItem(int index)
        {
            _itensEmEstoque[index].Vender();
            _itensEmEstoque.RemoveAt(index);
        }
    }
}