using System;
using System.Collections.Generic;
using System.Linq;
using SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.BasketModel
{
    public class BasketModel
    {
        private readonly List<BasketProductModel> BasketProducts;
        private readonly IDiscountRulesModel DiscountRules;

        public BasketModel(Guid id, IDiscountRulesModel BasketDiscountRules)
        {
            DiscountRules = BasketDiscountRules;
            BasketProducts = new List<BasketProductModel>();
        }
        public void AddOrderItem(ProductModel.ProductModel product, int number = 1)
        {
            var checkProduct = BasketProducts.SingleOrDefault(o => o.ProductId == product.Id);

            if (checkProduct != null)
            {
                checkProduct.AddProductNumber(number);
            }
            else
            {
                var discountRule = DiscountRules.Create(product.Id);
                var basketProduct = new BasketProductModel(Guid.NewGuid(), product.Id, product.Price, discountRule, number);

                BasketProducts.Add(basketProduct);
            }
        }
        public PriceModel.PriceModel GetTotalPrice()
        {
            PriceModel.PriceModel totalPrice = 0;
            foreach (var basketProduct in BasketProducts)
            {
                totalPrice = totalPrice + basketProduct.GetTotalPrice();
            }
            return totalPrice;
        }
    }
}
