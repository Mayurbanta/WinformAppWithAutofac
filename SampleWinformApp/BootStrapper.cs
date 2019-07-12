using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

using Manager;
using Engine;
using Contract;
using System.Reflection;

namespace SampleWinformApp
{
    public static class BootStrapper
    {
        public static IContainer AutoFacContainer;

        public static void BuildContainer()
        {
            
            var builder = new ContainerBuilder();

            //builder.RegisterType<SalaryManager>().As<ISalaryManager>();

            //--------------
            Assembly assembly = Assembly.LoadFrom("Manager.dll");
            
            var results = (from type in assembly.GetTypes()
                           where typeof(IPlugIn).IsAssignableFrom(type)
                           select type).ToList();

            object objPlugin = Activator.CreateInstance(results[0]);
            var p = (IPlugIn)objPlugin;
            p.Register(builder);

            //--------------


            //Manager.PlugIn plugIn = new PlugIn();
            //plugIn.Register(builder);
            builder.RegisterType<SalaryEngine>().As<ISalaryEngine>();

            AutoFacContainer = builder.Build();
        }

        public static void TestBuildContainer()
        {

            var builder = new ContainerBuilder();

            builder.RegisterType<SalaryManager>().As<ISalaryManager>();
            builder.RegisterType<SalaryEngine>().As<ISalaryEngine>();

            AutoFacContainer = builder.Build();
        }


    }
}
