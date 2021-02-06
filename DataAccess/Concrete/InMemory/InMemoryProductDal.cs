﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //Global
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { ProductId=1, CategoryId=1, ProductName="Bardak", UnitsInStock=15,  UnitPrice=15 },
                new Product { ProductId=2, CategoryId=1, ProductName="Kamera", UnitsInStock=500, UnitPrice=3 },
                new Product { ProductId=3, CategoryId=1, ProductName="Telefon",UnitsInStock=1500, UnitPrice=2 },
                new Product { ProductId=4, CategoryId=2, ProductName="Kavye", UnitsInStock=150, UnitPrice=65 },
                new Product { ProductId=5, CategoryId=2, ProductName="Fare", UnitsInStock=85, UnitPrice=1 }
            };
        }


        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query
            // SingleOrDefault Tek bir eleman bulmaya yarar (forEach yapar aslında, her birine takma isim veririz)
            
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);        

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün id sine sahip listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
