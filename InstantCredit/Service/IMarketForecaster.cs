using InstantCredit.Models;

namespace InstantCredit.Service
{
    public interface IMarketForecaster
    {
        MarketResult GetMarketPrediction();
    }
}