using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_IEnumerable_Matthew_Vargas
{
    internal class Chest : IOpen, ISlamShut, IClose
    {
        public void Close()
        {
            //Console.WriteLine($"You closed the Chest to {_minRotationalValue} degrees");
            // if( <slammed shut> )
            // {
            // Console.WriteLine($"It slammed shut");
            // <Logic linking to noise of slamming>
            // }
        }

        public void Open()
        {
            //Console.WriteLine($"You opened the Chest to {_maxRotationalValue} degrees");
            // <Logic for noise opening chest>
        }

        public void SlamShut()
        {
            //Console.WriteLine("You slammed shut the Chest");
        }
    }
}
