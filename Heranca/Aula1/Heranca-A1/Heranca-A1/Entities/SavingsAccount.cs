namespace Heranca_A1.Entities
{
    sealed class SavingsAccount : Account // "sealed" n permite q a classe seja herdada 
    {
        public double InterestRate { get; set; }
        
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public sealed override void Withdraw(double amount) // Essa operãção não pode ser sobrescrita novamente em outra subclasse 
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
