using System;
using System.Security.Cryptography;
namespace yeni
{
    internal class abracoin
    {
        static void Main(string[] args)
        {
            string sifrelimetin = "bloktan geçicek veri";
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bitDizisi = System.Text.Encoding.UTF8.GetBytes(sifrelimetin);
            string sifreli1 = Convert.ToBase64String(sha1.ComputeHash(bitDizisi));
            bzhighlevel BE = new bzhighlevel();

            BE.AddBlock(sifreli1);

            int itemNumber = 0;
            foreach (var item in BE.Blokzincir)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Blok Değeri: " + itemNumber);
                Console.WriteLine("Block hash değeri: " + BitConverter.ToString(item.blokdegeri));
                Console.WriteLine("Önceki (Previous) hash değeri: " + BitConverter.ToString(item.oncekideger));
                Console.WriteLine("Veri Hareketi: " + item.veri);
                Console.WriteLine("-----------------");
                Console.WriteLine("");
                itemNumber++;
            }
        }

    }
}