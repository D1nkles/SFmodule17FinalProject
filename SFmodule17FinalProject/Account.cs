namespace SFmodule17FinalProject
{
    public abstract class Account
    {
        // тип учетной записи
        private protected string _type;
        public virtual string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        private protected double _interest;
        public virtual double Interest{ get; }

    }
}
