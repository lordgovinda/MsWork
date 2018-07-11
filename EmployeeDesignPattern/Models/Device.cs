using EmployeeDesignPattern.Interfaces;

namespace EmployeeDesignPattern.Models
{
    public abstract class Device : IDeviceType
    {
        public string DeviceName { get; set; }

        public string DeviceType { get; set; }

    }
}
