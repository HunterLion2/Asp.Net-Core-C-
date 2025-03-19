using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Abstract {
    public interface ICategoryRepository: IRepository<Category>
    {
        // Category GetById(int id);

        // void Update(Category entity);

        // void Create(Category entity);

        // void Delete(int id);

        // Bu şekilde yazmamıza gerek kalmaz eğer jenerik türleri kullanırsak.
        // Yani o da "<>" oluyor. 
    }

}
