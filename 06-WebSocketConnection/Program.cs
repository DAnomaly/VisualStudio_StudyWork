using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_WebSocketConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            new ConnectionManager("127.0.0.1", 1818);

            while (true)
            {

            }

        }
    }
}
