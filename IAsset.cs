using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Tracker
{
    /// <summary>
    /// Provide certain methods for any asset. 
    /// Crypto, Stocks, etc..
    /// </summary>
    interface IAsset
    {
        public string getDate();

        public decimal getOpen();

        public decimal getHigh();

        public decimal getLow();

        public decimal getClose();
    }
}
