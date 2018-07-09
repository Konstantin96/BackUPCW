using BackUP.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUP.LIB
{
    public class DVD: Storage
    {
        public DVD() : this(0, 0, TypeDVD.SideA)
        {

        }
        public DVD(double SpeedRead, double SpeedWrite, TypeDVD TypeDVD)
        {
            this.SpeedRead = SpeedRead;
            this.SpeedWrite = SpeedWrite;
            this.TypeDVD = TypeDVD;
        }
        public double SpeedRead { get; set; }
        public double SpeedWrite { get; set; }
        public TypeDVD TypeDVD { get; set; }

        public override bool CopyFile(double memoryData)
        {
            throw new NotImplementedException();
        }

        public override double GetFreeMemory()
        {
            throw new NotImplementedException();
        }

        public override double GetSizeMemory()
        {
            throw new NotImplementedException();
        }

        protected override TimeSpan GetTimeToCopy(double memoryData)
        {
            throw new NotImplementedException();
        }
    }
}
