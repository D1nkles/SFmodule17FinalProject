namespace SFmodule17FinalProject
{
    public interface IAccount
    {
        string Type { get; }
        double Balance { get; set; }
        double Interest { get; set; }
        void CalculateInterest();
    }
}
