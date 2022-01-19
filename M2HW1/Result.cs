using System;

namespace M2HW1
{
    public class Result
    {
        private bool _status;
        private string _msg;

        public Result(bool status, string msg)
        {
            _status = status;
            _msg = msg;
        }

        public bool Status => _status;
        public string Msg => _msg;
    }
}
