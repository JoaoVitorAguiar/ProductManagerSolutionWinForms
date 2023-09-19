using ProductManager.Data;
using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Repositories;

internal class ProductRepository : IProductRepository
{
    private DataContext _dataContext;

    public ProductRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }


    public IEnumerable<Product> GetAll()
    {
        return _dataContext.Products.ToList();
    }

    public Product GetById(int Id)
    {
        return _dataContext.Products.FirstOrDefault(p => p.Id == Id);
    }


    public bool Save(Product product)
    {
        try
        {
            _dataContext.Products.Add(product);
            if (_dataContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public bool Update(Product product)
    {
        try
        {
            _dataContext.Products.Update(product);
            if (_dataContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool Delete(Product product)
    {
        try
        {
            _dataContext.Products.Remove(product);
            if (_dataContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

   
}
