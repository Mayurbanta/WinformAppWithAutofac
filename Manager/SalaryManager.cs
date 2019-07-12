using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Manager
{
    public class SalaryManager : ISalaryManager
    {
        private readonly ISalaryEngine _Engine;
        public SalaryManager(ISalaryEngine engine)
        {
            _Engine = engine;
        }

        public int GetMonthlySalary(int EmpId)
        {
            return _Engine.CalculateSalary(EmpId);
        }
    }
}
