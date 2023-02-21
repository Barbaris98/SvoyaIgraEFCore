using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvoyaIgraEFCore
{
    public partial class Form2 : Form
    {
        readonly MainForm mainForm;
        public Form2(MainForm owner)
        {
            mainForm = owner;
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Point100Comand1();

            button1.Enabled = false;
            // делаем загреивание остальных кнопок, чтоб присуждать очки другим
            // одной и только одной комаде
            if (button2.Enabled & button3.Enabled & button4.Enabled)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            //и закрываем форму
            Close();
        }

    }
}
