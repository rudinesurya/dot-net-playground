using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dot_net_playground.Models.Base;

namespace dot_net_playground.Models
{
    public class SampleChartModel : ObservableObject
    {
        public List<double> X { get; set; }
        public List<double> Y { get; set; }
    }
}
