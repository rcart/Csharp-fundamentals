using System;
using System.Collections.Generic;

namespace Acme.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
              Console.Write(item.Log());  
            }
        }
    }
}