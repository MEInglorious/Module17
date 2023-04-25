namespace FinalTask
{
    public class Account
    {
        public string Type { get; set; }

        public double Balance { get; set; }

        public double Interest { get; set; }
        public Account(string type, double balance)
        {
            Type = type;
            Balance = balance;
        }
        public void Calculate(ICalculator calculator)
        {
            calculator.CalculateInterest(this);
            Console.WriteLine($"Процентная ставка по вашему вкладу {this.Type} составляет {this.Interest} р/мес.");
        }
    }
}
