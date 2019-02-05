using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.BDD.Helpers
{
    public class GetPath
    {
        public static string GetResourcePath(string file)
        {
            return $"{AppDomain.CurrentDomain.BaseDirectory}\\Resources\\{file}";
        }
    }
}
