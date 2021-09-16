using System;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CleanRazonUI.Infrastructure
{
    public class ResultProfileAttribute : ResultFilterAttribute
    {
        private Stopwatch timer;

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            timer = Stopwatch.StartNew();
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            timer.Stop();
            string message = $"На выполнение результата {context.ActionDescriptor.DisplayName} затрачено {timer.Elapsed}";

            StreamWriter streamWriter = new StreamWriter("App_Data/log.txt", true);
            streamWriter.WriteLine(message);
            streamWriter.Close();
        }
    }
}
