using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Пол", IconFile = "Sex.png")]
    public partial class SexView : DBViewInterface
    {
        public SexView()
        {
            InitializeComponent();
        }
    }
}
