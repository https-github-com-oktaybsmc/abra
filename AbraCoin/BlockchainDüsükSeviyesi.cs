using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace yeni
{
    static internal class BlockchainDüsükSeviyesi
    {

        const string yaratilisblokmetin = "Genesis  blok";
        public static Blok yaratilisblok()
        {
            byte[] oncekideger = BitConverter.GetBytes(0);
            byte[] blokdegeri = HashBlock(oncekideger, yaratilisblokmetin, 0);

            Blok yaratılısblok = new Blok(blokdegeri, oncekideger, yaratilisblokmetin, 0);
            return yaratılısblok;
        }

        public static byte[] HashBlock(byte[] oncekideger, string BlockData, int Nonce)
        {
            string oncekiblokdegeri = BitConverter.ToString(oncekideger);
            string NonceString = Nonce.ToString();
            string tamamlanmısblok = oncekiblokdegeri + NonceString + BlockData;

            byte[] yeniblokdeger = SHA1.HashData(Encoding.ASCII.GetBytes(tamamlanmısblok));
            return yeniblokdeger;

        }
    }
}