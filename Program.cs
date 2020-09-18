using System;
using System.Diagnostics;

namespace ESLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = System.IO.Directory.GetCurrentDirectory();
            Environment.SetEnvironmentVariable("HOME", dir);
            Console.WriteLine($"Setting HOME environment varible to <{Environment.GetEnvironmentVariable("HOME")}>...");
            var processName = "emultationstation.exe";
            Process process = new Process();
            process.StartInfo.FileName = "emulationstation.exe";
            process.StartInfo.UseShellExecute = true;
            try
            {
                Console.WriteLine($"Starting <{processName}>...");
                process.Start();
                Console.WriteLine($"Waiting for <{processName}> to exit...");
                process.WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
