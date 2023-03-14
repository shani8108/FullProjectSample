using ProjectDAL;
using ProjectModel;
using System.Data;

namespace ProjectSQLData
{
    public class ProductSQL
    {
        public static DataTable GetAllProductSQL()
        {
            string query = @"exec getAllProd";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);

            return table;
        }
        public static DataTable GetProductSQL(int id)
        {
            string query = $"exec getProd {id}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);

            return table;
        }
        public static string InsertProductSQL(Product prod)
        {
            string query = $"exec insertProd '{prod.Name}',{prod.Price},{prod.InStock},{prod.DepartmentId}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);
            return "Added Product Successfuly";
        }
        public static string UpdateProductSQL(int id,Product prod)
        {
            string query = $"exec updateProd {id},'{prod.Name}',{prod.Price},{prod.InStock},{prod.DepartmentId}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);
            return "Updated Product Successfuly";
        }
        public static string DeleteProductSQL(int id)
        {
            string query = $"exec deleteProd {id}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);
            return "Deleted Product Successfuly";
        }
    }
}