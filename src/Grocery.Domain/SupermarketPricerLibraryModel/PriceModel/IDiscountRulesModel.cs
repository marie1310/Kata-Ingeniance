using System;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel
{
    public interface IDiscountRulesModel
    {
        ITotalPriceCalculationModel Create(Guid productId);
    }
}