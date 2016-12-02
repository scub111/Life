using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Секс", IconFile = "DatebookMeetingSexCollection.png")]
    public partial class DatebookMeetingSexCollectionView : DBViewInterface
    {
        public DatebookMeetingSexCollectionView()
        {
            InitializeComponent();
        }
    }
}
