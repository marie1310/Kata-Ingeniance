using System;
using SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.BasketModel
{
    public class BasketProductModel : IBasketProductModel
    {
        public Guid ProductId { get; }
        private readonly ITotalPriceCalculationModel TotalPrice;
        private readonly PriceModel.PriceModel ProductPrice;
        private int Number;

        public BasketProductModel(Guid id, Guid productId, PriceModel.PriceModel productPrice, ITotalPriceCalculationModel totalPrice, int number = 1)
        {
            ProductId = productId;
            ProductPrice = productPrice;
            TotalPrice = totalPrice;
            Number = number;
        }

        public void AddProductNumber(int number)
        {
            Number += number;
        }

        public int GetProductNumber()
        {
            return Number;
        }
        public PriceModel.PriceModel GetProductPrice()
        {
            return ProductPrice;
        }

        public PriceModel.PriceModel GetTotalPrice()
        {
            return TotalPrice.GetTotal(this);
        }

    }
}
