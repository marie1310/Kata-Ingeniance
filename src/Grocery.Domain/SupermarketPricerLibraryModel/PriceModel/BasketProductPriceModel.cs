using System;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel
{
    public class BasketProductPriceModel 
    {
        public BasketProductPriceModel(Guid id, Guid productId, int number, PriceModel price)
        {
            ProductId = productId;
            TotalNumber = number;
        }

        public Guid ProductId { get; }
        public PriceModel Price { get; }
        public int TotalNumber { get; }
    }
}