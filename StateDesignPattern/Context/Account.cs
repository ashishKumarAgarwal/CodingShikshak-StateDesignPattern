using StateDesignPattern.State;

namespace StateDesignPattern.Context
{
    internal class Account
    {
        private IState State { get; set; }

        private double Balance { get; set; }

        public Account()
        {
            State = new SilverState();
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            EvaluateState();
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
            EvaluateState();
        }

        public void GetCurrentBenefits()
        {
            State.GetBenefits();
        }

        private void EvaluateState()
        {
            if (Balance <= 5000)
                State = new SilverState();
            if (Balance > 5000 && Balance < 10000)
                State = new GoldState();
            if (Balance >= 10000)
                State = new PlatinumState();
        }
    }
}