using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Pizza
    {
        string _navn;
        string _BrødType;
        string _størrelse;
        int _PizzaId;
        int _pizzaPris;



        public Pizza(string navn, string brødType, string størrelse, int pizzaId, int pizzaPris)
        {
            _navn = navn;
            _BrødType = brødType;
            _størrelse = størrelse;
            _PizzaId = pizzaId;
            _pizzaPris = pizzaPris;
        }

        public string navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string BrødType
        {
            get { return _BrødType; }
            set { _BrødType = value; }
        }

        public string Størrelse
        {
            get { return _størrelse; }
            set { _BrødType = value; }
        }
        public int PizzaId
        {
            get { return _PizzaId; }
            set { _PizzaId = value; }
        }
        public int PizzaPris
        {
            get { return _pizzaPris; }
            set { _pizzaPris = value; }
        }

        public override string ToString()
        { return $"\nPizzabund : {BrødType} \nPizzastørrelse : {Størrelse} \nPizza nummer : {PizzaId} \nPris : {PizzaPris} kr,. \n"; }

    }
}
