using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;
using System.Collections.ObjectModel;
using DevExpress.Xpo;
using System.Linq;
using System.Collections.Generic;

namespace Life
{
    public partial class DatebookMoneyReport : DevExpress.XtraReports.UI.XtraReport
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
        /// Класс для создания сводных диаграмм.
        /// </summary>
        public class RecordSum : IComparable<RecordSum>
        {
            public RecordSum(string name, double sum)
            {
                Name = name;
                Sum = sum;
            }
            /// <summary>
            /// Название записи.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Сумма.
            /// </summary>
            public double Sum { get; set; }

            public int CompareTo(RecordSum other)
            {
                return this.Sum.CompareTo(other.Sum);
            }
        }

        /// <summary>
        /// Сводная статистика по доходам.
        /// </summary>
        private List<RecordSum> DatebookProfitSum { get; set; }

        /// <summary>
        /// Сводная статистика по расходам.
        /// </summary>
        private List<RecordSum> DatebookCostSum { get; set; }

        public static void GenerateTableSum<tableType>(List<RecordSum> recordSum, XPCollection xpCollection, string fieldNameCollection, string typeID, string typeCaption)
        {
            recordSum.Clear();
            XPCollection<tableType> CostTypes = new XPCollection<tableType>();

            foreach (tableType costType in CostTypes)
            {
                xpCollection.Filter = CriteriaOperator.Parse(string.Format("[{0}] == ?", typeID), costType);

                double costSum = 0;
                foreach (object costCollection in xpCollection)
                    costSum += (double)costCollection.GetType().GetProperty(fieldNameCollection).GetValue(costCollection, null);
                if (costSum > 0)
                    recordSum.Add(new RecordSum((string)typeof(tableType).GetProperty(typeCaption).GetValue(costType, null), costSum));
            }

            xpCollection.Filter = CriteriaOperator.Parse("");
        }

        private void DatebookMoneyReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xpcDatebookProfitCollection.Criteria = CriteriaOperator.Parse("[DatebookOwner].[Date] Between(?, ?)", BeginDate.Value, EndDate.Value);
            xpcDatebookCostCollection.Criteria = CriteriaOperator.Parse("[DatebookOwner].[Date] Between(?, ?)", BeginDate.Value, EndDate.Value);

            GenerateTableSum<ProfitType>(DatebookProfitSum, xpcDatebookProfitCollection, "Profit", "ProfitTypeID", "ProfitTypeCaption");
            GenerateTableSum<CostType>(DatebookCostSum, xpcDatebookCostCollection, "Cost", "CostTypeID", "CostTypeCaption");
            //DatebookCostSum.OrderBy(Sum => Sum);
            //DatebookCostSum.Sort();
            //DatebookCostSum.Reverse();
        }
    }
}
