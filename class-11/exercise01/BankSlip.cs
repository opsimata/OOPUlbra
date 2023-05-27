namespace exercise01
{
    public class BankSlip : IPayment
    {
        public void Pay(double value)
        {
            Console.WriteLine($"\nPagamento de R${value} realizado com cartão de crédito.");
        }
    }
}