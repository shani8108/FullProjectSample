using ProjectModel;
using ProjectSQLData;
using System.Data;

namespace ProjectEntities
{
    public class DepartmentEntities:BaseEntities
    {
        public DepartmentSQL departmentSQL{ get; set; }
        public DepartmentEntities()
        {
            departmentSQL = new DepartmentSQL();
        }
        public  List<Department> GetAllDepartmentE()
        {
            return DataTableToList<Department>(departmentSQL.GetAllDepartmentSQL());
        }

        public List<Department> GetDepartmentE(int id)
        {
            return DataTableToList<Department>(departmentSQL.GetDepartmentSQL(id));
        }
        public string InsertDepartmentE(Department dep)
        {
            return departmentSQL.InsertDepartmentSQL(dep);
        }
        public string UpdateDepartmentE(int id, Department dep)
        {
            return departmentSQL.UpdateDepartmentSQL(id, dep);

        }
        public string DeleteDepartmentE(int id)
        {
            return departmentSQL.DeleteDepartmentSQL(id);
        }
    }
}