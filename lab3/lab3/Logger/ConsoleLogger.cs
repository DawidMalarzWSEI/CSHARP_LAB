using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Logger;

namespace lab3.Logger
{
    class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {

        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
