using System;
using System.Text;

namespace M2HW1
{
    public class Actions
    {
        public Result GetInfoLog()
        {
            return new Result(true, $"Start method: {nameof(GetInfoLog)}\n");
        }

        public Result GetWarningLog()
        {
            return new Result(true, $"Skipped logic in method: {nameof(GetWarningLog)}\n");
        }

        public Result GetErrorLog()
        {
            return new Result(false, $"I broke a logic");
        }
    }
}
