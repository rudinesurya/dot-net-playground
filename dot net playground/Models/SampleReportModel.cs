using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraRichEdit.Internal.PrintLayout;
using dot_net_playground.Models.Base;

namespace dot_net_playground.Models
{
    public class SampleReportModel : ObservableObject
    {
        public string Title { get; set; }
        public List<Tuple<string, decimal, decimal>> Chart1 { get; set; }
    }
}
