using EmployeeDesignPattern.Enums;
using EmployeeDesignPattern.Interfaces;

namespace EmployeeDesignPattern.Models
{
    public class Dell
    {
        public IDeviceType GetDeviceType(string deviceName, DeviceType deviceType)
        {
            if (deviceType == DeviceType.Laptop)
            {
                return new Laptop(deviceName);
            }
            return new Desktop(deviceName);
        }
    }
}
