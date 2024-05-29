using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Data;
using Nop.Plugin.Misc.NopstationTeamTest.Domain;

namespace Nop.Plugin.Misc.NopstationTeamTest.Services;
public interface IEmployeeService
{
   
    void Log (Employee employee);
}
