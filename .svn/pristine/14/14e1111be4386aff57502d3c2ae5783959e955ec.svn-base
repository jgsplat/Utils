using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linear.Utils;

namespace TestArrayCast
{
    class Program
    {
        static void Main(string[] args)
        {
            var dArr = new double[] { 0.0, 1.0, 2.0, 3.0, 9.0, 10.0, 25.0, 74.0, 120.0, 
                160.0, 200.0, 255.0 };
            var bArr = dArr.CastArray<byte, double>();

            Console.WriteLine(bArr[0].GetType());
            
            foreach (var b in bArr)
            {
                Console.WriteLine(b);
            }

            var iArr1 = bArr.CastArray<int, byte>();
            var iArr2 = dArr.CastArray<int, double>();

            var iArr3 = iArr1.Add<int, IntArith>(iArr2);

            Console.WriteLine('\n' + iArr3[0].GetType().ToString());

            foreach (var i in iArr3)
            {
                Console.WriteLine(i);
            }

            double pi = 3.141592653589793; // 400921FB54442D18

            Console.WriteLine("(double)" + pi + " should be 400921FB54442D18, is " + pi.ToHexStr());
            Console.WriteLine("(float)" + (float)pi + " should be 40490FDB, is " + ((float)pi).ToHexStr());

            Console.WriteLine("pi = " + "400921FB54442D18".HexStrToDouble());
            Console.WriteLine("pi = " + "40490FDB".HexStrToFloat());

            ulong lval = 0x0123456789ABCDEF;
            Console.WriteLine("Expected {0:X16}, got {1:X16}", lval, "0123456789ABCDEF".HexStrToULong());
            long val = -81985529216486896;
            Console.WriteLine("Expected {0:X16}, got {1:X16}", val, "FEDCBA9876543210".HexStrToLong());
        }
    }
}
