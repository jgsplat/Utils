using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linear.Utils
{
    public static class ControlExt
    {
        public static void LimitValue(this NumericUpDown c, double value)
        {
            c.Value = Math.Max(c.Minimum, Math.Min(c.Maximum, (decimal)value));
        }
        public static double Double(this NumericUpDown c)
        {
            return (double)c.Value;
        }
        public static int Int(this NumericUpDown c)
        {
            return (int)c.Value;
        }
        public static void Double(this NumericUpDown c, double value)
        {
            c.Value = (decimal)value;
        }
        public static void Int(this NumericUpDown c, int value)
        {
            c.Value = value;
        }
        public static void MHz(this NumericUpDown c, double mhz)
        {
            c.Value = (decimal)(mhz / 1e6);
        }
        public static double MHz(this NumericUpDown c)
        {
            return (double)c.Value * 1e6;
        }
    }
}
