using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Sieve
{
    public class Sieve
    {
        private Func<int, bool> _decisionFunction;

        public Sieve(Func<int, bool> decisionFunction) => _decisionFunction = decisionFunction;

        public bool IsGood(int number)
        {
            return _decisionFunction(number);
        }
    }
}
