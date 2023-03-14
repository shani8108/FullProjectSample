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
    public class ProductEntities
    {
        public static DataTable GetAllProductE()
        {
            return ProductSQL.GetAllProductSQL();
        }
        public static DataTable GetProductE(int id)
        {
            return ProductSQL.GetProductSQL(id);
        }
        public static string InsertProductE(Product prod)
        {
            return ProductSQL.InsertProductSQL(prod);
        }
        public static string UpdateProductE(int id, Product prod)
        {
            return ProductSQL.UpdateProductSQL(id, prod);
        }
        public static string DeleteProductE(int id)
        {
            return ProductSQL.DeleteProductSQL(id);
        }
    }
}
