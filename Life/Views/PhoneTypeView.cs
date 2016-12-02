using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Типы телефонов", IconFile = "PhoneType.png")]
    public partial class PhoneTypeView : DBViewInterface
    {
        public PhoneTypeView()
        {
            InitializeComponent();
        }
    }
}
