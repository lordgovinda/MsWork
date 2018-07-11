using EmployeeDesignPattern.Enums;
using EmployeeDesignPattern.Interfaces;
using EmployeeDesignPattern.Models;

namespace EmployeeDesignPattern
{
    public class AppleFactory:EmployeeFactoryPattern
    {
        protected override IDeviceType GetDeviceType(EmployeePositionType employeePosition)
        {
            var apple = new Apple();
            if (employeePosition == EmployeePositionType.TeamManager)
            {
                return apple.GetDeviceType("Apple", DeviceType.Laptop);
            }
            return apple.GetDeviceType("Apple", DeviceType.Desktop);
        }
    }
}
