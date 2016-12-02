using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Тип расхода", IconFile = "CostType.png")]
    public partial class CostTypeView : DBViewInterface
    {
        public CostTypeView()
        {
            InitializeComponent();
        }
    }
}
