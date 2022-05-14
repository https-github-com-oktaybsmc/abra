using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeni
{
    internal class bzhighlevel
    {
        LinkedList<Blok> _blokzincir;

        public LinkedList<Blok> Blokzincir { get { return _blokzincir; } }

        public bzhighlevel()
        {
            _blokzincir = new LinkedList<Blok>();
            _blokzincir.AddLast(BlockchainDüsükSeviyesi.yaratilisblok());
        }


        public void AddBlock(string DataToAdd)
        {
            byte[] yeniblokdegeri = BlockchainDüsükSeviyesi.HashBlock(_blokzincir.Last.Value.blokdegeri, DataToAdd, 0);
            Blok yeniblok = new Blok(yeniblokdegeri, _blokzincir.Last.Value.blokdegeri, DataToAdd);
            _blokzincir.AddLast(yeniblok);
        }

    }
}
