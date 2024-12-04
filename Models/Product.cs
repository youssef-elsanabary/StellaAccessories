using StellaAccessories.Enum;

namespace StellaAccessories.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MainCategory MainCategory { get; set; }
        public SubCategory SubCategory { get; set; }
        public int Price { get; set; }
        public int? Discount {  get; set; }
        public string Image {  get; set; }
        public int Count { get; set; }
    }
}
