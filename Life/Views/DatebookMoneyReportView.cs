using System;
using System.ComponentModel;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Деньги", IconFile = "DatebookMoneyReportView.png")]
    public partial class DatebookMoneyReportView : InterfaceReport
    {
        public DatebookMoneyReportView()
        {
            InitializeComponent();
        }

        public DatebookMoneyReportView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void DatebookMoneyReportView_Load(object sender, EventArgs e)
        {
            DatebookMoneyReport report = new DatebookMoneyReport();

            report.EndDate.Value = DateTime.Now;

            if (DateTime.Now.Month != 1)
                report.BeginDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, DateTime.Now.Day);
            else
                report.BeginDate.Value = new DateTime(DateTime.Now.Year - 1, 12, DateTime.Now.Day);

            documentViewer1.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();  
        }
    }
}
