using Ibsys2.Static.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibsys2.Berechnungen.Logic
{
    public sealed class ValueStore
    {
        private static readonly ValueStore instance = new ValueStore();

        private ValueStore() { }

        public static ValueStore Instance {
            get {
                return instance;
            }
        }

        //Periode 0
        public int vertriebswunschP1;
        public int vertriebswunschP2;
        public int vertriebswunschP3;


        // Sicherheitsbestand
        public int sicherheitsbestandP1 = 100;
        public int sicherheitsbestandP1e26 = 100;
        public int sicherheitsbestandP1e51 = 100;
        public int sicherheitsbestandP1e16 = 100;
        public int sicherheitsbestandP1e17 = 100;
        public int sicherheitsbestandP1e50 = 100;
        public int sicherheitsbestandP1e4 = 100;
        public int sicherheitsbestandP1e10 = 100;
        public int sicherheitsbestandP1e49 = 100;
        public int sicherheitsbestandP1e7 = 100;
        public int sicherheitsbestandP1e13 = 100;
        public int sicherheitsbestandP1e18 = 100;
        public int sicherheitsbestandP2 = 100;
        public int sicherheitsbestandP2e26 = 100;
        public int sicherheitsbestandP2e56 = 100;
        public int sicherheitsbestandP2e16 = 100;
        public int sicherheitsbestandP2e17 = 100;
        public int sicherheitsbestandP2e55 = 100;
        public int sicherheitsbestandP2e5 = 100;
        public int sicherheitsbestandP2e11 = 100;
        public int sicherheitsbestandP2e54 = 100;
        public int sicherheitsbestandP2e8 = 100;
        public int sicherheitsbestandP2e14 = 100;
        public int sicherheitsbestandP2e19 = 100;
        public int sicherheitsbestandP3 = 100;
        public int sicherheitsbestandP3e26 = 100;
        public int sicherheitsbestandP3e31 = 100;
        public int sicherheitsbestandP3e16 = 100;
        public int sicherheitsbestandP3e17 = 100;
        public int sicherheitsbestandP3e30 = 100;
        public int sicherheitsbestandP3e6 = 100;
        public int sicherheitsbestandP3e12 = 100;
        public int sicherheitsbestandP3e29 = 100;
        public int sicherheitsbestandP3e9 = 100;
        public int sicherheitsbestandP3e15 = 100;
        public int sicherheitsbestandP3e20 = 100;


        //Periode 1
        public int prognose1P1;
		public int prognose1P2;
		public int prognose1P3;

		public int sb_Prognose1P1;
		public int sb_Prognose1P2;
		public int sb_Prognose1P3;

		//Periode 2
		public int prognose2P1;
		public int prognose2P2;
		public int prognose2P3;

		public int sb_Prognose2P1;
		public int sb_Prognose2P2;
		public int sb_Prognose2P3;

		//Periode 3
		public int prognose3P1;
		public int prognose3P2;
		public int prognose3P3;

		public int sb_Prognose3P1;
		public int sb_Prognose3P2;
		public int sb_Prognose3P3;



        public int sicherheitsFaktor;
    }
}
