using System;

namespace Builder
{
    public class CCurrency
    {
        public ECurrencyId Id { get; }
        public int Value { get; }

        public CCurrency(ECurrencyId id, int value)
        {
            this.Id = id;
            this.Value = value;
        }
    }
}
