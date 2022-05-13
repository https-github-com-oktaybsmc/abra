using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
namespace ConsoleApp2
{
    public class Blok
    {
        public int giris { get; set; }
        public DateTime sure { get; set; }
        public string oncekideger { get; set; }
        public string deger { get; set; }
        public string veri { get; set; }
        public Blok(DateTime timeStamp, string previousHash, string data)
        {
            giris = 0;
            sure = timeStamp;
            oncekideger = previousHash;
            veri = data;
            deger = hashdegeri();
        }
        public string hashdegeri()
        {
            SHA256 alg = SHA256.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes($"{sure}-{oncekideger ?? ""}-{veri}");
            byte[] outputBytes = alg.ComputeHash(inputBytes);
            return Convert.ToBase64String(outputBytes);
        }
    }


}
