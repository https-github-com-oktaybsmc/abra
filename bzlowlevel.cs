using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace yeni
{
    static internal class bzlowlevel
    {

        const string yaratılısblokmetin = "En Düşük Seviye'ye Ulaşıldı";
        public static Blok yaratılısblokmetin()
        {
            byte[] oncekideger = BitConverter.GetBytes(0);
            byte[] blokdegeri = HashBlock(oncekideger, yaratılısblokmetin, 0);

            Blok yaratılısblok = new Blok(blokdegeri, oncekideger, yaratılısblokmetin, 0);
            return yaratılısblok;
        }

        public static byte [] HashBlock(byte[] oncekiblokdegeri, string BlockData, int Nonce )
        {
            string oncekiblokdegeri = BitConverter.ToString(oncekiblokdeger);
            string NonceString = Nonce.ToString();
            string tamamlanmısblok = oncekiblokdegeri + NonceString + BlockData;

            byte[] yeniblokdeger = SHA1.HashData(Encoding.ASCII.GetBytes(tamamlanmısblok));
            return yeniblokdeger;

        }
    }
}
