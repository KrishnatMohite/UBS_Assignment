using System;
using Humanizer;

namespace UBS_TransformService.Services
{
    public class CurrencyTransform : ICurrencyTransform
    {
        public string Humanize(int ammount)
        {
            return ammount.ToWords();
        }

        public string Humanize(double ammount)
        {
            throw new NotImplementedException();
        }
    }
}
