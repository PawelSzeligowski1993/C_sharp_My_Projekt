using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    public abstract class Car
    {
        public Type_Engine type_Engine { get; set; }
        public double capacityEngine { get; set; }
        public double enginePower { get; set; }
        public int personsAmount { get; set; }
        public int doorsAmount { get; set; }
        public int yearOfProduction { get; set; }
        public double price { get; set; }

        public Car(Type_Engine type_Engine, double capacityEngine, double enginePower, int personsAmount,
           int doorsAmount, int yearOfProduction, double price)
        {
            this.type_Engine = type_Engine;
            this.capacityEngine = capacityEngine;
            this.enginePower = enginePower;
            this.personsAmount = personsAmount;
            this.doorsAmount = doorsAmount;
            this.yearOfProduction = yearOfProduction;
            this.price = price;
        }
    }




}
