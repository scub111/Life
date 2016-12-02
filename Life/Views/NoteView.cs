using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace Life
{
    [DBAttribute(Caption = "Заметки", IconFile = "Note.png")]
    public partial class NoteView : DBViewInterface
    {
        public NoteView()
        {
            InitializeComponent();
        }
    }
}
