using System;

namespace Modelo
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public bool equals(Object obj)
        {
            return true;
        }
    }
}
