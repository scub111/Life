using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Категория человека", IconFile = "PersonCategory.png")]
    public partial class PersonCategoryView : DBViewInterface
    {
        public PersonCategoryView()
        {
            InitializeComponent();
        }
    }
}
