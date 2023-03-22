namespace class_02
{
    public class BankAccount
    {
        public double Balance { get; private set; }

        public int Number { get; private set; }

        public double DpstValue { get; set; }

        public double WthdrwValue { get; set; }

        public BankAccount(double balance, double dpstValue, double wthdrwValue)
        {
            this.Balance = 500;
            this.DpstValue = dpstValue;
            this.WthdrwValue = wthdrwValue;
            this.Number = 373253479;
        }

        public void Account(double balance)
        {
            this.Balance = balance;
        }

        public void Deposit(double dpstValue)
        {
            this.DpstValue = dpstValue;

            Balance = Balance + WthdrwValue;

        }
        public void Withdraw(double wthdrwValue)
        {
            this.WthdrwValue = wthdrwValue;

            Balance = Balance - WthdrwValue;

        }

    }
}