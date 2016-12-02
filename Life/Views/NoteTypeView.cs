using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Тип заметки", IconFile = "NoteType.png")]
    public partial class NoteTypeView : DBViewInterface
    {
        public NoteTypeView()
        {
            InitializeComponent();
        }
    }
}
