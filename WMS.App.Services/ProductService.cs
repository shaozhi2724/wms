using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
        {
            using (var db = new WMSContext())
            {
                return db.Products.ToList();
            }
        }

        public Product GetProduct(int productID)
        {
            using(var db = new WMSContext())
            {
                return db.Products.Find(productID);
            }
        }

        public List<Product> SearchProducts(ProductSearchParameter parameter)
        {
            using (var db = new WMSContext())
            {
                var products = db.Products.AsQueryable();
                if (!string.IsNullOrWhiteSpace(parameter.ProductName))
                {
                    products = products.Where(p => p.ProductName.Contains(parameter.ProductName) || p.ProductSpell.Contains(parameter.ProductName));
                }
                if (!string.IsNullOrWhiteSpace(parameter.ProductCode))
                {
                    products = products.Where(p => p.ProductCode.Contains(parameter.ProductCode));
                }
                if (!string.IsNullOrWhiteSpace(parameter.ProductBarcode))
                {
                    products = products.Where(p => p.ProductBarCode.Contains(parameter.ProductBarcode));
                }

                if (!string.IsNullOrWhiteSpace(parameter.ProducerName))
                {
                    products = products.Where(p => p.ProducerName.Contains(parameter.ProducerName) || p.ProducerSpell.Contains(parameter.ProducerName));
                }

                if (!string.IsNullOrWhiteSpace(parameter.StockCondition))
                {
                    products = products.Where(p => p.StockCondition == parameter.StockCondition);
                }

                if (parameter.PackagingProportion > 0)
                {
                    var packaging = string.Concat("1:", parameter.PackagingProportion);
                    string packagingString = parameter.PackagingProportion.ToString();
                    products = products.Where(p => p.PackagingProportion == packaging || p.PackagingProportion == packagingString);
                }
                if (parameter.EntireCargoSpaceMaximum > 0)
                {
                    products = products.Where(p => p.EntireCargoSpaceMaximum == parameter.EntireCargoSpaceMaximum);
                }

                if (parameter.ScatteredCargoSpaceMinimum > 0)
                {
                    products = products.Where(p => p.ScatteredCargoSpaceMinimum == parameter.ScatteredCargoSpaceMinimum);
                }

                if (parameter.ScatteredCargoSpaceMaximum > 0)
                {
                    products = products.Where(p => p.ScatteredCargoSpaceMaximum == parameter.ScatteredCargoSpaceMaximum);
                }

                if (parameter.StockMinAmount > 0)
                {
                    products = products.Where(p => p.StockMinAmount == parameter.StockMinAmount);
                }
                products = products.Where(p => p.IsSupervise == parameter.IsSupervise);
                return products.ToList();
            }
        }

        public Product SaveProduct(Product entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.Products.Find(entity.ProductID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.Products.Add(entity);
                }

                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteProduct(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.Products.Find(entityId);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).State = EntityState.Deleted;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }
    }
}
