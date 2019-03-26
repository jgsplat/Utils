using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Linear.Utils
{
    public static class Strings
    {
        public static string RemoveChar(this string str, char ch)
        {
            StringBuilder sb = new StringBuilder(str.Length);
            foreach (var c in str)
            {
                if (c != ch)
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string[] SplitOnComma(this string row, bool makeLowerCase = false)
        {
            string[] cells = row.Split(',');
            if (makeLowerCase)
            {
                for (int i = 0; i < cells.Length; ++i)
                {
                    cells[i] = cells[i].Trim().ToLower();
                }
            }
            else
            {
                for (int i = 0; i < cells.Length; ++i)
                {
                    cells[i] = cells[i].Trim();
                } 
            }
            return cells;
        }

        public static string Args(this string str, params object[] args)
        {
            return string.Format(str, args);
        }

        public static string ReadNonBlankLine(this StreamReader sr)
        {
            string line;
            do
            {
                line = sr.ReadLine();
            } while (line != null && line.Length == 0);
            return line;
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendLine(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text + "\n");
            box.SelectionColor = box.ForeColor;
            box.ScrollToCaret();
        }

        public static void AppendLine(this RichTextBox box, string text)
        {
            box.AppendText(text + "\n");
            box.ScrollToCaret();
        }
    }
}
