namespace EcommerceApi.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProProduct();
    }
}