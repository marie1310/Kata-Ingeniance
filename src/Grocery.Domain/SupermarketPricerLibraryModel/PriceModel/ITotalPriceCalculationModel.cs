using SupermarketPricerLibrary.SupermarketPricerLibraryModel.BasketModel;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel
{
    public interface ITotalPriceCalculationModel
    {
        PriceModel GetTotal(IBasketProductModel item);
    }
}