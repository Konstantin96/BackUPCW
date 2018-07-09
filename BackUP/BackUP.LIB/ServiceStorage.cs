using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUP.LIB
{
    public enum TypeDevice
    {
        Flash, DVD, HDD
    }
    public class ServiceStorage
    {
        static List<Flash> Flashes;
        static ServiceStorage()
        {
            Flashes = new List<Flash>();
        }
        public static void AddFlash(Flash flash)
        {
            Flashes.Add(flash);
        }
        public static double GetMemoryDevice()
        {
            double totalMem = Flashes.Sum(s => s.GetSizeMemory());
            Console.WriteLine("Объем всех носителей  = ", totalMem);
            return totalMem;
        }
        public static double GetFreeMemoryDevice()
        {
            double totalMem = Flashes.Sum(s => s.GetFreeMemory());
            Console.WriteLine("Свободный объем всех носителей  = ", totalMem);
            return totalMem;
        }
        public static void GetCountDevice(TypeDevice typeDevice, double SizeMem)
        {
            double total = 0;
            switch (typeDevice)
            {
                case TypeDevice.Flash:
                    {
                        int i = 1;
                        foreach (Flash item in Flashes)
                        {
                            total = Math.Round(SizeMem / item.Memory);
                            if (SizeMem%(int)item.Memory!=0)
                            {
                                total++;
                            }
                            Console.WriteLine("{0}. {1} ({2}) - {3} GB - {4} шт.",i++, item.NameNositel, item.Model, item.Memory, total);
                        }
                        Console.Write("Выберите тип флэшки: ");
                        i=Int32.Parse(Console.ReadLine());
                        GetTimeToCopyDevice(typeDevice, i, SizeMem);
                    }
                    break;
                case TypeDevice.DVD:
                    {

                    }
                    break;
                case TypeDevice.HDD:
                    {

                    }
                    break;
                default:
                    break;
            }

        }

        public static void GetTimeToCopyDevice(TypeDevice typeDevice, int choice,double sizeData)
        {
            switch (typeDevice)
            {
                case TypeDevice.Flash:
                    {
                        Flash choiceFlash = Flashes[choice - 1];

                        int CountDevice = 3;

                        Flash[] flashesD = new Flash[CountDevice];
                        for (int i = 0; i < 3; i++)
                        {
                            flashesD[i] = choiceFlash;
                            if (i==CountDevice-1)
                            {
                                flashesD[i].CopyFile(sizeData);
                            }
                           
                            flashesD[i].CopyFile(flashesD[i].Memory);
                            sizeData -= flashesD[i].Memory;
                        }
                    }
                    break;
                case TypeDevice.DVD:
                    break;
                case TypeDevice.HDD:
                    break;
                default:
                    break;
            }
        }
    }
}
