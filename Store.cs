using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamma
{
    public class Store
    {
        string _Adresse;
        string _kontaktInfo;
        int _CVR;

        public Store(string Adresse, string kontaktInfo, int CVR)
        {
            _Adresse = Adresse;
            _CVR = CVR;
            _kontaktInfo = kontaktInfo;
        }

        public string Adresse
        {
            get { return _Adresse; }
            set { _Adresse = value; }
        }
        public string Kontaktinfo
        {
            get { return _kontaktInfo; }
            set { _kontaktInfo = value; }
        }
        public int CVR
        {
            get { return _CVR; }
            set { _CVR = value; }
        }

        public override string ToString()
        {
            return $"{Adresse} {Kontaktinfo} {CVR}";
        }
        public void start()
        {
            Pizza pizza1 = new Pizza("El Capitan", "Glutenfri", "Alm", 1, 89);
            Pizza pizza2 = new Pizza("El Matador", "FuldKorn", "Alm", 2, 71);
            Pizza pizza3 = new Pizza("El Capron", "DurumMel", "Familie", 3, 119);

            Drikkevare drikke1 = new Drikkevare("Gazoz", "lille", 1, 18);
            Drikkevare drikke2 = new Drikkevare("Ayran", "mellem", 2, 11);
            Drikkevare drikke3 = new Drikkevare("Brolean", "stor", 3, 50);

            Slutbrugere slutbrugere1 = new Slutbrugere(1, "Alex", "Dea trier mørchs vej 9, 2th 2300");
            Slutbrugere slutbrugere2 = new Slutbrugere(2, "Mufasa", "Nylandsvej 13, 2100");
            Slutbrugere slutbrugere3 = new Slutbrugere(3, "Sofiana", "kgs. Henriks lars jensens abu-obama's gade 1");

            Order order1 = new Order(1, pizza1, drikke1, slutbrugere1);
            Order order2 = new Order(2, pizza2, drikke2, slutbrugere2);
            Order order3 = new Order(3, pizza3, drikke3, slutbrugere3);


            Console.WriteLine($"Order 1: \n{order1}\n");

            Console.WriteLine($"Den totalepris er inkl. Moms/Levering {order1.CalculateTotalPrice(pizza1, drikke1, slutbrugere1)}\n--------------------------------------------------------");

            Console.WriteLine($"Order 2: \n{order2}\n");

            Console.WriteLine($"Den totalepris er inkl. Moms/Levering {order2.CalculateTotalPrice(pizza2, drikke2, slutbrugere2)}\n--------------------------------------------------------");

            Console.WriteLine($"Order 3: \n{order3}\n");

            Console.WriteLine($"Den totalepris er inkl. Moms/Levering {order3.CalculateTotalPrice(pizza3, drikke3, slutbrugere3)}\n--------------------------------------------------------");

            Console.WriteLine($"Tak for du har valgt *Big Mamma pizza* \nAdresse :  {Adresse} \nNavn :  {Kontaktinfo} \nCVR :  {CVR}\n-----------------------------------------------");
        }
    }
}
