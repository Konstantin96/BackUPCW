using BackUP.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUP.LIB
{
    public class HDD : Storage
    {
        public HDD():this(TypeUsb.Usb1,1,100)
        {

        }
        public HDD(TypeUsb TypeUsb, int KolRazdelov, double SizeRazdelov)
        {

        }
        public TypeUsb TypeUsb { get; set; }
        public int KolRazdelov { get; set; }
        public double SizeRazdelov { get; set; }

        public override double GetSizeMemory()
        {
            throw new NotImplementedException();
        }

        public override bool CopyFile(double memoryData)
        {
            throw new NotImplementedException();
        }

        public override double GetFreeMemory()
        {
            throw new NotImplementedException();
        }

        protected override TimeSpan GetTimeToCopy(double memoryData)
        {
            throw new NotImplementedException();
        }
    }
}
