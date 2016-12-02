using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Место", IconFile = "Place.png")]
    public partial class PlaceView : DBViewInterface
    {
        public PlaceView()
        {
            InitializeComponent();
        }
    }
}
