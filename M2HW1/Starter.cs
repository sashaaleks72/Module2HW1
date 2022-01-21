using System;

namespace M2HW1
{
    public class Starter
    {
        private Logger _logger;
        private Actions _actions;

        public Starter()
        {
            _logger = Logger.Instance;
            _actions = new Actions();
        }

        public void Run()
        {
            int randomValue = 0;

            for (int i = 0; i < 100; i++)
            {
                randomValue = new Random().Next(1, 4);

                Result result = randomValue switch
                {
                    1 => _actions.GetInfoLog(),
                    2 => _actions.GetWarningLog(),
                    3 => _actions.GetErrorLog(),
                    _ => new Result(false, "Something went wrong")
                };

                if (!result.Status)
                {
                    _logger.WriteLog($"{DateTime.Now}: Error: Action failed by a reason: {result.Msg}\n");
                }
                else if (result.Msg.Contains("Info"))
                {
                    _logger.WriteLog($"{DateTime.Now}: Info: {result.Msg}");
                }
                else
                {
                    _logger.WriteLog($"{DateTime.Now}: Warning: {result.Msg}");
                }
            }

            _logger.PrintLogs();
            _logger.WriteLogsIntoFile();
        }
    }
}
