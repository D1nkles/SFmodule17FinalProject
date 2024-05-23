namespace SFmodule17FinalProject
{
    public class DefaultAccount : Account
    {
        public DefaultAccount(double Balance) 
        {
            _type = "Обычный";
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
                _interest = Balance * 0.4;

                if (Balance < 1000)
                    _interest -= Balance * 0.2;

                if (Balance >= 1000)
                    _interest -= Balance * 0.4;
                return _interest;
            }
        }
    }
}
