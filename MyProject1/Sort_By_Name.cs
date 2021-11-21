using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MyProject1
{
    class Sort_By_Name : IComparer<VW_Golf>
    {


        public int Compare(VW_Golf x, VW_Golf y)
        {
            return x.generations.CompareTo(y.generations);
        }
    }
}
