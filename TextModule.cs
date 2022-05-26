using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchShop_Vasilyev_isp27
{
    class TextModule
    {
        public string StringSeparation(int n, string s)
        {
            string o = "";
            int ost = 0;
            ost = s.Length % n;
            for (int i = 0; i < s.Length - ost; i += n)
            {
                o += s.Substring(i, n);
                o += "\n";
            }

            o += s.Substring(s.Length - ost);
            return o;

        }

        public string DesignerLine(int n, char s)
        {
            string o = "";
            for (int i = 0; i < n; i++)
            {
                o += s;
            }
            return o;
        }
    }
}