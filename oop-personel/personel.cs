using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_personel
{
    internal class personel
    {
        public int personelID {  get; set; }    
        public string personelAd { get; set; }
        public string personelSoyad { get; set; }   
        public string unvan {  get; set; }
        // public decimal PersonelMaasi { get; }//set metodu kaldırılırs salt okunur bir property olur.Yani üzarine değer atanamaz.sadece üzerindeki değer kunur.




        //Encapsülation edip bel,rli kurallarla set edilmesini sağlamak istiyorum.
   // private decimal _personelMaasi { get { return _personelMaasi; }
         // set { _personelMaasi = value; }
            public decimal _personelMaasi
        {
            get
            {
                if(_personelMaasi>1000)
                    return _personelMaasi;
                else
                    return 0;

            }
            set
            {
                _personelMaasi = value;
            }
        }


    }
}
