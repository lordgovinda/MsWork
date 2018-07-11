using System.Collections.Generic;
using System.Linq;
using EmployeeDesignPattern.Enums;
using EmployeeDesignPattern.Interfaces;

namespace EmployeeDesignPattern
{
    using System;
    using EmployeeDesignPattern.Models;

    public abstract class EmployeeFactoryPattern : IEmployeeFactory
    {
        private readonly Dictionary<string, IDeviceType> _factoryList = new Dictionary<string, IDeviceType>();

        private readonly object _lock = new object();
        public IDeviceType GetDeviceByEmployeeType(EmployeeModel employeeModel)
        {
            return GetDeviceTypeInternal(employeeModel);
        }

        private IDeviceType GetDeviceTypeInternal(EmployeeModel employeeModel)
        {
            EmployeeFactoryPattern priavteEmployeeFactoryPattern;
            lock (_lock)
            {
                if (!_factoryList.ContainsKey(employeeModel.Type + "-" + employeeModel.Position))
                {
                    if (employeeModel.Type == EmployeeType.FullTime)
                    {
                        priavteEmployeeFactoryPattern = new AppleFactory();

                    }
                    else
                    {
                         priavteEmployeeFactoryPattern = new DellFactory();
                    }

                    _factoryList[employeeModel.Type + "-" + employeeModel.Position] = priavteEmployeeFactoryPattern.GetDeviceType(employeeModel.Position); 
                }
            }
            return _factoryList[employeeModel.Type + "-" + employeeModel.Position];
        }
        protected abstract IDeviceType GetDeviceType(EmployeePositionType employeePosition);
    }
}
