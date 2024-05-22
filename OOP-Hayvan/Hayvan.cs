using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hayvan
{
    internal class Hayvan
    {
        //bASE class
        public string Besin {  get; set; }  
        public string Barinak {  get; set; }    
        public string UykuSuresi {  get; set; }
        protected void Uyu()
        {
            Console.WriteLine($"{UykuSuresi},{Barinak},barinağında uyudu");
        }
        private void Beslen()
        {
            Console.WriteLine($"{Besin} YEDİ    ");
        }
        public void BilgileriGoster()
        {
            Beslen();
            Uyu();
        }
    }
}
