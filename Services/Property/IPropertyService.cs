using DataViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Property
{
   public interface IPropertyService
    {
        SuccessPropertyMessage DeletePropertyById(int id);
        SuccessPropertyMessage InsertProperty(PropertyModel data);
        PropertyListModal GetProperties(int userId, int skip, int take, string search = null);
        SuccessPropertyMessage GetPropertyById(int id);
        SuccessPropertyMessage UpdateProperty(PropertyModel data);

        SuccessDepartmentMessage DeleteDepartmentById(int id);
        SuccessDepartmentMessage InsertDepartment(DepartmentModel data);
        DepartmentListModal GetDepartments(int skip, int take, string search = null);
        DepartmentModel GetOwnerDepartment();
        DepartmentModel GetGmDepartment();
        SuccessDepartmentMessage GetDepartmentById(int id);
        SuccessDepartmentMessage UpdateDepartment(DepartmentModel data);

        SuccessRoleMessage GetRoleUserById(int id);
        List<DepartmentPositionModel> GetDepartmentsPosition(int departmentId);
        List<DepartmentsPositionShiftModel> GetDepartmentsPositionShift(int departmentId);
        List<DepartmentModel> GetDepartmentsByPropertyId(string propertyId);
        SuccessUserMessage DeleteUserFromOwnerList(int userId, int ownerId, string propertyIds);
    }
}
