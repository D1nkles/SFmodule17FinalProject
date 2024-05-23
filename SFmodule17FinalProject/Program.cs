namespace SFmodule17FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultAccount = new DefaultAccount() { Balance = 1250 };
            var defaultAccount2 = new DefaultAccount() { Balance = 420 };

            var salaryAccount = new SalaryAccount() { Balance = 500 };

            Calculator.CalculateInterest(defaultAccount);
            Console.WriteLine(defaultAccount.Interest);

            Calculator.CalculateInterest(defaultAccount2);
            Console.WriteLine(defaultAccount2.Interest);

            Calculator.CalculateInterest(salaryAccount);
            Console.WriteLine(salaryAccount.Interest);
        }
    }
}