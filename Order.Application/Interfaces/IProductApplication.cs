﻿using Order.Application.DataContract.Request.Product;
using Order.Application.DataContract.Response.Product;
using Order.Domain.Models;
using Order.Domain.Validations.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Application.Interfaces
{
    public interface IProductApplication
    {
        Task<Response> CreateAsync(CreateProductRequest product);
        Task<Response<List<ProductResponse>>> ListByFilterAsync(string productId = null, string description = null);
    }
}
