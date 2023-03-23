namespace class_02
{
    public class BankAccount
    {
        public double Balance { get; private set; }

        public long Number { get; set; }

        public BankAccount(long number){
            this.Number = number;
        }

        public void Withdraw(double wthdrwValue)
        {
            Balance -= wthdrwValue;
        }
        public void Deposit(double dpstValue)
        {
            Balance += dpstValue;
        }
    }
}