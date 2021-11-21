/*
using System;

namespace MyProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            VW_Golf vW_Golf = new VW_Golf(Type_Engine.Diesel, 2.5, 1.6, 3, 2001, 4000);
            
            for(int i=0; i<8; i++)
            {
                vW_Golf.Manual_gearbox(i);
            }



            bool k = false;     //button_Open
            bool d = false;     //button_Close
            bool e = false;     //IsOpen
            bool f = false;     //IsClose 

            for (int j = 0; j < 8; j++)
            {
                switch (j)
                {
                    case 1:
                        k = true;
                        d = false;
                        e = false;
                        f = false;
                        break;
                    case 2:
                        k = false;
                        d = false;
                        e = true;
                        f = false;
                        break;
                    case 3:
                        k = false;
                        d = true;
                        e = false;
                        f = false;
                        break;
                    case 4:
                        k = false;
                        d = false;
                        e = false;
                        f = true;
                        break;
                    default:
                        k = false;
                        d = false;
                        e = false;
                        f = false;
                        break;
                }
                vW_Golf.Front_AUTOMATIC_Window(k, d, e, f);
            }

            Console.ReadLine();


        }
    }
}
*/ 