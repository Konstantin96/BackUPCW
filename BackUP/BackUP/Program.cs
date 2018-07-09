using BackUP.LIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUP
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash f1 = new Flash(Modul.TypeUsb.Usb1, 2);
            f1.NameNositel = "Samsung";
            f1.Model = "KC-15994";
            Flash f2 = new Flash(Modul.TypeUsb.Usb1, 4);
            Flash f3 = new Flash(Modul.TypeUsb.Usb1, 8);

            ServiceStorage.AddFlash(f1);
            ServiceStorage.AddFlash(f2);
            ServiceStorage.AddFlash(f3);
            ServiceStorage.AddFlash(new Flash(Modul.TypeUsb.Usb2, 16));
            ServiceStorage.AddFlash(new Flash(Modul.TypeUsb.Usb2, 32));

            Console.Write("Введите объем информации для BackUP: ");
            double t = double.Parse(Console.ReadLine());
            ServiceStorage.GetCountDevice(TypeDevice.Flash, t);
        }
    }
}
