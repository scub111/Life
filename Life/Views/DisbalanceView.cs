using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace Life
{
    [DBAttribute(Caption = "Дисбаланс", IconFile = "Disbalance.png")]
    public partial class DisbalanceView : DBViewInterface
    {
        public DisbalanceView()
        {
            InitializeComponent();
        }

        private void btnCalculateProfitCost_Click(object sender, EventArgs e)
        {
            Disbalance disbalance = (Disbalance)_dbInterface1.GetCurrentObject();

            XPCollection<DatebookProfitCollection> xpcProfit = new XPCollection<DatebookProfitCollection>();

            xpcProfit.Criteria = CriteriaOperator.Parse("[DatebookOwner].[Date] Between(?, ?)", disbalance.BeginDate, disbalance.EndDate);

            double profitSum = 0;
            foreach (DatebookProfitCollection profit in xpcProfit)
            {
                profitSum += profit.Profit;
            }
            disbalance.Profit = profitSum;

            XPCollection<DatebookCostCollection> xpcCost = new XPCollection<DatebookCostCollection>();

            xpcCost.Criteria = CriteriaOperator.Parse("[DatebookOwner].[Date] Between(?, ?)", disbalance.BeginDate, disbalance.EndDate);

            double costSum = 0;
            foreach (DatebookCostCollection cost in xpcCost)
            {
                costSum += cost.Cost;
            }
            disbalance.Cost = costSum;
        }

        private void baseUnitOfWork1_ObjectChanged(object sender, ObjectChangeEventArgs e)
        {
            if (e.Reason == ObjectChangeReason.PropertyChanged)
            {
                if (sender is Disbalance)
                    if (e.PropertyName == "Profit")
                    {
                        ProfitSpinEdit1.EditValue = e.NewValue;
                    }
                    else if (e.PropertyName == "Cost")
                    {
                        CostSpinEdit1.EditValue = e.NewValue;
                    }
                    else if (e.PropertyName == "CostPercentLast")
                    {
                        CostPercentLastSpinEdit1.EditValue = e.NewValue;
                    }
                    else if (e.PropertyName == "Value")
                    {
                        ValueSpinEdit1.EditValue = e.NewValue;
                    }
                    else if (e.PropertyName == "ValuePercentLast")
                    {
                        ValuePercentLastSpinEdit1.EditValue = e.NewValue;
                    }
            }
        }

        private void btnCalculateDisbalance_Click(object sender, EventArgs e)
        {
            Disbalance disCurrent = (Disbalance)_dbInterface1.GetCurrentObject();
            disCurrent.Value = disCurrent.Account1
                + disCurrent.Account2
                + disCurrent.Account3
                + disCurrent.Account4
                + disCurrent.Account5
                + disCurrent.Account6
                + disCurrent.Account7
                + disCurrent.Account8
                + disCurrent.Account9
                + disCurrent.Account10
                - (disCurrent.Profit - disCurrent.Cost);

            disCurrent.Value = Math.Round(disCurrent.Value, 2);

            XPCollection<Disbalance> xpcDisbalance = new XPCollection<Disbalance>();

            int t = 0;

            for (int i = 0; i < xpcDisbalance.Count; i++)
            {
                if (xpcDisbalance[i].Oid == disCurrent.Oid)
                {
                    t = i;
                    break;
                }
            }

            if (t != 0)
            {
                disCurrent.CostPercentLast = Math.Round(xpcDisbalance[t].Cost - xpcDisbalance[t - 1].Cost, 2);
                disCurrent.ValuePercentLast = Math.Round(disCurrent.Value / (xpcDisbalance[t].Cost - xpcDisbalance[t - 1].Cost) * 100, 2); 
            }
        }

        private void DisbalanceView_Load(object sender, EventArgs e)
        {
            _dbInterface1.ProgramDesign = true;
            itemNumeric1.Caption = Global.Default.varXml.Disbalance.Account1;
            itemNumeric2.Caption = Global.Default.varXml.Disbalance.Account2;
            itemNumeric3.Caption = Global.Default.varXml.Disbalance.Account3;
            itemNumeric4.Caption = Global.Default.varXml.Disbalance.Account4;
            itemNumeric5.Caption = Global.Default.varXml.Disbalance.Account5;
            itemNumeric6.Caption = Global.Default.varXml.Disbalance.Account6;
            itemNumeric7.Caption = Global.Default.varXml.Disbalance.Account7;
            itemNumeric8.Caption = Global.Default.varXml.Disbalance.Account8;
            itemNumeric9.Caption = Global.Default.varXml.Disbalance.Account9;
            itemNumeric10.Caption = Global.Default.varXml.Disbalance.Account10;
            _dbInterface1.ProgramDesign = false;
        }
    }
}
