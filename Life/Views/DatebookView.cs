using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Ежедневник", IconFile = "Datebook.png")]
    public partial class DatebookView : DBViewInterface
    {
        public DatebookView()
        {
            InitializeComponent();
        }

        private void DatebookView_Load(object sender, EventArgs e)
        {
            /*
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Green;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "true";
            this.tableGridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            */
        }
    }
}
