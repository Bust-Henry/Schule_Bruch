using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bruch
{
    class Bruch
    {
        //Attribute
        private int zaehler;
        private int nenner;


        //Konstruktoren
        public Bruch(int zaehler, int nenner)
        {
            this.setZaehler(zaehler);
            this.setNenner(nenner);
        }


        //Selektoren
        public int getZaehler()
        {
            return zaehler;
        }
        public void setZaehler(int zaehler)
        {
            this.zaehler = zaehler;
        }
        public int getNenner()
        {
            return nenner;
        }
        public void setNenner(int nenner)
        {
            this.nenner = nenner;
        }

        //Funktionen
        public void addieren(Bruch bruch)
        {

        }

        public void subtrahieren(Bruch bruch)
        {

        }

        public void dividieren(Bruch bruch)
        {

        }
        public void multiplizieren(Bruch bruch)
        {

        }
        public void kuerzen()
        {

        }
    }
}