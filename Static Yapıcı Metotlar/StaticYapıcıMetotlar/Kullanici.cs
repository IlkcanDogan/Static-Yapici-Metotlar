using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapıcıMetotlar
{
    class Kullanici
    {
        /*
         * Kullanıcı sınıfının 2 adet yapıcı metotdu bulunmaktadır. Bunlardan static olanı
         * "kullaniciSayisi" adlı static değişkenin başlangoç değerlerini atarken, static olmayanı
         * "nick" ve "eMail" değişkenlerinin atama işlemlerini gerçekleştirmektedir.
         * 
         * Kullanıcı sınıfından ilk nesne oluşturulduğunda hem static yapıcı metot hemde static
         * olmayan yapıcı metot çalışacaktır (ilk static yapıcı metot çalışır). İlk nesneden sonra
         * oluşturulacak diğer tüm nesnelerde sadece static olmayan yapıcı metot çağıralacaktır.
         * Yani static yapıcı metot sadece ilk nesne oluşturulduğunda çalışır.
         */
        static int kullaniciSayisi;
        public static int KullaniciSayisi
        {
            get
            {
                return kullaniciSayisi;
            }
        }

        string nick;
        string eMail;
      
        static Kullanici()
        {
            kullaniciSayisi = 0;
        }

        public Kullanici(string nick, string eMail)
        {
            this.nick = nick;
            this.eMail = eMail;
            kullaniciSayisi++;
        }
    }
}
