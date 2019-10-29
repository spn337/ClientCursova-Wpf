﻿using ServiceDll.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceDll.Interfaces
{
    public interface IProductService
    {
        //Task вертає асинхронну задачу, яка працює у вторинному потоці
        List<ProductModel> GetProducts();
        Task<List<ProductModel>> GetProductsAsync();

        Dictionary<string, string> Create(ProductAddModel product);
        Task<Dictionary<string, string>> CreateAsync(ProductAddModel product);
    }
}
