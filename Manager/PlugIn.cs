using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Contract;

namespace Manager
{
    public class PlugIn: IPlugIn
    {

        public List<string> ReferencedAssemblies()
        {
            return new List<string>
            {
                "Manager"
            };
        }

        public void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<SalaryManager>().As<ISalaryManager>();
        }
    }
}
