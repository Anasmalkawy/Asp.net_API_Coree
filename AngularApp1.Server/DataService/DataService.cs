using System.Collections.Generic;
using AngularApp1.Server.IDataService;
using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp1.Server.DataService
{

    public class DataService : AngularApp1.Server.IDataService.IDataService
    {
        private readonly MyDbContext _dbContext;
        public DataService(MyDbContext db)
        {
            _dbContext = db;
        }

        public List<Category> GetAllCategory()
        {
            var users = _dbContext.Categories.ToList();
            return users;
        }

        public Category GetCategory(int id)
        {
            var categories = _dbContext.Categories.SingleOrDefault(x => x.Id == id);
            return categories;
        }


        public Category GetCategoryByName(string name)
        {
            var categories = _dbContext.Categories.FirstOrDefault(x => x.Name == name);
            return categories;
        }

        public Category GetCategoryFirst()
        {
            var categories = _dbContext.Categories.First();
            return categories;
        }



        public List<Product> GetAllProducts()
        {
            var products = _dbContext.Products.ToList();
            return products;
        }

        public Product GetProductById(int id)
        {
            var product = _dbContext.Products.Find(id);
            return product;
        }

        public Product GetProductByName(string name)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Name == name);
            return product;
        }

        public Product GetFirstProduct()
        {
            var product = _dbContext.Products.First();
            return product;
        }

        public bool DeleteProduct(int id)
        {
            var user = _dbContext.Products.Find(id);
            if (user != null)
            {
                _dbContext.Products.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool deletecategories(int id)
        {
            var user = _dbContext.Users.Find(id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }



    }
}
