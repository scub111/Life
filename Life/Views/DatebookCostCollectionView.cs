using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Расходы", IconFile = "DatebookCostCollection.png")]
    public partial class DatebookCostCollectionView : DBViewInterface
    {
        public DatebookCostCollectionView()
        {
            InitializeComponent();
        }
    }
}
