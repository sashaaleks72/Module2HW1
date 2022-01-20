using System;
using System.Text;

namespace M2HW1
{
    public static class Starter
    {
        static Starter()
        {
            Logger = Logger.Instance;
        }

        public static Logger Logger { get; set; }

        public static void Run()
        {
            int randomValue = 0;

            for (int i = 0; i < 100; i++)
            {
                randomValue = new Random().Next(1, 4);

                Result result = randomValue switch
                {
                    1 => Actions.GetInfoLog(),
                    2 => Actions.GetWarningLog(),
                    3 => Actions.GetErrorLog(),
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
            }

            Logger.PrintLogs();
            Logger.WriteLogsIntoFile();
        }
    }
}
