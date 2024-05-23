namespace SFmodule17FinalProject
{
    public abstract class Account : IAccount
    {
        // тип учетной записи
        public string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public virtual void CalculateInterest() { }
    }
}
