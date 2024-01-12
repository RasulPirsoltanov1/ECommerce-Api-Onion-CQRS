using E_Commerce_Api.Application.DTO_s;

namespace E_Commerce_Api.Application.Features.Products.Command.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public BrandDto Brand { get; set; }
    }
}
