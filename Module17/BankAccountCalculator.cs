namespace FinalTask
{
    public class BankAccountCalculator : ICalculator
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.04;

            if (account.Balance < 50000)
                account.Interest += account.Balance * 0.02;

            if (account.Balance < 1000)
                account.Interest += account.Balance * 0.04;
        }
    }
}
