using System;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel
{
    public class DiscountModel : IDiscountRulesModel
    {
        private readonly IBasketProductPriceModel BasketProductPrice;

        public DiscountModel(IBasketProductPriceModel basketProductPrice)
        {
            BasketProductPrice = basketProductPrice;
        }

        public ITotalPriceCalculationModel Create(Guid productId)
        {
            return new TotalPriceCalculationModel();
        }
    }
}