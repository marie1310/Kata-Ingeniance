using System;

namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.ProductModel
{
    public class ProductModel
    {
        public Guid Id = Guid.NewGuid();
        public string Name { get; private set; }
        public PriceModel.PriceModel Price { get; private set; }


        public ProductModel(Guid id, string name, PriceModel.PriceModel price)
        {
            Name = name;
            Price = price;
        }
    }
}
