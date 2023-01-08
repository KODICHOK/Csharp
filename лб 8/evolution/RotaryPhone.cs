using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class RotaryPhone
    {
        internal List<char> symbols = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public readonly string Number;
        public virtual void Call()
        {
            Console.WriteLine("Введіть, кому ви хочете зателефонувати");
            string Number = writeANumber();
            Console.WriteLine("Ви зателефонували: " + Number);
        }

        public virtual void AcceptCall()
        {
            Console.WriteLine("Ви підняли трубку");
        }

        internal string writeANumber()
        {
            string tempStr;
            int tempInt;
            var sb = new StringBuilder();
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Введіть {0} число вашого номера:", i + 1);
                tempStr = Console.ReadLine();
                if (tempStr.Length != 1)
                {
                    Console.WriteLine("Помилка!");
                    --i;
                    continue;
                }
                if (Int32.TryParse(tempStr, out tempInt) == false)
                {
                    Console.WriteLine("Помилка!");
                    --i;
                    continue;
                }
            }
            return sb.ToString();
        }
    }
}