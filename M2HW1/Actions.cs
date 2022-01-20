using System;
using System.Text;

namespace M2HW1
{
    public static class Actions
    {
        public static Result GetInfoLog()
        {
            return new Result(true, $"Start method: {nameof(GetInfoLog)}\n");
        }

        public static Result GetWarningLog()
        {
            return new Result(true, $"Skipped logic in method: {nameof(GetWarningLog)}\n");
        }

        public static Result GetErrorLog()
        {
            return new Result(false, $"I broke a logic");
        }
    }
}
