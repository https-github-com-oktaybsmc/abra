using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeni
{
    internal class Blok
    {
        private byte[] _blokdegeri;
        private byte[] _oncekideger;
        private string _veri;
        private int _nonce;

        public byte [] blokdegeri { get { return _blokdegeri; } }
        public byte [] oncekideger { get { return _oncekideger; } }

        public string veri { get { return _veri; } }

        public int Nonce { get { return _nonce; } }
        public Blok(byte[] Blokdegeri, byte[] oncekideger, string veri, int Nonce = 0)
        {
            _Blokdegeri = Blokdegeri;
            _oncekideger = oncekideger;
            _veri = veri;
            _nonce = Nonce;
        }


    }
}
