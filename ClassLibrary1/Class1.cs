using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class Class1
    {

        public static string Gen(int n)
        {
            string str = "";
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int x = (rnd.Next(2,14));
                str += x + " ";
            }
            return str;
        }

        public static string Ras(string r)
        {
            string x = "";
            string z = "";
            int sum = 0;
            for (int i = 0; i < r.Length; i++)
            {
                if (Char.IsNumber(r[i]))
                {
                    x += r[i];
                }
                else
                {
                    int y = Convert.ToInt32(x);
                    x = "";
                    if (y < 8)
                    {
                        sum += y;
                    }
                }
            }
            z = sum.ToString();
            return z;
        }


    }
}
