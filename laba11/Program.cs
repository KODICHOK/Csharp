using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    //5
    public class ServiceCenter
    {
        public delegate void PredicateDelegateAccept(Computer product);

        public readonly PredicateDelegateAccept PredicateDelegateAcceptContainer;

        public ServiceCenter()
        {
            PredicateDelegateAcceptContainer = delegate (Computer computer)
            {
                DimensionsRemoved(computer);
                CutOff(computer);
                Drilled(computer);
            };
        }

        private void DimensionsRemoved(Computer computer)
        {
            computer.reinstallWindows = true;
        }

        private void CutOff(Computer computer)
        {
            computer.replacethemotherboard = true;
        }

        private void Sharpened(Computer computer)
        {
            computer.replacethepowersupply = true;
        }

        private void CutThread(Computer computer)
        {
            computer.addRAM = true;
        }

        private void Drilled(Computer computer)
        {
            computer.replacethevideocard = true;
        }

        private void Painted(Computer computer)
        {
            computer.configureprograms = true;
        }
    }


    public class Computer
    {
        public bool reinstallWindows { get; set; }
        public bool replacethemotherboard { get; set; }
        public bool replacethepowersupply { get; set; }
        public bool addRAM { get; set; }
        public bool replacethevideocard { get; set; }
        public bool configureprograms { get; set; }

        public void PrintProductInfo()
        {
            Console.WriteLine($"reinstallWindows--{reinstallWindows}\n" +
                              $"replacethemotherboard--{replacethemotherboard}\n" +
                              $"replacethepowersupply--{replacethepowersupply}\n" +
                              $"addRAM--{addRAM}\n" +
                              $"replacethevideocard--{replacethevideocard}\n" +
                              $"configureprograms--{configureprograms}\n");
        }
    }

    public static class Program
    {
        private static void Main()
        {
            var serviceCenter = new ServiceCenter();
            var computer = new Computer();

            serviceCenter.PredicateDelegateAcceptContainer.Invoke(computer);
            computer.PrintProductInfo();
        }
    }
}