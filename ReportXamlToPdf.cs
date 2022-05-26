using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace WatchShop_Vasilyev_isp27
{
    class ReportXamlToPdf
    {
        UserControl report;

        public void SetReport(UserControl UC)
        {
            report = UC;
        }

        public void SaveToPdf()
        {
            FlowDocument fd = new FlowDocument();

            BlockUIContainer block = new BlockUIContainer();
            block.Child = report;
            fd.Blocks.Add(block);

            MemoryStream ms = new MemoryStream();
            System.IO.Packaging.Package pac = System.IO.Packaging.Package.Open(ms, FileMode.Create);

            XpsDocument doc = new XpsDocument(pac);
            XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(doc);
            writer.Write(report);
            doc.Close();
            pac.Close();
            var pdf = PdfSharp.Xps.XpsModel.XpsDocument.Open(ms);
            PdfSharp.Xps.XpsConverter.Convert(pdf, "Квитанция поставок.pdf", 0);
        }
    }
}
