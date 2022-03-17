﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);

        IDataResult<List<Product>> GetAllByCategoryId(int id);

        IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetByProductId(int id);
    
    }
}
