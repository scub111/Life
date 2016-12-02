using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Образование", IconFile = "Education.png")]
    public partial class EducationView : DBViewInterface
    {
        public EducationView()
        {
            InitializeComponent();
        }
    }
}
