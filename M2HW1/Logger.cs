using System;
using System.IO;
using System.Text;

namespace M2HW1
{
    public class Logger
    {
        private static readonly Logger _instance;
        private StringBuilder _logs;

        static Logger()
        {
            _instance = new Logger();
        }

        private Logger()
        {
            _logs = new StringBuilder();
        }

        public StringBuilder Logs => _logs;

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void PrintLogs()
        {
            Console.WriteLine(Logs);
        }

        public void WriteLogsIntoFile()
        {
            File.WriteAllText("logs.txt", Logs.ToString());
        }
    }
}
