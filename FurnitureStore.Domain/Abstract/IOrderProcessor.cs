using FurnitureStore.Domain.Entities;

namespace FurnitureStore.Domain.Abstract
{
    public  interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}
