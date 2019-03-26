using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linear.Utils
{
    public static class Bits
    {
        public static void frexp(this double value, out long mantissa, out int exponent)
        {
            // Translate the double into sign, exponent and mantissa.
            long bits = BitConverter.DoubleToInt64Bits(value);
            // Note that the shift is sign-extended, hence the test against -1 not 1
            bool negative = (bits < 0);
            exponent = (int)((bits >> 52) & 0x7ffL);
            mantissa = bits & 0xfffffffffffffL;

            // Bias the exponent. 
            exponent -= 1023;

            if (mantissa == 0)
            {
                return;
            }

            /* Normalize */
            while ((mantissa & 1) == 0)
            {    /*  i.e., Mantissa is even */
                mantissa >>= 1;
                exponent++;
            }
        }

        public static void frexp(this float value, out int mantissa, out int exponent)
        {
            // Translate the float into sign, exponent and mantissa.
            int bits = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
            // Note that the shift is sign-extended, hence the test against -1 not 1
            bool negative = (bits < 0);
            exponent = (bits >> 23) & 0x10;
            mantissa = bits & 0x7FFFFF;

            // Bias the exponent. 
            exponent -= 127;

            if (mantissa == 0)
            {
                return;
            }

            /* Normalize */
            while ((mantissa & 1) == 0)
            {    /*  i.e., Mantissa is even */
                mantissa >>= 1;
                exponent++;
            }
        }

        public static int numBitsSet(this int v)
        {
            int c; // c accumulates the total bits set in v
            for (c = 0; v > 0; c++)
            {
                v &= v - 1; // clear the least significant bit set
            }
            return c;
        }

        public static string ToHexStr(this double value)
        {
            long bits = BitConverter.DoubleToInt64Bits(value);
            return bits.ToString("X16");
        }

        public static string ToHexStr(this float value)
        {
            int bits = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
            return bits.ToString("X8");
        }

        public static double HexStrToDouble(this string str)
        {
            long bits = str.HexStrToLong();
            return BitConverter.Int64BitsToDouble(bits);
        }

        public static float HexStrToFloat(this string str)
        {
            int bits = str.HexStrToInt();
            return BitConverter.ToSingle(BitConverter.GetBytes(bits), 0);
        }

        public static byte[] HexBytesToBytes(this byte[] hexData,  byte[] byteData, int length = -1, 
            int hexOffset = 0, int byteOffset = 0)
        {
            if (length == -1)
            {
                length = (hexData.Length - hexOffset) / 2;
            }

            if (((hexData.Length - hexOffset) / 2 < length) || (byteData.Length - byteOffset < length))
            {
                throw new ArgumentException("Bad array size");
            }

            for (int i = 0; i < length; ++i)
            {
                var nybble1 = hexData[2 * i + hexOffset];
                var nybble2 = hexData[2 * i + 1 + hexOffset];
                byte b;

                if (nybble1 >= '0' && nybble1 <= '9')
                {
                    b =  (byte)(nybble1 - '0');
                }
                else if (nybble1 >= 'A' && nybble1 <= 'F')
                {
                    b = (byte)(nybble1 - 'A' + 10); 
                }
                else if (nybble1 >= 'a' && nybble1 <= 'f')
                {
                    b = (byte)(nybble1 - 'a' + 10);
                }
                else
                {
                    throw new ArgumentException(nybble1 + " is not a valid hex character");
                }

                if (nybble2 >= '0' && nybble2 <= '9')
                {
                    byteData[i + byteOffset] = (byte)((nybble2 - '0') | (b << 4));
                }
                else if (nybble2 >= 'A' && nybble2 <= 'F')
                {
                    byteData[i + byteOffset] = (byte)((nybble2 - 'A' + 10) | (b << 4));
                }
                else if (nybble2 >= 'a' && nybble2 <= 'f')
                {
                    byteData[i + byteOffset] = (byte)((nybble2 - 'a' + 10) | (b << 4));
                }
                else
                {
                    throw new ArgumentException(nybble2 + " is not a valid hex character");
                }
            }
            return byteData;
        }

        public static byte HexCharToNyble(this char hexChar)
        {
            if (hexChar >= '0' && hexChar <= '9') { return (byte)(hexChar - '0'); }
            if (hexChar >= 'A' && hexChar <= 'F') { return (byte)(hexChar - 'A' + 10); }
            if (hexChar >= 'a' && hexChar <= 'f') { return (byte)(hexChar - 'a' + 10); }
            throw new ArgumentException(hexChar + " is not a valid hex character");
        }

        public static byte HexStrToByte(this string hexStr)
        {
            int x = hexStr[1].HexCharToNyble();
            return (byte)(x | (hexStr[0].HexCharToNyble() << 4));
        }

        public static short HexStrToShort(this string hexStr)
        {
            int x = HexCharToNyble(hexStr[3]);
            x |= HexCharToNyble(hexStr[2]) << 4;
            x |= HexCharToNyble(hexStr[1]) << 8;
            x |= HexCharToNyble(hexStr[0]) << 12;
            return (short)x;
        }

        public static ushort HexStrToUShort(string hexStr)
        {
            int x = hexStr[3].HexCharToNyble();
            x |= hexStr[2].HexCharToNyble() << 4;
            x |= hexStr[1].HexCharToNyble() << 8;
            x |= hexStr[0].HexCharToNyble() << 12;
            return (ushort)x;
        }

        public static int HexStrToInt(this string hexStr)
        {
            int x = hexStr[7].HexCharToNyble();
            x |= hexStr[6].HexCharToNyble() << 4;
            x |= hexStr[5].HexCharToNyble() << 8;
            x |= hexStr[4].HexCharToNyble() << 12;
            
            x |= hexStr[3].HexCharToNyble() << 16;
            x |= hexStr[2].HexCharToNyble() << 20;
            x |= hexStr[1].HexCharToNyble() << 24;
            x |= hexStr[0].HexCharToNyble() << 28;
            return x;
        }

        public static uint HexStrToUInt(this string hexStr)
        {
            return (uint)hexStr.HexStrToInt();
        }

        public static ulong HexStrToULong(this string hexStr)
        {
            ulong x1 = hexStr.Substring(0, 8).HexStrToUInt();
            ulong x2 = hexStr.Substring(8, 8).HexStrToUInt();
            return x2 | (x1 << 32);
        }

        public static long HexStrToLong(this string hexStr)
        {
            return (long)hexStr.HexStrToULong();
        }

        static readonly int[] MultiplyDeBruijnBitPosition = 
        {
            0, 1, 28, 2, 29, 14, 24, 3, 30, 22, 20, 15, 25, 17, 4, 8, 
            31, 27, 13, 23, 21, 19, 16, 7, 26, 12, 18, 6, 11, 5, 10, 9
        };

        public static int Log2(this int v)
        {
            // handle cases where algorithm won't fit in an int32
            if ((uint)v >= (1U << 30))
            {
                if ((uint)v >= (1U << 31))
                {
                    return 31;
                }
                return 30;
            }
            
            // make power of two then divide by 2 to get get highest power of 2 less than original v
            v = MakePowerOfTwo(v) / 2;

            // do the same look up as for the known power of two
            return MultiplyDeBruijnBitPosition[(uint)(v * 0x077CB531U) >> 27];
        }

        public static int MakePowerOfTwo(this int v)
        {
            // make one less than power of two
            v |= v >> 1;
            v |= v >> 2;
            v |= v >> 4;
            v |= v >> 8;
            v |= v >> 16;

            return v + 1;
        }

        // can only use this if we know v is power of two
        public static int Log2Fast(this int vAsPowerOfTwo)
        {
            return MultiplyDeBruijnBitPosition[(uint)(vAsPowerOfTwo * 0x077CB531U) >> 27];
        }

        public static int Exp2(this int v)
        {
            return 1 << v;
        }

        public static bool IsPowerOf2(this int v)
        {
            return v > 0 && (((v >> 1) & v) == 0);
        }

        public static byte SetBit(this byte val, int index, bool setBit = true)
        {
            if (setBit)
            {
                return (byte)(val | (1 << index));
            }
            else
            {
                return (byte)(val & ~(1 << index));
            }
        }

        public static byte ClearBit(this byte val, int index)
        {
            return (byte)(val & ~(1 << index));
        }

        public static bool GetBit(this byte val, int index)
        {
            return (val & (1 << index)) != 0;
        }
    }
}
