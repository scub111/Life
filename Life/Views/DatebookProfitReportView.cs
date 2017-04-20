using RapidInterface;
using System;

namespace Life
{
    [DBAttribute(Caption = "Доходы", IconFile = "DatebookProfitReportView.png")]

    public partial class DatebookProfitReportView : InterfaceReport
    {
        public DatebookProfitReportView()
        {
            InitializeComponent();
        }

        private void DatebookProfitReportView_Load(object sender, EventArgs e)
        {
            DatebookProfitReport report = new DatebookProfitReport();

            report.EndDate.Value = DateTime.Now;
            report.BeginDate.Value = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);

            documentViewer1.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
    }
}
