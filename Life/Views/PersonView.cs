using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Человек", IconFile = "Person.png")]
    public partial class PersonView : DBViewInterface
    {
        public PersonView()
        {
            InitializeComponent();
        }
    }
}
