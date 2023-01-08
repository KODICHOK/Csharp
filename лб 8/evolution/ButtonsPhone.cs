using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class ButtonsPhone : RotaryPhone
    {
        public ButtonsPhone() : base()
        {
            symbols.Add('*');
            symbols.Add('#');
        }

        public override void AcceptCall()
        {
            Console.WriteLine("Ви прийняли дзвінок від 0930530941");
        }
    }
}