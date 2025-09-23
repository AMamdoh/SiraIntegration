using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Entities.Logger
{
    public class UiLogger
    {
        private readonly BindingList<LogEntry> _logs;

        public UiLogger(BindingList<LogEntry> logs)
        {
            _logs = logs;
        }

        private void Log(string level, string message)
        {
            _logs.Add(new LogEntry
            {
                Time = DateTime.Now,
                Level = level,
                Message = message
            });
        }

        public void LogError(string message) => Log("ERR", message);
        public void LogInfo(string message) => Log(level: "INFO", message);
        public void LogWrn(string message) => Log(level: "Wrn", message);

    }

}
