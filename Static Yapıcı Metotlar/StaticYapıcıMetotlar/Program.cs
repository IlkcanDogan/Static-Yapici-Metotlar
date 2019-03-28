using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapıcıMetotlar
{
    class Program
    {
        /*
         * Static Yapıcı Metotlar
         * 
         * Yapıcı metotlar da normal metotlar gibi static olarak tanımlanabilirler. Sınıfın static
         * değişkenleri ile ilgili işlemler static yapıcı metodun içerisinde yapılabilir. Static
         * yapıcı metotlar parametre almazlar ve erişim belirleyicileri yoktur.
         */
        static void Main(string[] args)
        {
            //Online Kullanıcı Sayısı: 0
            Console.WriteLine("Online Kullanıcı Sayısı: {0}",Kullanici.KullaniciSayisi);

            Kullanici k1 = new Kullanici("İlkcan Doğan", "deneme@mail.com");
            Kullanici k2 = new Kullanici("Cafer Gün","deneme2@gmail.com");

            //Online kullanıcı Sayısı: 2
            Console.WriteLine("Online Kullanıcı Sayısı: {0}", Kullanici.KullaniciSayisi);

            Console.ReadLine();

        }
    }
}
