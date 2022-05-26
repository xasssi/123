using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchShop_Vasilyev_isp27
{
    class ReportClass
    {
        String text;

        public void SetText(string s)
        {
            text = s;
        }

        public void CreateTxtFile()
        {
            if (text == "")
            {
                throw new Exception("Нет текста для печати");
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\Отчет(" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + ").txt";


            StreamWriter sw = new StreamWriter(path);
            sw.Write(text);
            sw.Close();
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(text, new System.Drawing.Font("Consolas", 9), Brushes.Black, 2, 2);
        }

        public void PrintText()
        {
            if (text != "")
            {
                PrintDocument pd = new PrintDocument();

                pd.PrintPage += PrintPageHandler;
                pd.Print();
            }
        }
    }
}
