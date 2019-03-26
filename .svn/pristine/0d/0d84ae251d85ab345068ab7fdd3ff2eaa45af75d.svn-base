using System;
using System.Windows.Forms;

namespace Linear.Utils
{
    public static class Signal
    {
        public static double Hz(this string value)
        {
            string[] valUnits = value.Split(' ');
            if (valUnits.Length == 1)
            {
                return double.Parse(value.Trim());
            }
            else
            {
                double val = double.Parse(valUnits[0].Trim());
                string units = valUnits[1].Trim().ToLower();
                if (units == "ghz")
                {
                    val *= 1e9;
                }
                else if (units == "mhz")
                {
                    val *= 1e6;
                }
                else if (units == "khz")
                {
                    val *= 1e3;
                }
                else if (units == "hz")
                {
                    // ok
                }
                else
                {
                    throw new FormatException("Unrecognized units (" + units + ")");
                }
                return val;
            }
        }

        public static bool TryHz(this string stringValue, out double doubleValue)
        {
            string[] valUnits = stringValue.Split(' ');
            if (valUnits.Length == 1)
            {
                return double.TryParse(stringValue.Trim(), out doubleValue);
            }
            else
            {
                if (!double.TryParse(valUnits[0].Trim(), out doubleValue))
                {
                    return false;
                }
                string units = valUnits[1].Trim().ToLower();
                if (units == "ghz")
                {
                    doubleValue *= 1e9;
                }
                else if (units == "mhz")
                {
                    doubleValue *= 1e6;
                }
                else if (units == "khz")
                {
                    doubleValue *= 1e3;
                }
                else if (units == "hz")
                {
                    // ok
                }
                else
                {
                    return false;
                }
                return true;
            }
        }

        public static string Hz(this double value)
        {
            string units;
            if (value >= 1e9)
            {
                units = " GHz";
                value /= 1e9;
            }
            else if (value >= 1e6)
            {
                units = " MHz";
                value /= 1e6;
            }
            else if (value >= 1e3)
            {
                units = " kHz";
                value /= 1e3;
            }
            else
            {
                units = " Hz";
            }
            return value.ToString() + units;
        }

        public static double Sq(this double value) { return value * value; }
        public static float  Sq(this float  value) { return value * value; }
        public static long   Sq(this long   value) { return value * value; }
        public static int    Sq(this int    value) { return value * value; }

        public static double dB(this double value)
        {
            return 10 * Math.Log10(value);
        }
        public static double dB20(this double value)
        {
            return 20 * Math.Log10(value);
        }
        public static double FromDB(this double value)
        {
            return Math.Pow(10, value / 10);
        }
        public static double FromDB20(this double value)
        {
            return Math.Pow(10, value / 20);
        }

        public static double[] dB(this double[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                values[i] = 10 * Math.Log10(values[i]);
            }
            return values;
        }

        public static double[] dB(this double[] valuesIn, double[] valuesOut)
        {
            int n = valuesIn.Length;
            if (valuesOut.Length < n)
            {
                throw new ArgumentException("valuesOut must be at least as long as valuesIn");
            }
            for (int i = 0; i < valuesIn.Length; ++i)
            {
                valuesOut[i] = 10 * Math.Log10(valuesIn[i]);
            }
            return valuesOut;
        }

        public static double[] dB20(this double[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                values[i] = 20 * Math.Log10(values[i]);
            }
            return values;
        }

        public static double[] dB20(this double[] valuesIn, double[] valuesOut)
        {
            int n = valuesIn.Length;
            if (valuesOut.Length < n)
            {
                throw new ArgumentException("valuesOut must be at least as long as valuesIn");
            }
            for (int i = 0; i < n; ++i)
            {
                valuesOut[i] = 20 * Math.Log10(valuesIn[i]);
            }
            return valuesOut;
        }

        public static double[] FromDB(this double[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                values[i] = Math.Pow(10, values[i] / 10);
            }
            return values;
        }

        public static double[] FromDB(this double[] valuesIn, double[] valuesOut)
        {
            int n = valuesIn.Length;
            if (valuesOut.Length < n)
            {
                throw new ArgumentException("valuesOut must be at least as long as valuesIn");
            }
            for (int i = 0; i < n; ++i)
            {
                valuesOut[i] = Math.Pow(10, valuesIn[i] / 10);
            }
            return valuesOut;
        }

        public static double[] FromDB20(this double[] valuesIn , double[] valuesOut)
        {
            int n = valuesIn.Length;
            for (int i = 0; i < n; ++i)
            {
                valuesOut[i] = Math.Pow(10, valuesIn[i] / 20);
            }
            return valuesOut;
        }

        public static double[] FromDB20(this double[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                values[i] = Math.Pow(10, values[i] / 20);
            }
            return values;
        }

        public static double ToDegrees(this double val)
        {
            return val * 180.0 / Math.PI;
        }

        public static double ToRadians(this double val)
        {
            return val * Math.PI / 180.0;
        }
    }
}
