using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Abstract {

    public interface IProductRepository: IRepository<Product> {
        Product[] GetProductsByCategory(int id);
        // Ekstra bir şey eklemek istersek bu şekilde içerisine yazılabilir.

        // Buraya da ekstra değerleri yazmaya gerek yoktur çünkü
        // IRepository<Product> ile hangi değerleri istediğimizi ana yere belirtmiş olduk.
    }        
}
