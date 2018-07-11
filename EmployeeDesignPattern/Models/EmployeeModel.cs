using EmployeeDesignPattern.Enums;

namespace EmployeeDesignPattern.Models
{
    public class EmployeeModel
    {
        public string Name { get; set; }

        public EmployeeType Type { get; set; }

        public EmployeePositionType Position { get; set; }
    }
}
