using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hayvan
{
    internal class Insan : Hayvan
    {
        public string Adi {  get; set; }    
        public string Düşünce {  get; set; }
        public Insan() 
        
        {
            Adi = "ZAFER";

        }  
        internal void Dusun()
        {
            Console.WriteLine("$"{ adi},{ düsünce} düşündü  ");

        }

    }
}
