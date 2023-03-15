namespace class_02
{
    public class BankAccount
    {
        public double Balance { get; set; }

        public int Number { get; private set; }

        public double DpstValue { get; set; }

        public double WthdrwValue { get; set; }

        public double Account(double balance)
        {
            this.Balance = balance;

            return Balance;
        }

        public double Deposit(double dpstValue)
        {
            this.DpstValue = dpstValue;

            Balance = Balance + WthdrwValue;

            return Balance;
        }
        public double Withdraw(double wthdrwValue)
        {
            this.WthdrwValue = wthdrwValue;

            Balance = Balance - WthdrwValue;

            return Balance;
        }

    }
}