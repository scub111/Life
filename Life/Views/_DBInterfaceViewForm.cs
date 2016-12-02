using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "", IconFile = "")]
    public partial class _DBInterfaceViewForm : DBViewInterface
    {
        public _DBInterfaceViewForm()
        {
            InitializeComponent();
        }
    }
}
