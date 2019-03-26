using System;
using System.Collections.Generic;
//using Linear.RandMT;

namespace Linear.Utils
{
    public static class Arrays
    {
        public static T[] ToArray<T>(this ICollection<T> values)
        {
            var outValues = new T[values.Count];
            values.CopyTo(outValues, 0);
            return outValues;
        }
        
        public static T[] Subset<T>(this T[] data, ICollection<int> indices)
        {
            var subset = new T[indices.Count];
            int i = 0;
            foreach (var idx in indices)
            {
                subset[i] = data[idx];
                ++i;
            }
            return subset;
        }

        public static T[] subset<T>(this T[] data, int beg, int end)
        {
            var subset = new T[end - beg];
            for (int i = 0; i < end - beg; ++i)
            {
                subset[i] = data[i + beg];
            }
            return subset;
        }

        public static T Last<T>(this T[] data)
        {
            return data[data.Length - 1];
        }

        public static OutType[] CastArray<OutType, InType>(this InType[] values)
        {
            int size = values.Length;
            var output = new OutType[size];
            for (int i = 0; i < size; ++i)
            {
                output[i] = (OutType)Convert.ChangeType(values[i], typeof(OutType));
            }
            return output;
        }

        public static T[] Sort<T>(this T[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public static T[] Sort<T>(this T[] arrIn, T[] arrOut)
        {
            if (arrIn.Length > arrOut.Length)
            {
                throw new ArgumentException("arrOut must be at least as long as arrIn");
            }
            arrIn.CopyTo(arrOut, 0);
            Array.Sort(arrOut);
            return arrOut;
        }

        public static int IndexOfLargestItemLessThanX<T>(this T[] data, T x, 
            bool ascending = true)
        {
            int len = data.Length;
            if (len == 0) { return -2; }
            if (ascending)
            {
                if (Comparer<T>.Default.Compare(x, data[0]) < 0) { return -1; }
                if (Comparer<T>.Default.Compare(x, data[len - 1]) >= 0) { return len - 1; }
            }
            else
            {
                if (Comparer<T>.Default.Compare(x, data[len - 1]) < 0) { return -1; }
                if (Comparer<T>.Default.Compare(x, data[0]) >= 0) { return len - 1; }
            }
            if (len == 2) { return 0; }
            return binarySearch(data, 0, len - 1, x, ascending);
        }

        private static int binarySearch<T>(T[] data, int minIdx, int maxIdx, T x,
            bool ascending)
        {
            int xIdx = (minIdx + maxIdx) / 2;
            if (ascending)
            {
                if (Comparer<T>.Default.Compare(data[xIdx], x) <= 0)
                {
                    if (Comparer<T>.Default.Compare(data[xIdx + 1], x) > 0) { return xIdx; }

                    minIdx = xIdx;
                }
                else
                {
                    maxIdx = xIdx;
                }
            }
            else
            {
                if (Comparer<T>.Default.Compare(data[xIdx + 1], x) <= 0)
                {
                    if (Comparer<T>.Default.Compare(data[xIdx], x) > 0) { return xIdx; }

                    maxIdx = xIdx;
                }
                else
                {
                    minIdx = xIdx;
                }
            }
            return binarySearch(data, minIdx, maxIdx, x, ascending);
        }

        public static T[] Add<T, C>(this T[] a, T[] b) 
            where C : IArith<T>, new()
        {
            int n = a.Length;
            if (b.Length != n)
            {
                throw new ArgumentException("Length of input arrays must be the same");
            }
            var c = new C();
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Add(a[i], b[i]);
            }
            return newValues;
        }

        public static T[] Subtract<T, C>(this T[] a, T[] b) 
            where C : IArith<T>, new()
        {
            int n = a.Length;
            if (b.Length != n)
            {
                throw new ArgumentException("Length of input arrays must be the same");
            }
            var c = new C();
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Sub(a[i], b[i]);
            }
            return newValues;
        }

