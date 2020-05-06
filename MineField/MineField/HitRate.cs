using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySeven
{
    public class HitRate
    {
        protected internal static string Calculate(int hits, int tries)
        {
            double dblPercent; // Store win %

            // Percent of hits out of tries or total games
            // convert int to doubles
            dblPercent = (double)hits / (double)tries;

            // round, convert to string, display as %
            return dblPercent.ToString("P");
        }
    }
}
