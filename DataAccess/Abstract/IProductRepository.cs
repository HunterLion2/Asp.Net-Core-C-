using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Abstract {

    public interface IProductRepository {
        Product GetById(int id);

        void Update(Product entity);

        void Create(Product entity);

        void Delete(int id);

        Product[] GetProductsByCategory(int id);
    }        
}
