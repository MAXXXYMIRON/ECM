using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashWorking
{
    class CPU
    {
        static void Main(string[] args)
        {
            MainMemory mainMemory = new MainMemory(10, 10, 4);
            int[] line = mainMemory.GetLine(8, 4);

            Console.ReadKey();
        }
    }
}
