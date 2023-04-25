using System;

namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var salaryAccount = new Account("\'Зарплатный\'", 50000);
            salaryAccount.Calculate(new SalaryAccountCalculator());
            var bankAccount = new Account("\'Депозитный\'", 900);
            bankAccount.Calculate(new BankAccountCalculator());
        }
    }
}
