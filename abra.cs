using System;
using System.Security.Cryptography;
namespace yeni
{
    internal class abra
    {
        static void Main(string[] args)
        {
            string sifrelimetin = "bloktan geçicek veri";
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bitDizisi = System.Text.Encoding.UTF8.GetBytes(sifrelimetin);
            string sifreli1 = Convert.ToBase64String(sha1.ComputeHash(bitDizisi));
            bzhighlevel BE = new bzhighlevel();
            BE.AddBlock(sifreli1);
            
