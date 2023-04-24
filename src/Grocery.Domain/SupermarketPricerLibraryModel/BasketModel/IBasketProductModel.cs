using SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.BasketModel
{
    public interface IBasketProductModel
    {
        int GetProductNumber();
        PriceModel.PriceModel GetProductPrice();
    }
}
