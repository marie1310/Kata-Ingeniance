using System;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel
{    
    public class MultipleProductsModel
    {
        public Guid ProductId { get; }
        public int Number { get; }
        public MultipleProductsModel(Guid id, Guid productId, int number, PriceModel price)
        {
            ProductId = productId;
            Number = number;
        }

    }
}