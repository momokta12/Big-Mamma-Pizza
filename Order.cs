using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{ 
 public class Order
{
    int _OrderId;
    double _tax = 1.25;
    int _leveringFee = 40;
    Pizza _pizza;
    Slutbrugere _slutbrugere;
    Drikkevare _drikkevare;


    

    public Order(int odreid, Pizza pizza, Drikkevare drikkevare, Slutbrugere slutbrugere)
    {
        _OrderId = odreid;
        _pizza = pizza;
        _slutbrugere = slutbrugere;
        _drikkevare = drikkevare;


    }

    public int Orderid
    {
        get { return _OrderId; }
        set { _OrderId = value; }
    }
    public double Tax
    {
        get { return _tax; }
        set { _tax = value; }
    }
    public int LeveringFee
    {
        get { return _leveringFee; }
        set { _leveringFee = value; }
    }


    public override string ToString()
    { return $"{_pizza}\nOrderID : {Orderid}\nSkat : {Tax} \nLeveringsomkostninger : {LeveringFee} {_drikkevare} {_slutbrugere}"; }

    public double CalculateTotalPrice(Pizza pizza, Drikkevare drikkevare, Slutbrugere slutbrugere)
    {
        return (pizza.PizzaPris + drikkevare.DrikkePris + _leveringFee) * _tax;
    }

}

}
