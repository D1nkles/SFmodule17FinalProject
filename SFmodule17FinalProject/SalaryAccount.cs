using System.Security.Principal;

namespace SFmodule17FinalProject
{
    public class SalaryAccount : Account
    {
        public SalaryAccount(double Balance)
        {
            _type = "Зарплатный";
            this.Balance = Balance;
            _interest = Interest;
        }

        public override string Type
        {
            get
            {
                return _type;
            }

        }

        public override double Interest
        {
            get
            {
                _interest = Balance * 0.5;
                return _interest;
            }
        }
    }
}
