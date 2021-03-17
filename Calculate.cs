using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Tracker
{
    /// <summary>
    /// Creates class object for utility of calculating and parsing stock data.
    /// </summary>
    class Calculate
    {
        /// <summary>
        /// Calculates if stock reversal trends down.
        /// </summary>
        /// <param name="cur"></param>
        /// <param name="prev"></param>
        /// <returns> bool </returns>
        public bool reversalDown(IAsset cur, IAsset prev)
        {
            if (((cur.getOpen() > prev.getHigh())) && ((cur.getClose() < prev.getLow())))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Calculates if stock reversal trends up.
        /// </summary>
        /// <param name="cur"></param>
        /// <param name="prev"></param>
        /// <returns> bool </returns>
        public bool reversalUp(IAsset cur, IAsset prev)
        {
            if (((cur.getOpen() < prev.getLow())) && ((cur.getClose() > prev.getHigh())))
            {
                return true;
            }

            return false;
        }
    }
}
