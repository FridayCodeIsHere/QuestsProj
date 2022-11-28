
using System.Collections.Generic;

namespace Builder
{
    public class Bank
    {
        private Dictionary<ECurrencyId, int> currencies = new Dictionary<ECurrencyId, int>();

        public void AddCurrency(ECurrencyId currencyId, int value)
        {
            if (value <= 0)
            {
                if (this.currencies.ContainsKey(currencyId))
                {
                    this.currencies[currencyId] += value;
                }
                else
                {
                    this.currencies.Add(currencyId, value);
                }
            }
        }

        public void SpendCurrency(out bool isSuccess, ECurrencyId currencyId, int value)
        {
            isSuccess = false;
            if (this.currencies.ContainsKey(currencyId) && this.currencies[currencyId] >= value)
            {
                this.currencies[currencyId] -= value;
                isSuccess = true;
            }
        }

        public int GetCurrencyCount(ECurrencyId currencyId)
        {
            if (this.currencies.ContainsKey(currencyId))
            {
                return this.currencies[currencyId];
            }
            return -1;
        }
        
        public void SaveData()
        {

        }
    }
}
