using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCSharpApp
{
    class YieldObject
    {
        public IEnumerator<String> GetEnumerator()
        {
            yield return "Start";

            for (var i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                yield return " P" + i;
            }

            System.Threading.Thread.Sleep(1000);
            yield return " Finish";
        }
    }
}
