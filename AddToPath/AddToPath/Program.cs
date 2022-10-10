using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currval = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            Environment.SetEnvironmentVariable("Path", currval + ";" + args.ToString(), EnvironmentVariableTarget.Machine);
        }
    }
}
