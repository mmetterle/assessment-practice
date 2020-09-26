using System;
using System.Collections.Generic;
using System.Text;

namespace problems.Classes
{
    public class Log
    {
        public string Id { get; }
        public string LogEntry { get; }

        public Log(string id, string log)
        {
            Id = id;
            LogEntry = log;
        }
    }
}
