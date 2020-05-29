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
            SampleChartModel sampleChartModel = new SampleChartModel();

            var xDoubles = new List<double>();
            var yDoubles = new List<double>();

            for (int i = 0; i < 100; ++i)
            {
                xDoubles.Add(i);
                yDoubles.Add(i + new Random().NextDouble());
            }

            sampleChartModel.X = xDoubles;
            sampleChartModel.Y = yDoubles;

            GraphExampleReport report = new GraphExampleReport();
            report.DataSource = new List<SampleChartModel> { sampleChartModel };
            report.ExportToPdf("chartReport");
        }
    }
}
