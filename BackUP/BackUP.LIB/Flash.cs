using BackUP.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackUP.LIB
{
    public class Flash: Storage
    {
        public Flash():this(TypeUsb.Usb1,0)
        {

        }
        public Flash(TypeUsb TypeUsb, double Memory)
        {
            this.TypeUsb = TypeUsb;
            this.Memory = Memory;
            this.FreeMemory = Memory;
        }

        public TypeUsb TypeUsb { get; set; }
        public double Memory { get; set; }
        public double FreeMemory { get; private set; }
        public override double GetSizeMemory()
        {
            return Memory;
        }
        public override double GetFreeMemory()
        {
            return FreeMemory;
        }
        public override bool CopyFile(double memoryData)
        {
            if (GetFreeMemory()<= memoryData)
            {
                FreeMemory -= memoryData;
                Console.WriteLine("Идет копирование файлов");
                Console.WriteLine();
                for (int i = 0; i < 20; i++)
                {
                    Thread.Sleep(GetTimeToCopy(memoryData).Milliseconds);
                    Console.Write("*");                      
                }
                Console.WriteLine();
                Console.WriteLine("Копирование заверешено!");     
                return true;
            }
            else
            {
                Console.WriteLine("{0} не помещаеться на носитель с объемом {1}",memoryData,GetFreeMemory());
                return false;
            }
        }
        protected override TimeSpan GetTimeToCopy(double memoryData)
        {
            return TimeSpan.FromSeconds(memoryData / (int)TypeUsb);           
        }
    }
}
