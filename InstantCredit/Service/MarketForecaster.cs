using InstantCredit.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Service
{
    public class MarketForecaster
    {
        public MarketResult GetMarketPrediction()
        {
            return new MarketResult
            {
                MarketCondition = Models.MarketCondition.StableUp
            };
        }
    }

    public class MarketResult
    {
        public MarketCondition MarketCondition { get; set; }
    }
}
