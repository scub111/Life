using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Встречи", IconFile = "DatebookMeetingCollection.png")]
    public partial class DatebookMeetingCollectionView : DBViewInterface
    {
        public DatebookMeetingCollectionView()
        {
            InitializeComponent();
        }
    }
}
