using ProjectDAL;
using ProjectModel;
using ProjectSQLData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities
{
    public class ProductEntities:BaseEntities
    {
        public ProductSQL productSQL { get; set; }
        public ProductEntities()
        {
            productSQL= new ProductSQL();
        }
        public List<ProductView> GetAllProductE()
        {
            return DataTableToList<ProductView>(productSQL.GetAllProductSQL());
        }
        public List<ProductView> GetProductE(int id)
        {
            return DataTableToList<ProductView>(productSQL.GetProductSQL(id));
        }
        public string InsertProductE(Product prod)
        {
            return productSQL.InsertProductSQL(prod);
        }
        public string UpdateProductE(int id, Product prod)
        {
            return productSQL.UpdateProductSQL(id, prod);
        }
        public string DeleteProductE(int id)
        {
            return productSQL.DeleteProductSQL(id);
        }
    }
}
