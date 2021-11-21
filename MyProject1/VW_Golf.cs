using System;
using System.Collections.Generic;
using System.Text;
/*
 * TODO
 * Manual gearbox
 * Front AUTOMATIC system Window 
 * REAR AUTOMATIC system Window 
 * Sunroof
 * small trunk
 * Petrol engine
 */
namespace MyProject1
{
    class VW_Golf : I1_Manual_gearbox, Interface3_Front_AUTOMATIC_Window, Interface4_REAR_AUTOMATIC_Window, IComparable<VW_Golf>
    {
        public string model;// = "VW GOLF";
        public string generations { get; set; }
        Type_Engine type_Engine { get; set; }
        public double capacityEngine { get; set; }
        public double enginePower { get; set; }
        public int personsAmount { get; set; }
        public int doorsAmount { get; set; }
        public int yearOfProduction { get; set; }
        public double price { get; set; }

        public VW_Golf (string generations, Type_Engine type_Engine, double capacityEngine, double enginePower, int doorsAmount, int yearOfProduction, double price)
        {
            this.model = "VW GOLF";
            this.generations = generations;
            this.type_Engine = type_Engine;
            this.capacityEngine = capacityEngine;
            this.enginePower = enginePower;
            this.personsAmount = 5;
            this.doorsAmount = doorsAmount;
            this.yearOfProduction = yearOfProduction;
            this.price = price;
        }

        public int CompareTo(VW_Golf other)
        {
            return this.price.CompareTo(other.price);
        }



        public override string ToString()
        {
            string vw = $"{this.model},{this.type_Engine},{this.capacityEngine},{this.enginePower},{this.personsAmount}," +
                $"{this.doorsAmount},{this.yearOfProduction},{this.price}";
            return vw;
        }

        public void Manual_gearbox(int gear)
        {
            switch (gear)
            {
                case 1:
                    Console.WriteLine(model+" Gear = 1");
                    break;
                case 2:
                    Console.WriteLine(model + " Gear = 2");
                    break;
                case 3:
                    Console.WriteLine(model + " Gear = 3");
                    break;
                case 4:
                    Console.WriteLine(model + " Gear = 4");
                    break;
                case 5:
                    Console.WriteLine(model + " Gear = 5");
                    break;
                case 6:
                    Console.WriteLine(model + " Gear = R");
                    break;
                default:
                    Console.WriteLine(model + " Gear = N");
                    break;
            }
        }

        public void Front_AUTOMATIC_Window(bool button_Open, bool button_Close, bool IsOpen, bool IsClose)
        {
            if(button_Open && !button_Close && !IsOpen)
            {
                Console.WriteLine(model + " Your Front Window is opening now ");
            }else if(!button_Open && !button_Close && IsOpen && !IsClose)
            {
                Console.WriteLine(model + " Your Front Window is open now ");
            }
            else if (!button_Open && button_Close &&!IsClose)
            {
                Console.WriteLine(model + " Your Front Window is closing now ");
            }
            else if (!button_Open && !button_Close && !IsOpen && IsClose)
            {
                Console.WriteLine(model + " Your Front Window is close now ");
            }
            else if (!button_Open && !button_Close && !IsOpen && !IsClose)
            {
                Console.WriteLine(model + " Your Rear Window is open ");
            }
            else
            {
                Console.WriteLine(model + "Your Front Window is in Fault and need Service");
            }
        }

        public void REAR_AUTOMATIC_Window(bool button_Open, bool button_Close, bool IsOpen, bool IsClose)
        {
            if (button_Open && !button_Close && !IsOpen)
            {
                Console.WriteLine(model + " Your Rear Window is opening now ");
            }
            else if (!button_Open && !button_Close && IsOpen && !IsClose)
            {
                Console.WriteLine(model + " Your Rear Window is open now ");
            }
            else if (!button_Open && button_Close && !IsClose)
            {
                Console.WriteLine(model + " Your Rear Window is closing now ");
            }
            else if (!button_Open && !button_Close && !IsOpen && IsClose)
            {
                Console.WriteLine(model + " Your Rear Window is close now ");
            }
            else if (!button_Open && !button_Close && !IsOpen && !IsClose)
            {
                Console.WriteLine(model + " Your Rear Window is open ");
            }
            else 
            {
                Console.WriteLine(model + " Your Rear Window is in Fault and need Service");
            }
        }
    }
}

