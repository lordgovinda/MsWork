using System;
using EmployeeDesignPattern;
using EmployeeDesignPattern.Enums;
using EmployeeDesignPattern.Models;

namespace TestAbstractDesignPattern
{
    public class Program
    {
     public static void Main(string[] args)
     {
         DellFactory df = new DellFactory();
         AbstractClientEndPoint emp = new AbstractClientEndPoint(df);
            Console.WriteLine("{0}", emp.GetDeviceEmployee(new EmployeeModel{Type = EmployeeType.Contract,Name = "Seshu",Position = EmployeePositionType.TeamManager}).DeviceName);
         Console.ReadKey();
     }
    }
}
