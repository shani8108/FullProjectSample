using ProjectDAL;
using ProjectModel;
using System.Data;

namespace ProjectSQLData
{
    public class ProductSQL: BaseSQL
    {
        public DataTable GetAllProductSQL()
        {
            string query = @"exec getAllProd";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);

            return table;
        }
        public DataTable GetProductSQL(int id)
        {
            string query = $"exec getProd {id}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);

            return table;
        }
        public string InsertProductSQL(Product prod)
        {
            string query = $"exec insertProd '{prod.Name}',{prod.Price},{prod.InStock},{prod.DepartmentId}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);
            return "Added Product Successfuly";
        }
        public string UpdateProductSQL(int id,Product prod)
        {
            string query = $"exec updateProd {id},'{prod.Name}',{prod.Price},{prod.InStock},{prod.DepartmentId}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);
            return "Updated Product Successfuly";
        }
        public string DeleteProductSQL(int id)
        {
            string query = $"exec deleteProd {id}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);
            return "Deleted Product Successfuly";
        }
    }
}