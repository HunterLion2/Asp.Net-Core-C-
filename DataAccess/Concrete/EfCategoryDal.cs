using ConsoleApp.DataAccess.Abstract;
using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Concrete {
    public class EfCategoryDal: ICategoryRepository {

        public Category GetById(int id) {
            return new Category();
        }

        public void Update(Category entity) {

        }

        public void Create(Category entity) {
            
        }

        public void Delete(int id) {
            
        }

    }
}