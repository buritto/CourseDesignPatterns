using System.Text;

namespace Example_06.ChainOfResponsibility
{
    public interface IBanknote
    {
        CurrencyType Currency { get; }
        string Value { get; }
    }

    public class Banknote : IBanknote
    {
        public Banknote(CurrencyType currency, string value)
        {
            Currency = currency;
            Value = value;
        }


        public CurrencyType Currency { get; }
        public string Value { get; }
    }
}