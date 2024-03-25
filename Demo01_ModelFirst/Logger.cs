using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_ModelFirst
{
    public class Logger
    {
        private static readonly string logFilePath = @"C:\Users\PC\source\repos\Practice03\Log_info.txt";

        public static void Log(string solutionName, string message)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"[Solution: {solutionName}]");
                    writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }
}
