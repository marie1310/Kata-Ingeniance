namespace SupermarketPricerLibrary.SupermarketPricerLibraryModel.PriceModel
{
    public class PriceModel 
    {
        public decimal Value { get; }
        public PriceModel(decimal value) { Value = value; }

        public static PriceModel operator +(PriceModel firstProduct, PriceModel secondProduct) { return new PriceModel(firstProduct.Value + secondProduct.Value); }
        
        public static PriceModel operator -(PriceModel firstProduct, PriceModel secondProduct) { return new PriceModel(firstProduct.Value - secondProduct.Value); }

        public static PriceModel operator *(int firstProduct, PriceModel secondProduct) { return new PriceModel(firstProduct * secondProduct.Value); }

        public static implicit operator PriceModel(decimal value) { return new PriceModel(value); }

    }
}