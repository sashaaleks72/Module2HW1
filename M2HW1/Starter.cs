using System;
using System.Text;

namespace M2HW1
{
    public static class Starter
    {
        // private static Logger _logger;
        static Starter()
        {
            // _logger = new Logger();
        }

        // public static Logger Logger => _logger
        public static Logger Logger { get; set; }

        public static void Run()
        {
            Logger = Logger.Instance;

            int i = 0;
            int randomValue = 0;

            while (i != 100)
            {
                randomValue = new Random().Next(1, 4);

                Result result = randomValue switch
                {
                    1 => Actions.PrintInfoLog(),
                    2 => Actions.PrintWarningLog(),
                    3 => Actions.PrintErrorLog(),
                    _ => new Result(false, "Something went wrong")
                };

                if (!result.Status)
                {
                    Logger.Logs.Append($"{DateTime.Now}: Error: Action failed by a reason: {result.Msg}\n");
                }
                else if (result.Msg.Contains("Info"))
                {
                    Logger.Logs.Append($"{DateTime.Now}: Info: {result.Msg}");
                }
                else
                {
                    Logger.Logs.Append($"{DateTime.Now}: Warning: {result.Msg}");
                }

                i++;
            }

            Logger.PrintLogs();
            Logger.WriteLogsIntoFile();
        }
    }
}
