namespace EmployeeDesignPattern.Models
{
    public class Laptop:Device
    {
        public Laptop(string deviceName)
        {
            DeviceName = deviceName;
            DeviceType = "Laptop";
        }
    }
}
