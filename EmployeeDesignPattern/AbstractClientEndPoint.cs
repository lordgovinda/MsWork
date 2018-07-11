using System;
using EmployeeDesignPattern.Interfaces;
using EmployeeDesignPattern.Models;

namespace EmployeeDesignPattern
{
    public class AbstractClientEndPoint
    {
        public IEmployeeFactory EmployeeFactory { get; set; }
        public AbstractClientEndPoint(IEmployeeFactory _employeeFactory)
        {
            EmployeeFactory = _employeeFactory;
        }
        public IDeviceType GetDeviceEmployee(EmployeeModel employeeModel)
        {
            return EmployeeFactory.GetDeviceByEmployeeType(employeeModel);
        }


    }
}
