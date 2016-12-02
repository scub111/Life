using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Threading;
using Usable;
using RapidInterface;

namespace Life
{
    public partial class MainForm : XtraFormOnline
    {
        public MainForm()
        {
            Global.Default.Init();
            InitializeComponent();
            dbConnection1.DataBaseType = (RapidInterface.DBConnection.SQLType)Global.Default.varXml.DBConnection.DataBaseType;
            dbConnection1.DataBase = Global.Default.varXml.DBConnection.DataBase;
            dbConnection1.PasswordNeed = Global.Default.varXml.DBConnection.PasswordNeed;
            dbConnection1.LoginFormNeed = Global.Default.varXml.DBConnection.LoginFormNeed;
            dbConnection1.User = Global.Default.varXml.DBConnection.User;
            dbConnection1.Password = Global.Default.varXml.DBConnection.Password;
            dbConnection1.InitDBConnectionEx();

            RunOnline();
        }

        /// <summary>
        /// Начальный текст.
        /// </summary>
        string InitText;

        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {
                case Program.WM_USER:
                    MessageBox.Show("Message recieved: " + msg.WParam + " - " + msg.LParam);
                    break;
            }
            base.WndProc(ref msg);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text += string.Format(" {0}", Global.Default.Version);
            InitText = Text;
        }

        private void MainForm_OnlineChanged(object sender, EventArgs e)
        {
            if (!Online)
            {
                Hide();
                dbConnection1.InitDBConnectionEx();
            }
        }

        private void MainForm_OnlineCountChanged(object sender, EventArgs e)
        {
            Text = string.Format("{0} [{1} c]", InitText, OnlineLost);
        }
    }
}
