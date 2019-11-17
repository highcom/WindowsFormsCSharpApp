using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsCSharpApp
{
    public delegate void UpdateBackGroundProcess(int progress);

    class BackGroundProcess
    {
        public int X { get; set; } = 10;
        public int Y { get; } = 20;

        private CancellationToken cancellationToken;

        public event UpdateBackGroundProcess updateBackGroundProcess;

        public BackGroundProcess(CancellationToken token)
        {
            cancellationToken = token;
        }

        public Boolean StartProcess()
        {
            for (int i = 0; i <= 100; i+=10)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }

                updateBackGroundProcess(i);
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(1000);
            return true;
        }
    }
}
