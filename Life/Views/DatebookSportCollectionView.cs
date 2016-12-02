using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Спорт", IconFile = "DatebookSportCollection.png")]
    public partial class DatebookSportCollectionView : DBViewInterface
    {
        public DatebookSportCollectionView()
        {
            InitializeComponent();
        }
    }
}
