using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Microsoft.EntityFrameworkCore;
namespace SvoyaIgraEFCore
{
    public partial class GameOver : Form
    {
        readonly MainForm mainForm;
        public GameOver(MainForm owner)
        {
            mainForm = owner;
            InitializeComponent();
        }



    }
}
