using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class BlackScreenPhone : ButtonsPhone
    {
        internal string ScreenResolution;
        internal string ScreenSize;
        public string Color;

        public BlackScreenPhone() : base()
        {
            Console.WriteLine("¬вед≥ть розд≥льну здатн≥сть екрану: ");
            ScreenResolution = Console.ReadLine();
            Console.WriteLine("¬вед≥ть розм≥р: ");
            ScreenSize = Console.ReadLine();
            Console.WriteLine("¬вед≥ть кол≥р: ");
            Color = Console.ReadLine();
        }
        public virtual void SendSms()
        {
            Console.Write("¬вед≥ть смс, €ке хочете в≥дправити до 0930530941 :");
            string message = Console.ReadLine();
        }

        public virtual void AcceptSms()
        {
            Console.WriteLine("” вас 1 нове пов≥домленн€: шалом");
        }
    }
}