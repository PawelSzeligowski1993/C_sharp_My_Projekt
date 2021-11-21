using System;
using System.Collections.Generic;
using System.Text;
/*
* TODO 
* Manual gearbox
* Front AUTOMATIC system Window 
* large trunk
* 
*/
namespace MyProject1
{
    class VW_Transporter
    {
        public string model;// = "VW Transporter";
        Type_Engine type_Engine { get; set; }
        public double capacityEngine { get; set; }
        public double enginePower { get; set; }
        public int personsAmount { get; set; }
        public int doorsAmount { get; set; }
        public int yearOfProduction { get; set; }
        public double price { get; set; }

        public VW_Transporter(double capacityEngine, double enginePower, int yearOfProduction, double price)
        {
            this.model = "VW Transporter";
            this.type_Engine = Type_Engine.Diesel;
            this.capacityEngine = capacityEngine;
            this.enginePower = enginePower;
            this.personsAmount = 2;
            this.doorsAmount = 4;
            this.yearOfProduction = yearOfProduction;
            this.price = price;

        }
    }
}
