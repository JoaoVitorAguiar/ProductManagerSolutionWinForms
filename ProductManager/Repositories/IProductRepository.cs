using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Repositories;

internal interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product GetById(int Id);
    bool Save(Product product);
    bool Update(Product product);
    bool Delete(Product product);

}
