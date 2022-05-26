using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_рпм
{
    class drob
    {
        int Chis;
        int Znam;
        internal bool Znak;

        public drob(int chis1, int znam1)
        {
            Chis = chis1;
            Znam = znam1;
        }
        public drob(int chislo)
        {
            Chis = chislo;
            Znam = 1;
        }
        public drob(int celoe, int chis2, int znam2)
        {
            Chis = celoe * znam2 + chis2;
            Znam = znam2;
        }
        public double ToDouble()
        {
            return (double)(Chis) / Znam;
        }
        public static drob operator *(drob a, drob b)
        {
            return new drob(a.Chis * b.Chis, a.Znam * b.Znam);
        }
        public bool MyProperty
        {
            get
            {
                bool a = Chis >= 0;
                bool b = Znam >= 0;
                return a == b;
            }
        }
    }
}