using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Тип эл. связи", IconFile = "ElectronCouplingType.png")]
    public partial class ElectronCouplingTypeView : DBViewInterface
    {
        public ElectronCouplingTypeView()
        {
            InitializeComponent();
        }
    }
}
