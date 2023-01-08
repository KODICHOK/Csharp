using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class SmartPhone : ColorScreenPhone
    {
        public readonly bool HavingThouchScreen;
        public readonly int CountOfTouches;
        public readonly int CountOfCameras;

        public SmartPhone() : base()
        {
            HavingThouchScreen = true;
            CountOfTouches = 7;
            CountOfCameras = 3;
        }

        public void MakeAPhoto()
        {
            Random random = new Random();
            Console.WriteLine("З якої камери ви хочете зробити фото?");
            for (int i = 1; i <= CountOfCameras; i++)
            {
                Console.WriteLine("[{0} - {1} мегапікселя]", i, random.Next(3, 50));
            }
            var temp = Console.ReadLine();
            int number;
            if (temp.Length == 1)
            {
                if (Int32.TryParse(temp, out number))
                {
                    if (number > 0 && number <= CountOfCameras) Console.WriteLine("Ви зробили фоно з камери під номером {0}", number);
                    else Console.WriteLine("Помилка!");
                }
                else Console.WriteLine("Помилка!");
            }
            else Console.WriteLine("Помилка!");
        }
        public void MakeAVideo()
        {
            Random random = new Random();
            Console.WriteLine("З якої камери ви хочете зробити відео?");
            for (int i = 1; i <= CountOfCameras; i++) Console.WriteLine("[{0} - {1} мегапікселя]", i, random.Next(3, 50));
            var temp = Console.ReadLine();
            int number;
            if (temp.Length == 1)
            {
                if (Int32.TryParse(temp, out number))
                {
                    if (number > 0 && number <= CountOfCameras)
                    {
                        Console.WriteLine("Ви почали записукати відео з камери під номером {0}", number);
                        Console.WriteLine("Натисніть щоб зупинити...");
                        Console.ReadLine();
                        Console.WriteLine("Помилка((");
                    }
                    else Console.WriteLine("Помилка!");
                }
                else Console.WriteLine("Помилка!");
            }
            else Console.WriteLine("Помилка!");
        }
    }
}