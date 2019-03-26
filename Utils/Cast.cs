using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linear.Utils {
public static class Casts {
    // classes
    public static TOut Cast<TIn, TOut>(this TIn obj)
    where TIn : class
        where TOut : class {
        return obj as TOut;
    }

    // sbyte
    public static sbyte Sbyte(this byte n) {
        return (sbyte)n;
    }
    public static sbyte Sbyte(this short n) {
        return (sbyte)n;
    }
    public static sbyte Sbyte(this ushort n) {
        return (sbyte)n;
    }
    public static sbyte Sbyte(this int n) {
        return (sbyte)n;
    }
    public static sbyte Sbyte(this uint n) {
        return (sbyte)n;
    }
    public static sbyte Sbyte(this long n) {
        return (sbyte)n;
    }
    public static sbyte Sbyte(this ulong n) {
        return (sbyte)n;
    }
    public static sbyte Sbyte(this float n) {
        return (sbyte)n;
    }
    public static sbyte Sbyte(this double n) {
        return (sbyte)n;
    }

    // byte
    public static byte Byte(this sbyte n) {
        return (byte)n;
    }
    public static byte Byte(this short n) {
        return (byte)n;
    }
    public static byte Byte(this ushort n) {
        return (byte)n;
    }
    public static byte Byte(this int n) {
        return (byte)n;
    }
    public static byte Byte(this uint n) {
        return (byte)n;
    }
    public static byte Byte(this long n) {
        return (byte)n;
    }
    public static byte Byte(this ulong n) {
        return (byte)n;
    }
    public static byte Byte(this float n) {
        return (byte)n;
    }
    public static byte Byte(this double n) {
        return (byte)n;
    }

    // short
    public static short Short(this sbyte n) {
        return (short)n;
    }
    public static short Short(this byte n) {
        return (short)n;
    }
    public static short Short(this ushort n) {
        return (short)n;
    }
    public static short Short(this int n) {
        return (short)n;
    }
    public static short Short(this uint n) {
        return (short)n;
    }
    public static short Short(this long n) {
        return (short)n;
    }
    public static short Short(this ulong n) {
        return (short)n;
    }
    public static short Short(this float n) {
        return (short)n;
    }
    public static short Short(this double n) {
        return (short)n;
    }

    // ushort
    public static ushort Ushort(this sbyte n) {
        return (ushort)n;
    }
    public static ushort Ushort(this byte n) {
        return (ushort)n;
    }
    public static ushort Ushort(this short n) {
        return (ushort)n;
    }
    public static ushort Ushort(this int n) {
        return (ushort)n;
    }
    public static ushort Ushort(this uint n) {
        return (ushort)n;
    }
    public static ushort Ushort(this long n) {
        return (ushort)n;
    }
    public static ushort Ushort(this ulong n) {
        return (ushort)n;
    }
    public static ushort Ushort(this float n) {
        return (ushort)n;
    }
    public static ushort Ushort(this double n) {
        return (ushort)n;
    }

    // int
    public static int Int(this sbyte n) {
        return (int)n;
    }
    public static int Int(this byte n) {
        return (int)n;
    }
    public static int Int(this short n) {
        return (int)n;
    }
    public static int Int(this ushort n) {
        return (int)n;
    }
    public static int Int(this uint n) {
        return (int)n;
    }
    public static int Int(this long n) {
        return (int)n;
    }
    public static int Int(this ulong n) {
        return (int)n;
    }
    public static int Int(this float n) {
        return (int)n;
    }
    public static int Int(this double n) {
        return (int)n;
    }

    // uint
    public static uint Uint(this sbyte n) {
        return (uint)n;
    }
    public static uint Uint(this byte n) {
        return (uint)n;
    }
    public static uint Uint(this short n) {
        return (uint)n;
    }
    public static uint Uint(this ushort n) {
        return (uint)n;
    }
    public static uint Uint(this int n) {
        return (uint)n;
    }
    public static uint Uint(this long n) {
        return (uint)n;
    }
    public static uint Uint(this ulong n) {
        return (uint)n;
    }
    public static uint Uint(this float n) {
        return (uint)n;
    }
    public static uint Uint(this double n) {
        return (uint)n;
    }

    // long
    public static long Long(this sbyte n) {
        return (long)n;
    }
    public static long Long(this byte n) {
        return (long)n;
    }
    public static long Long(this short n) {
        return (long)n;
    }
    public static long Long(this ushort n) {
        return (long)n;
    }
    public static long Long(this int n) {
        return (long)n;
    }
    public static long Long(this uint n) {
        return (long)n;
    }
    public static long Long(this ulong n) {
        return (long)n;
    }
    public static long Long(this float n) {
        return (long)n;
    }
    public static long Long(this double n) {
        return (long)n;
    }

    // ulong
    public static ulong Ulong(this sbyte n) {
        return (ulong)n;
    }
    public static ulong Ulong(this byte n) {
        return (ulong)n;
    }
    public static ulong Ulong(this short n) {
        return (ulong)n;
    }
    public static ulong Ulong(this ushort n) {
        return (ulong)n;
    }
    public static ulong Ulong(this int n) {
        return (ulong)n;
    }
    public static ulong Ulong(this uint n) {
        return (ulong)n;
    }
    public static ulong Ulong(this long n) {
        return (ulong)n;
    }
    public static ulong Ulong(this float n) {
        return (ulong)n;
    }
    public static ulong Ulong(this double n) {
        return (ulong)n;
    }

    // float
    public static float Float(this sbyte n) {
        return (float)n;
    }
    public static float Float(this byte n) {
        return (float)n;
    }
    public static float Float(this short n) {
        return (float)n;
    }
    public static float Float(this ushort n) {
        return (float)n;
    }
    public static float Float(this int n) {
        return (float)n;
    }
    public static float Float(this uint n) {
        return (float)n;
    }
    public static float Float(this long n) {
        return (float)n;
    }
    public static float Float(this ulong n) {
        return (float)n;
    }
    public static float Float(this double n) {
        return (float)n;
    }

    // double
    public static double Double(this sbyte n) {
        return (double)n;
    }
    public static double Double(this byte n) {
        return (double)n;
    }
    public static double Double(this short n) {
        return (double)n;
    }
    public static double Double(this ushort n) {
        return (double)n;
    }
    public static double Double(this int n) {
        return (double)n;
    }
    public static double Double(this uint n) {
        return (double)n;
    }
    public static double Double(this long n) {
        return (double)n;
    }
    public static double Double(this ulong n) {
        return (double)n;
    }
    public static double Double(this float n) {
        return (double)n;
    }
}
}
