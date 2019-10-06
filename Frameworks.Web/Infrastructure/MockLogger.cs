using Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deatils.Infrastructure
{
    public class MockLogger : IBosLogger
    {

        private List<LogEntry> entries = new List<LogEntry>();

        public void Log(LogLevel level, string commandName, string requestedBy, string correlationId, string requestId, string callingApplication, string input, string outPut, string message)
        {
            entries.Add(new LogEntry
            {
                callingApplication = callingApplication,
                commandName = commandName,
                correlationId = correlationId,
                input = input,
                requestedBy = outPut,
                level = level,
                message = message,
                outPut = outPut,
                requestId = requestId
            }) ;
        }


        private class LogEntry
        {
            public LogLevel level { get; set; }
            public string commandName { get; set; }
            public string requestedBy { get; set; }
            public string correlationId { get; set; }
            public string requestId { get; set; }
            public string callingApplication { get; set; }
            public string input { get; set; }
            public string outPut { get; set; }
            public string message { get; set; }
        }
    }
}
