using System;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel
{
    public interface IBasketProductPriceModel
    {
        BasketProductPriceModel GetByProductId(Guid productId);
    }
}