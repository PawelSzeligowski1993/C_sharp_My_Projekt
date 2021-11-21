using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Polonez : Car
    {
        public int pyrkiAmount { get; set; }
        public Polonez(Type_Engine type_Engine, double capacityEngine, double enginePower, int personsAmount,
           int doorsAmount, int yearOfProdution, double price, int pyrki) : base(type_Engine, capacityEngine, enginePower, personsAmount,
               doorsAmount, yearOfProdution, price)
        {
            this.pyrkiAmount = pyrki;
        }

        public void IntroduceSelf()
        {
            Console.WriteLine($"Hello my name is Polonez Caro and this are my parameters: " +
                $"type_Engine {type_Engine}"+
                $"Capacity Engine {capacityEngine}" +
                $"Engine Power {enginePower}" +
                $"Persons Amount {personsAmount}" +
                $"Doors Amount {doorsAmount}" +
                $"Year Of Prodution {yearOfProduction}" +
                $"Price {price}" +
                $"Pyrki {pyrkiAmount}"
               );
        }
    }
}

/*
 * Type_Engine type_Engine, double capacityEngine, double enginePower, int personsAmount,
           int doorsAmount, int yearOfProdution, double price
 * */
