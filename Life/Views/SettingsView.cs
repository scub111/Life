using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;
using System.Threading;
using System.Globalization;

namespace Life
{
    [DBAttribute(Caption = "Настройки", IconFile = "Settings.png")]
    public partial class SettingsView : DBViewInterface
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
            this.OnResize(EventArgs.Empty);
            InvokeLanguageUIChanged();
        }

        private void btnRussian_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = new CultureInfo("ru");
            this.Controls.Clear();
            InitializeComponent();
            this.OnResize(EventArgs.Empty);
            InvokeLanguageUIChanged();
        }
    }
}
