﻿using System.Web.Mvc;
using FurnitureStore.Domain.Entities;

namespace FurnitureStore.WebUI.Infrastructure.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string sessionKey = "Cart";
        public object BindModel(ControllerContext controllerContext,
            ModelBindingContext bindingContext)
        {
            //Get the cart from the ssesion
            Cart cart = null;
            if (controllerContext.HttpContext.Session != null)
            {
                cart =
                    (Cart)controllerContext.HttpContext.Session[sessionKey];

            }
            //Create the cart if there wasn't one in the session data.
            if (cart == null)
            {
                cart = new Cart();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = cart;
                }
                
            }
            //return the cart 
            return cart;
        }
    }
}