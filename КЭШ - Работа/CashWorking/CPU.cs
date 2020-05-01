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
            Controller Data = new Controller(10, 10, 4);

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Data[i, i, j] = '0';
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Data[2, i, j] = '0';
                }
            }

            Data.ClearCash();
            Console.ReadKey();
        }
    }
}
