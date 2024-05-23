namespace SFmodule17FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultAccount = new DefaultAccount(100);
            var salaryAccount = new SalaryAccount(500);

            Console.WriteLine(defaultAccount.Interest + " " + defaultAccount.Type);
            Console.WriteLine(salaryAccount.Type + " " + salaryAccount.Interest);
        }
    }
}