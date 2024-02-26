using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_IEnumerable_Matthew_Vargas
{
    internal class Bottle : IOpen, IClose
    {
        public void Close()
        {
            //Console.WriteLine($"You closed the bottle to {_minRotationalValue}");
            // <Logic for playing noise of closing bottle(?)>
        }

        public void Open()
        {
            //Console.WriteLine($"You opened the bottle to {_maxRotationalValue} degrees");
            // <Logic for playing noise of opening bottle>
        }
        //Can't slam a bottle shut
    }
}
