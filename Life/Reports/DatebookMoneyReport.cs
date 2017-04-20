using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;
using System.Collections.Generic;

namespace Life
{
    public partial class DatebookMoneyReport : XtraReport
    {
        public DatebookMoneyReport()
        {
            InitializeComponent();

            DatebookProfitSum = new List<RecordSum>();
            DatebookCostSum = new List<RecordSum>();

            xrChartProfit.Series[0].DataSource = DatebookProfitSum;
            xrChartProfit.Series[0].ArgumentDataMember = "Name";
            xrChartProfit.Series[0].ValueDataMembers.AddRange(new string[] { "Sum" });

            xrChartCost.Series[0].DataSource = DatebookCostSum;
            xrChartCost.Series[0].ArgumentDataMember = "Name";
            xrChartCost.Series[0].ValueDataMembers.AddRange(new string[] { "Sum" });
        }

        /// <summary>
        /// Сводная статистика по доходам.
        /// </summary>
        private List<RecordSum> DatebookProfitSum { get; set; }

        /// <summary>
        /// Сводная статистика по расходам.
        /// </summary>
        private List<RecordSum> DatebookCostSum { get; set; }


        private void DatebookMoneyReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xpcDatebookProfitCollection.Criteria = CriteriaOperator.Parse("[DatebookOwner].[Date] Between(?, ?)", BeginDate.Value, EndDate.Value);
            xpcDatebookCostCollection.Criteria = CriteriaOperator.Parse("[DatebookOwner].[Date] Between(?, ?)", BeginDate.Value, EndDate.Value);

            RecordSum.GenerateTableSum<ProfitType>(DatebookProfitSum, xpcDatebookProfitCollection, "Profit", "ProfitTypeID", "ProfitTypeCaption");
            RecordSum.GenerateTableSum<CostType>(DatebookCostSum, xpcDatebookCostCollection, "Cost", "CostTypeID", "CostTypeCaption");
            //DatebookCostSum.OrderBy(Sum => Sum);
            //DatebookCostSum.Sort();
            //DatebookCostSum.Reverse();
        }
    }
}
