using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Drikkevare
    {
        string _navn;
        string _størrelse;
        int _drikkevareID;
        int _drikkePris;

        // Constructor - sammensæt variablerne 
        public Drikkevare(string navn, string størrelse, int drikkevareID, int drikkePris)
        {
            _navn = navn;
            _størrelse = størrelse;
            _drikkevareID = drikkevareID;
            _drikkePris = drikkePris;
        }

        // properties - hent og giv variablerne værdi
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Størrelse
        {
            get { return _størrelse; }
            set { _størrelse = value; }
        }
        public int DrikkevareID
        {
            get { return _drikkevareID; }
            set { _drikkevareID = value; }
        }
        public int DrikkePris
        {
            get { return _drikkePris; }
            set { _drikkePris = value; }
        }


        // methodes - giv variablerne en funktion!
        public override string ToString()
        { return $"\nNavn : {Navn} \nStørrelse : {Størrelse} \nNummer : {DrikkevareID} \nPris : {DrikkePris} kr,. \n"; }
        //Tostring-  retunere string af properties some inkl. værdien af Attributes.

    }
}

