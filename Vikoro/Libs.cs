using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikoro
{
    public static class Libs
    {

        private static Random RNG = new Random();

        public static String Roll(String count, String sides, String op, String mods)
        {
            StringBuilder buf = new StringBuilder();

            int iCount = int.Parse(count);
            int iSides = int.Parse(sides);

            int iMods;
            if (int.TryParse(mods, out iMods)) { }
            else
            {
                iMods = 0;
            }

            buf.Append(count);
            buf.Append("d");
            buf.Append(sides);

            if (op.Length > 0 && iMods > 0)
            {
                buf.Append(op);
                buf.Append(mods);
            }

            buf.Append(" ... ");

            List<int> rolled = new List<int>();
            for (int i = 0; i < iCount; i++)
            {
                rolled.Add(RNG.Next(iSides) + 1);
            }

            buf.Append(FormatCollection(rolled));

            if (op.Length > 0 && iMods > 0)
            {
                buf.Append(" " + op + " ");
                buf.Append(mods);
            }
            buf.Append(" = ");

            int r = Calc(op, rolled.Sum(), iMods);
            buf.Append(r);

            return buf.ToString();
        }

        private static String FormatCollection(IEnumerable<int> values)
        {
            StringBuilder buf = new StringBuilder();
            buf.Append("[");
            buf.Append(string.Join(", ", values));
            buf.Append("]");

            return buf.ToString();
        }

        private static int Calc(String op, int left, int right)
        {
            int ret = 0;
            switch (op)
            {
                case "+":
                    ret = left + right;
                    break;
                case "-":
                    ret = left - right;
                    break;
                case "*":
                    ret = left * right;
                    break;
                case "/":
                    ret = left / right;
                    break;
                default:
                    ret = left;
                    break;
            }

            return ret;
        }

    }
}
