using System.Collections.Generic;
using FurnitureStore.Domain.Entities;

namespace FurnitureStore.Domain.Abstract
{
     public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int productID);
    }
}
