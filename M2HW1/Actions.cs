using System;
using System.Text;

namespace M2HW1
{
    public static class Actions
    {
        public static Result PrintInfoLog()
        {
            return new Result(true, $"Start method: PrintInfoLog\n");
        }

        public static Result PrintWarningLog()
        {
            return new Result(true, $"Skipped logic in method: PrintWarningLog\n");
        }

        public static Result PrintErrorLog()
        {
            return new Result(false, $"I broke a logic");
        }
    }
}
