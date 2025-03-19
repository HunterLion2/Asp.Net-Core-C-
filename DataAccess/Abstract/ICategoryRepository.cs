using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Abstract {
    public interface ICategoryRepository
    {
        Category GetById(int id);

        void Update(Category entity);

        void Create(Category entity);

        void Delete(int id);
    }

}
