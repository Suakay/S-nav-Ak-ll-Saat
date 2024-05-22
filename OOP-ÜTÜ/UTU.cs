using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ÜTÜ
{
    //accesModifier veritipi PropertyName{get;set;}
    internal class UTU
    {
        public string Marka {  get; set; }  
        public string MyProperty {  get; set; } 
        public string Renk {  get; set; }   
        public int sıcaklı {  get; set; }   
        public bool KazanlıMı {  get; set; }    


        //construct metot(yapıcı metot) 
        //ctor+tab+tab constructor oluşturur
        //Default constructrı yazöak zorunda değiliz.Yazmsakta vardır
        //ınternall da acsess modifider.
        public UTU() 
        
        {
            Console.WriteLine("ÜTÜ NESNESİ YUARATILDI");
        } 
        public UTU(string marka,string renk,bool kazanlı, int sıcaklık)
        {
            this.Marka = marka;//property
            this.Renk = renk;   
            this.sıcaklı=sıcaklık;
            this.KazanlıMı = kazanlı;
            Console.WriteLine();    
        }
        //Constructor Method(yapıcı metot)
       public UTU(string marka)
        {
            this.Marka = marka;
            Console.WriteLine($"ütünesnesi yaratıldıuı");
        }
        public UTU(string marka)
        {
            this.Marka= marka;
            Console.WriteLine();
        }

        public void Isin(int derece)
        {
            this.sıcaklı += derece;
        }
    }
}
