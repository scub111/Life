using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Тип тренировки", IconFile = "SportType.png")]
    public partial class SportTypeView : DBViewInterface
    {
        public SportTypeView()
        {
            InitializeComponent();
        }
    }
}
