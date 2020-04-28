namespace BankServices
{
    public class SuperCalculator : ICalculator
    {
        public int Add(int a1, int a2)
        {
            return a1 + a2 + 1;
        }
    }
}