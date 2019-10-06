using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Interfaces
{
    public interface IBosLogger
    {
         void Log(LogLevel level, 
             String commandName,
             String requestedBy,
             String correlationId,
             String requestId,
             String callingApplication,
             String input,String outPut,
             String message);

    }

    public enum LogLevel
    {
        ERROR, WARNING, INFO
    }
}
