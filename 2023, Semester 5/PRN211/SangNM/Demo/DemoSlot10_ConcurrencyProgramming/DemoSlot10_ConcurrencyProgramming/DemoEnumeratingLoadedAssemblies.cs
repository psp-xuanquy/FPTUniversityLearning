using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DemoSlot10_ConcurrencyProgramming
{
    class DemoEnumeratingLoadedAssemblies
    {
        static void Main(string[] args)
        {
            // Get access to the AppDomain for the current thread.
            AppDomain defaultAD = AppDomain.CurrentDomain;

            Assembly[] loadedAssemblies = defaultAD.GetAssemblies(); 
            Console.WriteLine($"***** Assemblies loaded in {defaultAD.FriendlyName} *****\n");
            foreach (Assembly a in loadedAssemblies)
            {
                Console.WriteLine($"Name, Version {a.GetName().Name} : {a.GetName().Version}");
            }
            Console.ReadLine();
        }
    }
}
