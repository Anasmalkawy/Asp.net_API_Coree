using AngularApp1.Server.Models;

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



    }
}
