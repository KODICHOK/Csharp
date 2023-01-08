using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class ColorScreenPhone : BlackScreenPhone
    {
        public string SecondNumber;
        public int CountOfColor;
        public bool HavingTwoSIM { get; private set; }

        public ColorScreenPhone() : base()
        {
            MakeSecondNumber();

            CountOfColor = 7;
        }

        public override void Call()
        {
            Console.WriteLine("На який номер ви хочете зателефонувати?");
            string Number = writeANumber();

            if (HavingTwoSIM)
            {
                Console.WriteLine("З якого номеру ви хочете зателефонувати?\n[1] - {0}\t[2] - {1}", this.Number, SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*Ви подзвонили з {0} сімки на номер {1}*",
                    temp == "1" ? "першої" : (temp == "2" ? "другої" : ""), Number);
                }
                else Console.WriteLine("Помилка!");
            }
            else Console.WriteLine("*Ви подзвонили на телефон {0}*", Number);
        }

        public override void AcceptCall()
        {
            Console.WriteLine("1234567 телефонує!");
            if (HavingTwoSIM)
            {
                Console.WriteLine("З якої сімки ви хочете прийняти дзвінок?\n[1] - {0}\t[2] - {1}", this.Number, SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*Ви прийняли дзвінок з {0} сімки*",
                    temp == "1" ? "першої" : (temp == "2" ? "другої" : ""));
                }
                else Console.WriteLine("Помилка!");
            }
            else Console.WriteLine("*Ви відповіли на дзвінок*");
        }

        public override void SendSms()
        {
            Console.Write("Введіть повідомлення, яке хочете надіслати 12345678: ");
            string message = Console.ReadLine();
            if (HavingTwoSIM)
            {
                Console.WriteLine("З якої сімки?\n[1] - {0}\t[2] - {1}", this.Number, SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*Ви відправили повідомлення з {0} сімки*",
                    temp == "1" ? "першої" : (temp == "2" ? "другої" : ""));
                }
                else Console.WriteLine("Помилка!");
            }
            else Console.WriteLine("Відправлено!");
        }

        public void SendMms()
        {
            Console.Write("Введіть назву картинки, яку відправите до 12345678 : ");
            string message = Console.ReadLine();
            if (HavingTwoSIM)
            {
                Console.WriteLine("З якої сімки?\n[1] - {0}\t[2] - {1}", this.Number, SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*Ви відправили картинку з {0} сімки*",
                    temp == "1" ? "першої" : (temp == "2" ? "другої" : ""));
                }
                else Console.WriteLine("Помилка!");
            }
            else Console.WriteLine("Відправлено!");
        }

        public void AcceptMms()
        {
            Console.Write("Ви отримали повідомлення від 12345678 : image.png");

        }

        private void MakeSecondNumber()
        {
            while (true)
            {
                Console.WriteLine("Ви хочете зробити нову сімку?\n[1] - Yes\t [2] - No");
                string temp = Console.ReadLine();
                if (temp == "1")
                {
                    HavingTwoSIM = true;
                    this.SecondNumber = writeANumber();
                    break;
                }
                else if (temp == "2")
                {
                    HavingTwoSIM = false;
                    Console.WriteLine("Добре!");
                    break;
                }
                else Console.WriteLine("Помилка");
            }
        }
    }
}