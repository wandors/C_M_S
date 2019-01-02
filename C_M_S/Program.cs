using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_M_S
{
    class Program
    {
        static void Main(string[] args)
        {
            string cms = "CMS";
            Process[] proc = Process.GetProcesses();
            foreach (Process pr in proc)
            {
                if (pr.ProcessName.ToString() == cms)
                {
                    pr.Kill();
                }
            }
            try
            {
                string arh = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
                if (arh == "x64")
                {
                    string pathCMS = @"C:\Program Files\Partizan\Partizan CMS\CMS.exe";
                    Process.Start(pathCMS);
                }
                else
                {
                    string pathCMS = @"C:\Program Files (x86)\Partizan\Partizan CMS\CMS.exe";
                    Process.Start(pathCMS);
                }
            }
            catch { }
        }
        
    }
}
