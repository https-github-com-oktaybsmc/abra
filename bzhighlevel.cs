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

        public LinkedList<Blok> Blokzincir { get { return _Blokzincir; } }

        public bzhighlevel()
        {
            _blokzincir = new LinkedList<Blok>();
            _blokzincir.AddLast(Blokzincirilowlevel.yaratılısblokmetin());
        }

        public void AddBlock(string DataToAdd)
        {
            byte[] yeniblokdegeri = blokzincirilowlevel.blokdeger(_blokzincir.Last.Value.blokdeger, DataToAdd, 0);
            Blok yeniblok = new Blok(yeniblokdegeri, _blokzincir.Last.Value.blokdeger, DataToAdd);
            _blokzincir.AddLast(yeniblok);
        }

    }
}
