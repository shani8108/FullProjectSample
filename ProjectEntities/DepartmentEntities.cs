using ProjectModel;
using ProjectSQLData;
using System.Data;

namespace ProjectEntities
{
    public class DepartmentEntities
    {
        public static DataTable GetAllDepartmentE()
        {
            return DepartmentSQL.GetAllDepartmentSQL();
        }

        public static DataTable GetDepartmentE(int id)
        {
            return DepartmentSQL.GetDepartmentSQL(id);
        }
        public static string InsertDepartmentE(Department dep)
        {
            return DepartmentSQL.InsertDepartmentSQL(dep);
        }
        public static string UpdateDepartmentE(int id, Department dep)
        {
            return DepartmentSQL.UpdateDepartmentSQL(id, dep);

        }
        public static string DeleteDepartmentE(int id)
        {
            return DepartmentSQL.DeleteDepartmentSQL(id);
        }
    }
}