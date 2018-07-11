namespace EmployeeDesignPattern.Models
{
   public class Desktop:Device
    {
        public Desktop(string deviceName)
        {
            DeviceName = deviceName;
            DeviceType = Enums.DeviceType.Desktop.ToString() ;
        }
    }
}
