using ConsoleApp.DataAccess.Abstract;
using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Concrete {
    public class EfProductDal : IProductRepository {

        public Product GetById(int id) {
            return new Product();
        }

        public void Update(Product entity) {

        }

        public void Create(Product entity) {
            
        }

        public void Delete(int id) {
            
        }

        public Product[] GetProductsByCategory(int id) {
            return new Product[3];
        }

    }
}