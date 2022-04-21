using System;
using System.IO;

namespace ConsoleApp.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            if (messages.Length == 4)
            {
                foreach (var message in messages)
                {
                    writer.Write(message);
                    writer.Write(" ");
                }
            }
            else
            {
                writer.WriteLine(messages[0]);

            }
            writer.Flush();
        }

        public abstract void Dispose();
    }
}