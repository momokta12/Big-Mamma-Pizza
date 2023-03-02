using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Slutbrugere
    {
        int _kundeID;
        string _navn;
        string _adresse;



        public Slutbrugere(int KundeID, string navn, string adresse)
        {
            _kundeID = KundeID;
            _navn = navn;
            _adresse = adresse;

        }

        public int kundeID
        {
            get { return _kundeID; }
            set { _kundeID = value; }
        }
        public string navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public override string ToString()
        {
            return $" \nID : {kundeID} \nNavn : {navn} \nAdresse : {adresse}\n";
        }
    }
}
