using DataViewModel;
using Repository.PropertyDataRepository;
using System.Collections.Generic;

namespace Services.Property
{
    public class PropertyService : IPropertyService
    {
        IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        public SuccessPropertyMessage InsertProperty(PropertyModel data)
        {
            return _propertyRepository.InsertProperty(data);
        }

        public SuccessPropertyMessage UpdateProperty(PropertyModel data)
        {
            return _propertyRepository.UpdateProperty(data);
        }


        public SuccessPropertyMessage GetPropertyById(int id)
        {

            return _propertyRepository.GetPropertyById(id);
        }

        public SuccessPropertyMessage DeletePropertyById(int id)
        {
            return _propertyRepository.DeletePropertyById(id);
        }

        public PropertyListModal GetProperties(int userId, int skip, int take, string search = null)
        {
            return _propertyRepository.GetProperties(userId, skip, take, search);
        }

        public DepartmentModel GetOwnerDepartment()
        {
            return _propertyRepository.GetOwnerDepartment();
        }
        public DepartmentModel GetGmDepartment()
        {
            return _propertyRepository.GetGmDepartment();
        }


        public SuccessDepartmentMessage InsertDepartment(DepartmentModel data)
        {
            return _propertyRepository.InsertDepartment(data);
        }

        public SuccessDepartmentMessage UpdateDepartment(DepartmentModel data)
        {
            return _propertyRepository.UpdateDepartment(data);
        }


        public SuccessDepartmentMessage GetDepartmentById(int id)
        {
            return _propertyRepository.GetDepartmentById(id);
        }

        public SuccessDepartmentMessage DeleteDepartmentById(int id)
        {
            return _propertyRepository.DeleteDepartmentById(id);
        }

        public DepartmentListModal GetDepartments(int skip, int take, string search = null)
        {
            return _propertyRepository.GetDepartments(skip, take, search);
        }

        public SuccessRoleMessage GetRoleUserById(int id)
        {
            return _propertyRepository.GetRoleUserById(id);
        }

        public List<DepartmentPositionModel> GetDepartmentsPosition(int departmentId)
        {
            return _propertyRepository.GetDepartmentsPosition(departmentId);
        }

        public List<DepartmentsPositionShiftModel> GetDepartmentsPositionShift(int departmentId)
        {
            return _propertyRepository.GetDepartmentsPositionShift(departmentId);
        }
        public List<DepartmentModel> GetDepartmentsByPropertyId(string propertyId)
        {
            return _propertyRepository.GetDepartmentsByPropertyId(propertyId);
        }
        public SuccessUserMessage DeleteUserFromOwnerList(int userId, int ownerId, string propertyIds)
        {
            return _propertyRepository.DeleteUserFromOwnerList(userId, ownerId, propertyIds);
        }
    }
}