        public static T[] Multiply<T, C>(this T[] a, T[] b) 
            where C : IArith<T>, new()
        {
            int n = a.Length;
            if (b.Length != n)
            {
                throw new ArgumentException("Length of input arrays must be the same");
            }
            var c = new C();
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Mult(a[i], b[i]);
            }
            return newValues;
        }

        public static T[] Divide<T, C>(this T[] a, T[] b) 
            where C : IArith<T>, new()
        {
            int n = a.Length;
            if (b.Length != n)
            {
                throw new ArgumentException("Length of input arrays must be the same");
            }
            var c = new C();
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Div(a[i], b[i]);
            }
            return newValues;
        }

        public static T[] Mod<T, C>(this T[] a, T[] b) 
            where C : IArith<T>, new()
        {
            int n = a.Length;
            if (b.Length != n)
            {
                throw new ArgumentException("Length of input arrays must be the same");
            }
            var c = new C();
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Mod(a[i], b[i]);
            }
            return newValues;
        }

        public static T[] Add<T, C>(this T[] values, T offset)
            where C : IArith<T>, new()
        {
            var c = new C();
            int n = values.Length;
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Add(values[i], offset);
            }
            return newValues;
        }

        public static T[] Subtract<T, C>(this T[] values, T offset)
            where C : IArith<T>, new()
        {
            var c = new C();
            int n = values.Length;
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Sub(values[i], offset);
            }
            return newValues;
        }

        public static T[] Multiply<T, C>(this T[] values, T offset)
            where C : IArith<T>, new()
        {
            var c = new C();
            int n = values.Length;
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Mult(values[i], offset);
            }
            return newValues;
        }

        public static T[] Divide<T, C>(this T[] values, T offset)
            where C : IArith<T>, new()
        {
            var c = new C();
            int n = values.Length;
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Div(values[i], offset);
            }
            return newValues;
        }

        public static T[] Mod<T, C>(this T[] values, T offset)
            where C : IArith<T>, new()
        {
            var c = new C();
            int n = values.Length;
            T[] newValues = new T[n];
            for (int i = 0; i < n; ++i)
            {
                newValues[i] = c.Mod(values[i], offset);
            }
            return newValues;
        }
    }

    public interface IArith<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Mult(T a, T b);
        T Div(T a, T b);
        T Mod(T a, T b);
    }

    public struct FloatArith : IArith<float>
    {
        public float Add(float a, float b) { return a + b; }
        public float Sub(float a, float b) { return a - b; }
        public float Mult(float a, float b) { return a * b; }
        public float Div(float a, float b) { return a / b; }
        public float Mod(float a, float b) { return a - (float)Math.Floor(a / b) * b; }
    }

    public struct DoubleArith : IArith<double>
    {
        public double Add(double a, double b) { return a + b; }
        public double Sub(double a, double b) { return a - b; }
        public double Mult(double a, double b) { return a * b; }
        public double Div(double a, double b) { return a / b; }
        public double Mod(double a, double b) { return a - (double)Math.Floor(a / b) * b; }
    }

    public struct IntArith : IArith<int>
    {
        public int Add(int a, int b) { return a + b; }
        public int Sub(int a, int b) { return a - b; }
        public int Mult(int a, int b) { return a * b; }
        public int Div(int a, int b) { return a / b; }
        public int Mod(int a, int b) { return a % b; }
    }

    public struct UIntArith : IArith<uint>
    {
        public uint Add(uint a, uint b) { return a + b; }
        public uint Sub(uint a, uint b) { return a - b; }
        public uint Mult(uint a, uint b) { return a * b; }
        public uint Div(uint a, uint b) { return a / b; }
        public uint Mod(uint a, uint b) { return a % b; }
    }

    public struct LongArith : IArith<long>
    {
        public long Add(long a, long b) { return a + b; }
        public long Sub(long a, long b) { return a - b; }
        public long Mult(long a, long b) { return a * b; }
        public long Div(long a, long b) { return a / b; }
        public long Mod(long a, long b) { return a % b; }
    }

    public struct ULongArith : IArith<ulong>
    {
        public ulong Add(ulong a, ulong b) { return a + b; }
        public ulong Sub(ulong a, ulong b) { return a - b; }
        public ulong Mult(ulong a, ulong b) { return a * b; }
        public ulong Div(ulong a, ulong b) { return a / b; }
        public ulong Mod(ulong a, ulong b) { return a % b; }
    }

    public struct SByteArith : IArith<sbyte>
    {
        public sbyte Add(sbyte a, sbyte b) { return (sbyte)(a + b); }
        public sbyte Sub(sbyte a, sbyte b) { return (sbyte)(a - b); }
        public sbyte Mult(sbyte a, sbyte b) { return (sbyte)(a * b); }
        public sbyte Div(sbyte a, sbyte b) { return (sbyte)(a / b); }
        public sbyte Mod(sbyte a, sbyte b) { return (sbyte)(a % b); }
    }

    public struct ByteArith : IArith<byte>
    {
        public byte Add(byte a, byte b) { return (byte)(a + b); }
        public byte Sub(byte a, byte b) { return (byte)(a - b); }
        public byte Mult(byte a, byte b) { return (byte)(a * b); }
        public byte Div(byte a, byte b) { return (byte)(a / b); }
        public byte Mod(byte a, byte b) { return (byte)(a % b); }
    }

    public struct Int16Arith : IArith<Int16>
    {
        public Int16 Add(Int16 a, Int16 b) { return (Int16)(a + b); }
        public Int16 Sub(Int16 a, Int16 b) { return (Int16)(a - b); }
        public Int16 Mult(Int16 a, Int16 b) { return (Int16)(a * b); }
        public Int16 Div(Int16 a, Int16 b) { return (Int16)(a / b); }
        public Int16 Mod(Int16 a, Int16 b) { return (Int16)(a % b); }
    }

    public struct UInt16Arith : IArith<UInt16>
    {
        public UInt16 Add(UInt16 a, UInt16 b) { return (UInt16)(a + b); }
        public UInt16 Sub(UInt16 a, UInt16 b) { return (UInt16)(a - b); }
        public UInt16 Mult(UInt16 a, UInt16 b) { return (UInt16)(a * b); }
        public UInt16 Div(UInt16 a, UInt16 b) { return (UInt16)(a / b); }
        public UInt16 Mod(UInt16 a, UInt16 b) { return (UInt16)(a % b); }
    }

    public struct Int32Arith : IArith<Int32>
    {
        public Int32 Add(Int32 a, Int32 b) { return a + b; }
        public Int32 Sub(Int32 a, Int32 b) { return a - b; }
        public Int32 Mult(Int32 a, Int32 b) { return a * b; }
        public Int32 Div(Int32 a, Int32 b) { return a / b; }
        public Int32 Mod(Int32 a, Int32 b) { return a % b; }
    }

    public struct UInt32Arith : IArith<UInt32>
    {
        public UInt32 Add(UInt32 a, UInt32 b) { return a + b; }
        public UInt32 Sub(UInt32 a, UInt32 b) { return a - b; }
        public UInt32 Mult(UInt32 a, UInt32 b) { return a * b; }
        public UInt32 Div(UInt32 a, UInt32 b) { return a / b; }
        public UInt32 Mod(UInt32 a, UInt32 b) { return a % b; }
    }

    public struct Int64Arith : IArith<Int64>
    {
        public Int64 Add(Int64 a, Int64 b) { return a + b; }
        public Int64 Sub(Int64 a, Int64 b) { return a - b; }
        public Int64 Mult(Int64 a, Int64 b) { return a * b; }
        public Int64 Div(Int64 a, Int64 b) { return a / b; }
        public Int64 Mod(Int64 a, Int64 b) { return a % b; }
    }

    public struct UInt64Arith : IArith<UInt64>
    {
        public UInt64 Add(UInt64 a, UInt64 b) { return a + b; }
        public UInt64 Sub(UInt64 a, UInt64 b) { return a - b; }
        public UInt64 Mult(UInt64 a, UInt64 b) { return a * b; }
        public UInt64 Div(UInt64 a, UInt64 b) { return a / b; }
        public UInt64 Mod(UInt64 a, UInt64 b) { return a % b; }
    }
}
