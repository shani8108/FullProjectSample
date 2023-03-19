using ProjectDAL;
using ProjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSQLData
{
    public class DepartmentSQL: BaseSQL
    {
        public DataTable GetAllDepartmentSQL()
        {
            string query = @"exec getAllDep";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);

            return table;
        }

        public DataTable GetDepartmentSQL(int id)
        {
            string query = $"exec getDep {id}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);

            return table;
        }
        public string InsertDepartmentSQL(Department dep)
        {
            string query = $"exec insertDep '{dep.Name}','{dep.Description}'";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);
            return "Added Department Successfuly";
        }
        public string UpdateDepartmentSQL(int id,Department dep)
        {
            string query = $"exec updateDep {id},'{dep.Name}','{dep.Description}')";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);
            return "Updated Department Successfuly";

        }
        public string DeleteDepartmentSQL(int id)
        {
            string query = $"exec deleteDep {id}";
            DataTable table = new DataTable();
            SqlQuery.RunCommand(query, table.Load);
            return "Deleted Department Successfuly";
        }
    }
}
