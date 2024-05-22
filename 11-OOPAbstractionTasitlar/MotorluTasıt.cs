using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPAbstractionTasitlar
{
    internal class MotorluTasıt
    {
        //public ovvveride void Git)(//kimseden miras almadığı içn ovverid kullanamaız
        public void Git()
        {

        }
        internal class Araba : MotorluTasıt
        {
            public  override void Git()
            {
                base.Git();
            }
        }
    }
}
