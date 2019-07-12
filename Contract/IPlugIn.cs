using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Contract
{
    public interface IPlugIn
    {
        void Register(ContainerBuilder containerBuilder);

    }
}
