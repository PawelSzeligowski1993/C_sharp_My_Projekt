using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    /*
 * TODO 
 * Automatick gearbox
 * Front AUTOMATIC system Window 
 * REAR AUTOMATIC system Window 
 * sunroof
 * small trunk
 */
    class VW_Trock
    {
        public string model;// = "VW Trock";
        Type_Engine type_Engine { get; set; }
        public double capacityEngine { get; set; }
        public int personsAmount { get; set; }
        public int doorsAmount { get; set; }
        public int yearOfProduction { get; set; }
        public double price { get; set; }

        public VW_Trock(double capacityEngine, int doorsAmount, int yearOfProduction, double price)
        {
            this.model = "VW Trock";
            this.type_Engine = Type_Engine.Petrol;
            this.capacityEngine = capacityEngine;
            this.personsAmount = 5;
            this.doorsAmount = doorsAmount;
            this.yearOfProduction = yearOfProduction;
            this.price = price;

        }
    }
}
