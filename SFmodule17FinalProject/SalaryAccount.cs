using System.Security.Principal;

namespace SFmodule17FinalProject
{
    public class SalaryAccount : Account
    {
        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
