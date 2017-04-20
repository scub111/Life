using System;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;
using System.Collections.Generic;

namespace Life
{
    public partial class DatebookProfitReport : XtraReport
    {
        public DatebookProfitReport()
        {
            InitializeComponent();

            datebookProfitSum = new List<RecordSum>();

            xrChartProfit.Series[0].DataSource = datebookProfitSum;
            xrChartProfit.Series[0].ArgumentDataMember = "Name";
            xrChartProfit.Series[0].ValueDataMembers.AddRange(new string[] { "Sum" });
        }

        /// <summary>
        /// Сводная статистика по доходам.
        /// </summary>
        private List<RecordSum> datebookProfitSum { get; set; }

        /// <summary>
        /// Сумма дохода за период.
        /// </summary>
        private double profitSum;

        /// <summary>
        /// Количество месяцев за период.
        /// </summary>
        private double monthCount;

        private void DatebookMoneyReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((bool)Clean.Value)
                xpcDatebookProfitCollection.Criteria = CriteriaOperator.Parse("[DatebookOwner].[Date] Between(?, ?) && [ProfitTypeID].[Clean]", BeginDate.Value, EndDate.Value);
            else
                xpcDatebookProfitCollection.Criteria = CriteriaOperator.Parse("[DatebookOwner].[Date] Between(?, ?)", BeginDate.Value, EndDate.Value);


            RecordSum.GenerateTableSum<ProfitType>(datebookProfitSum, xpcDatebookProfitCollection, "Profit", "ProfitTypeID", "ProfitTypeCaption");

            monthCount = ((DateTime)EndDate.Value).Subtract((DateTime)BeginDate.Value).Days / (365.25 / 12);
        }

        private void xrLabel1_SummaryReset(object sender, EventArgs e)
        {
            profitSum = 0;
        }

        private void xrLabel1_SummaryRowChanged(object sender, EventArgs e)
        {
            profitSum += Convert.ToDouble(DetailReport.GetCurrentColumnValue("Profit"));
        }

        private void xrLabel1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = profitSum / monthCount;
            e.Handled = true;
        }
    }
}
