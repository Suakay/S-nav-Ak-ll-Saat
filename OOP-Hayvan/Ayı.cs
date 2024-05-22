using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hayvan
    
{
    //Derived Class
    internal class Ayı:Hayvan//Inheritance-MİRAS
    {
        public Ayı();
        {
            Console.WriteLine("Ayı Yaratıldı");
            //this anahtar kelimesi bu sınıfın miras aldıklarıda dahil ulaşabildiği tüm üyelere ulaşmamızı sağlar

            base.Uyu();//Bu möetod protected olarak tanımlandığından buradan erişebiliriz.
            //private üyesine ulaşamam.
           // base.Beslen();

        }

    }
}
