﻿using MyShop.Domain.Models;
using System.Linq;

namespace MyShop.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(ShoppingContext context) : base(context)
        {
        }
        // Implement  override for update method
        public override Product Update(Product entity)
        {
            var product = context.Products.Single(p => p.ProductId == entity.ProductId);

            product.Name = entity.Name;
            product.Price = entity.Price;

            return base.Update(product);
        }
    }
}
