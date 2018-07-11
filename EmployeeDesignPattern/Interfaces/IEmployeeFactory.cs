using EmployeeDesignPattern.Models;

namespace EmployeeDesignPattern.Interfaces
{
    public interface IEmployeeFactory
    {
        IDeviceType GetDeviceByEmployeeType(EmployeeModel employeeModel);

        //IDeviceType GetDevice(EmployeePositionType employeePosition);
    }
}
