using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı");
            kisi k = new kisi();
            Console.WriteLine("adı:{0},yası:{1}", k.Ad, k.Yas);
            Console.WriteLine("program bitti");
        }
    }
    class kisi
    {
        int yas;
        string ad;
        public kisi()
        {
            yas = 19;
            ad = "Efe KUAN";
            Console.WriteLine("Yapıcı Metot Çalıştı");

        }
        public int Yas
        {
            get
            {
                return yas;
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
        }

    }

}