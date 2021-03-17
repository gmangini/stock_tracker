using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Tracker
{
    /// <summary>
    /// Implements IAsset interface. Creates a stock object with its attributes.
    /// </summary>
    class Stock : IAsset
    {

        private string date;
        private decimal open;
        private decimal high;
        private decimal low;
        private decimal close;

        /// <summary>
        /// Constructor with necessary data for stock. Price at: Open,
        /// High, Low, Close
        /// </summary>
        /// <param name="stockInfo"></param>
        public Stock(string[] stockInfo)
        {
            date = stockInfo[0];
            open = Convert.ToDecimal(stockInfo[1]);
            high = Convert.ToDecimal(stockInfo[2]);
            low = Convert.ToDecimal(stockInfo[3]);
            close = Convert.ToDecimal(stockInfo[4]);
        }

        /// <summary>
        /// Returns date for stock.
        /// </summary>
        /// <returns> string </returns>
        public string getDate()
        {
            return date;
        }

        /// <summary>
        /// Returns open price for stock.
        /// </summary>
        /// <returns> decimal </returns>
        public decimal getOpen()
        {
            return open;
        }

        /// <summary>
        /// returns high price for stock.
        /// </summary>
        /// <returns> decimal </returns>
        public decimal getHigh()
        {
            return high;
        }

        /// <summary>
        /// Returns low price for stock.
        /// </summary>
        /// <returns> low </returns>
        public decimal getLow()
        {
            return low;
        }

        /// <summary>
        /// Returns closing price for stock.
        /// </summary>
        /// <returns> decimal </returns>
        public decimal getClose()
        {
            return close;
        }

    }
}
