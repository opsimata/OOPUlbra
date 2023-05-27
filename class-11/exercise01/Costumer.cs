namespace exercise01
{
    public class Costumer
    {
        private IPayment paymentMethod; //Agregação, o cliente possui um pagamento
                                        //Caso seja necessário mais de um pagamento deve ser declarado em forma de lista
        public Costumer(IPayment paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public void Buy(double value)
        {
            paymentMethod.Pay(value);
        }
    }
}