﻿using InstantCredit.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Service
{
    public class MarketForecaster : IMarketForecaster
    {
        public MarketResult GetMarketPrediction()
        {
            return new MarketResult
            {
                MarketCondition = MarketCondition.StableUp
            };
        }
    }

}
