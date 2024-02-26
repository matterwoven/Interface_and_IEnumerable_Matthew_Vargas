using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_IEnumerable_Matthew_Vargas
{
    internal class Door : IOpen, ISlamShut, IClose
    {
        public void Close()
        {
            //Console.WriteLine($"You closed the Door to {_minRotationalValue}");
            // if( <slammed shut> )
            // {
            // Console.WriteLine("It slammed shut");
            // <Logic linking to noise of slamming>
            // }
        }

        public void Open()
        {
            //Console.WriteLine($"You opened the Door to {_maxRotationalValue}");
            // <Logic for noise opening Door>
        }

        public void SlamShut()
        {
            //Console.WriteLine("You slammed shut the door");
        }
    }
}
