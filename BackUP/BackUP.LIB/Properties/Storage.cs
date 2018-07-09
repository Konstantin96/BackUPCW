using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUP.Modul
{
    public enum TypeUsb
    {
        Usb1 = 12, Usb2 = 480, Usb3 = 5000
    }
    public enum TypeDVD
    {
        SideA = 5, SideB = 9
    }
    abstract public class Storage
    {
        public string NameNositel { get; set; }
        public string Model { get; set; }
        public abstract double GetSizeMemory();
        public abstract bool CopyFile(double memoryData);
        public abstract double GetFreeMemory();
        protected abstract TimeSpan GetTimeToCopy(double memoryData);
        public virtual void StorageInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Name : ",NameNositel);
            Console.WriteLine("Model: ",Model);
            Console.WriteLine("----------------------------");
        }
    }
}
