using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Прибыль", IconFile = "DatebookProfitCollection.png")]
    public partial class DatebookProfitCollectionView : DBViewInterface
    {
        public DatebookProfitCollectionView()
        {
            InitializeComponent();
        }
    }
}
