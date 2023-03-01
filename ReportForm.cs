using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.Data.OleDb;
//using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.EntityFrameworkCore;

namespace SvoyaIgraEFCore
{
    public partial class ReportForm : Form
    {
        readonly MainForm mainForm;
        public ReportForm(MainForm owner)
        {
            mainForm = owner;
            InitializeComponent();
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
