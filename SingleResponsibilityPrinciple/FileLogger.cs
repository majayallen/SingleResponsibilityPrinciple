using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class FileLogger
    {
        public static void Log(string content)
        {
            System.IO.File.WriteAllText("D:\\errors.txt", content());
        }
    }
}
