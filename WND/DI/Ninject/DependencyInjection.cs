using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WND.DI.Ninject
{
    public static class DependencyInjection<T>
    {
        public static T GetDependency()
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            T dependency = kernel.Get<T>();
            return dependency;
        }
    }
}
