using SupermarketPricerLibrary.SupermarketPricerLibraryModel.BasketModel;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel
{
    public class TotalPriceCalculationModel : ITotalPriceCalculationModel
    {
        public virtual PriceModel GetTotal(IBasketProductModel item)
        {
            return item.GetProductNumber() * item.GetProductPrice();
        }
    }
}