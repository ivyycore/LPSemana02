﻿using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            sbyte sbMax = sbyte.MaxValue;
            sbyte sbMin = sbyte.MinValue;
            byte bMax = byte.MaxValue;
            byte bMin = byte.MinValue;
            double dbMin = double.MinValue;
            double dbMax = double.MaxValue;
            float fMax = float.MaxValue;
            float fMin = float.MinValue;
            ulong ulMax = ulong.MaxValue;
            ulong ulMin = ulong.MinValue;
            long lMax = long.MaxValue;
            long lMin = long.MinValue;
            int iMax = int.MaxValue;
            int iMin = int.MinValue;
            uint uiMax = uint.MaxValue;
            uint uiMin = uint.MinValue;

            Console.WriteLine($"{sbMax}\n{sbMin}\n{bMax}\n{bMin}\n{dbMax}\n{dbMin}\n{fMax}\n{fMin}\n{ulMax}\n{ulMin}\n{lMax}\n{lMin}\n{iMax}\n{iMin}\n{uiMax}\n{uiMin}");
            
            double a = double.PositiveInfinity;
            double b = double.NegativeInfinity;
            float a1 = float.PositiveInfinity;
            float b1 = float.NegativeInfinity;
            float c = float.NaN;

            Console.WriteLine($"{a}\n{b}\n{a1}\n{b1}\n{c}");
            
            uint overU = uint.MaxValue;
            uint resultU = overU+1;
            Console.WriteLine(resultU);
            
            float ab = 2*float.MaxValue;
            float bd = float.MaxValue + 1;
            Console.WriteLine($"{ab}\n{bd}");

            float underF1, underF2;
            underF1 = underF2 = 10000.0f;
            Console.WriteLine(underF1 == underF2 + 0.0001f);
        }
    }
}