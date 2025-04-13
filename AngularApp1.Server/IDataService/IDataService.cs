using AngularApp1.Server.Models;
using AngularApp1.Server.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp1.Server.IDataService
{
    public interface IDataService
    {
        public List<Category> GetAllCategory();
        public Category GetCategory(int id);
        public Category GetCategoryByName(string name);
        public Category GetCategoryFirst();
        public bool deletecategories(int id);
        public List<Product> GetAllProducts();
        public Product GetProductById(int id);
        public Product GetProductByName(string name);
        public Product GetFirstProduct();
        public bool DeleteProduct(int id);
        public void AddCategory(CategoryDTO dto);
        public bool editcategoriesbyid(int id, CategoryDTO category);




    }
}
