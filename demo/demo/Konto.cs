using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Konto
    {
        private int saldo = 0;
        public int Saldo { get { return saldo; } private set { saldo = value; } }  


        public void Einzahlen(int betrag)
        {
            saldo += betrag;
        }

        public void Abheben(int betrag)
        {
            if (saldo - betrag < 0)
                throw new Exception("Nicht erlaubt. Saldo darf nicht ins Minus fallen.");

            saldo -= betrag;
        }
    }
}
