namespace Banking.Model
{
    public class AccountBudget : IProfileCalculate
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
