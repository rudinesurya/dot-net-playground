using System;
using System.Collections.Generic;
using System.Windows.Input;
using dot_net_playground.Models;
using dot_net_playground.Models.Base;
using dot_net_playground.Reports;
using DevExpress.XtraPrinting;

namespace dot_net_playground.ViewModels
{
    public class ChartExampleViewModel : ObservableObject
    {
        private ICommand _showReportCommand;

        public ICommand ShowReportCommand
        {
            get
            {
                if (_showReportCommand == null)
                {
                    _showReportCommand = new RelayCommand(
                        param => ShowReport()
                    );
                }
                return _showReportCommand;
            }
        }

        private void ShowReport()
        {
            SampleReportModel sampleChartModel = new SampleReportModel();

            sampleChartModel.Title = "Binding success !";
            sampleChartModel.Chart1 = new List<Tuple<string, decimal, decimal>>
            {
                new Tuple<string, decimal, decimal>("A", 1, 1),
                new Tuple<string, decimal, decimal>("A", 2, 3),
                new Tuple<string, decimal, decimal>("A", 3, 5),
                new Tuple<string, decimal, decimal>("A", 4, 3),
                new Tuple<string, decimal, decimal>("A", 5, 1)
            };

            GraphExampleReport report = new GraphExampleReport();
            report.DataSource = new List<SampleReportModel> { sampleChartModel };
            report.ExportToPdf("chartReport.pdf");
        }
    }
}
