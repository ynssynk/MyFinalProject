﻿using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product> {new Product {ProductName = "Tablo"}, new Product {ProductName = "Su"}};

        }

        public void Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }
    }
}