using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaArrayList
{
    class Automobil
    {
        private string marka;
        public Automobil(string m)
        {
            marka = m;
        }
        public string DajMarku()
        {
            return marka;
        }
    }
    Automobil a = new Automobil(textBoxNovi.Text);
}

