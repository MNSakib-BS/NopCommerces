using System;
using Nop.Data;
using Nop.Plugin.Misc.NopstationTeamTest.Domain;

namespace Nop.Plugin.Misc.NopstationTeamTest.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public virtual void Log(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            _employeeRepository.Insert(employee);
        }
    }
}
