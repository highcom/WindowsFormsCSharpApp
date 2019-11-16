using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCSharpApp
{
    public delegate void UudateBackGroundProcess(int progress);

    class BackGroundProcess
    {
        public event UudateBackGroundProcess updateBackGroundProcess;

        public Boolean StartProcess()
        {
            for (int i = 0; i <= 100; i+=10)
            {
                updateBackGroundProcess(i);
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(3000);
            return true;
        }
    }
}
