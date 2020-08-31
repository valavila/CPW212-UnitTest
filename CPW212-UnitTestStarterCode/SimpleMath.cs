﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode
{
    /*****************************************************************************
     * 
     * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
     * 
     * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0 || b == -0)
            {
                throw new ArgumentException($"{nameof(b)} must be a value other than zero");
            }

            return a / b;
        }
    }
}
