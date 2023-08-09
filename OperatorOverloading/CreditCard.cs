namespace OperatorOverloading
{
    public class CreditCard
    {
        private readonly string cvc;
        public int SumOfMoney { get; set; }
        public CreditCard(string cvc)
        {
            this.cvc = cvc;
        }
        public string CVC
        {
            get { return cvc; }
        }

        public static int operator +(CreditCard card, int value)
        {
            return card.SumOfMoney + value;
        }
        public static int operator -(CreditCard card, int value)
        {
            return card.SumOfMoney - value;
        }
        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.SumOfMoney > card2.SumOfMoney;
        }
        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.SumOfMoney < card2.SumOfMoney;
        }
        public static bool operator ==(CreditCard card, string inputCvc)
        {
            return Object.Equals(inputCvc, card.CVC);
            //if (inputCvc == card.CVC)
            //    return true;
            //return false;
        }
        public static bool operator !=(CreditCard card, string inputCvc)
        {
            return !Object.Equals(inputCvc, card.CVC);
            //if (inputCvc != card.CVC)
            //    return true;
            //return false;
        }

        public static implicit operator string(CreditCard card)
        {
            return card.CVC;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard objectType)
                return SumOfMoney == objectType.SumOfMoney;

            return false;
        }
    }
}
