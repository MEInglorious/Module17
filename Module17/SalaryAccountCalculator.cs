using System;

namespace FinalTask
{
    class SalaryAccountCalculator : ICalculator
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.05;
        }
    }
}
