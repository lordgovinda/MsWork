using EmployeeDesignPattern.Enums;
using EmployeeDesignPattern.Interfaces;
using EmployeeDesignPattern.Models;

namespace EmployeeDesignPattern
{
    public class DellFactory : EmployeeFactoryPattern
    {
        protected override IDeviceType GetDeviceType(EmployeePositionType employeePosition)
        {
            var dell = new Dell();
            if (employeePosition == EmployeePositionType.TeamManager)
            {
                return dell.GetDeviceType("Dell", DeviceType.Laptop);
            }
            return dell.GetDeviceType("Dell", DeviceType.Desktop);
        }
    }
}
