using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Тип дохода", IconFile = "ProfitType.png")]
    public partial class ProfitTypeView : DBViewInterface
    {
        public ProfitTypeView()
        {
            InitializeComponent();
        }
    }
}
