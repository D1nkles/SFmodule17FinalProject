using System.Security.Principal;

namespace SFmodule17FinalProject
{
    public class DefaultAccount : Account
    {
        public override void CalculateInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance >= 1000)
                Interest -= Balance * 0.4;
        }
    }
}
