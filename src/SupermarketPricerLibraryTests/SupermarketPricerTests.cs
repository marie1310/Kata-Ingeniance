using System;
using SupermarketPricerLibrary.SupermarketPricerLibraryModel.BasketModel;
using SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel;
using SupermarketPricerLibrary.SupermarketPricerLibraryModel.ProductModel;
using NSubstitute;
using Xunit;

namespace SupermarketPricerTests
{
    public class BasketTest
    {
        private readonly IBasketProductPriceModel BasketProductPrice;
        private readonly IDiscountRulesModel DiscountRules;

        public BasketTest()
        {
            BasketProductPrice = Substitute.For<IBasketProductPriceModel>();
            DiscountRules = new DiscountModel(BasketProductPrice);
        }

        [Fact]
        public void GetTotalPriceOfBasket()
        {
            var beanCan = new ProductModel(Guid.NewGuid(), "Bean Can", 2.50m);
            var waterBottle = new ProductModel(Guid.NewGuid(), "Water bottle", 1.50m);
            var pastaPack = new ProductModel(Guid.NewGuid(), "Pasta Pack", 3m);
            var basket = new BasketModel(Guid.NewGuid(), DiscountRules);

            basket.AddOrderItem(beanCan, 1);
            basket.AddOrderItem(waterBottle, 1);
            basket.AddOrderItem(pastaPack, 1);

            PriceModel expectedTotalPrice = 7m;

            Assert.Equal(expectedTotalPrice.Value, basket.GetTotalPrice().Value);
        }

    }
}
