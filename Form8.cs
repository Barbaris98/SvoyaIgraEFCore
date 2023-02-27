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
    public partial class Form8 : Form
    {
        readonly MainForm mainForm;
        public Form8(MainForm owner)
        {
            mainForm = owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Point300Comand1();

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

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.Point300Comand2();

            button2.Enabled = false;
            // делаем загреивание остальных кнопок, чтоб присуждать очки другим
            // одной и только одной комаде
            if (button1.Enabled & button3.Enabled & button4.Enabled)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            //и закрываем форму
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.Point300Comand3();

            button3.Enabled = false;
            // делаем загреивание остальных кнопок, чтоб присуждать очки другим
            // одной и только одной комаде
            if (button2.Enabled & button1.Enabled & button4.Enabled)
            {
                button2.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = false;
            }
            //и закрываем форму
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (MainForm.HowShowAnswer.showAnswerToId == 18)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 18).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 53)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 53).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }

            }

            if (MainForm.HowShowAnswer.showAnswerToId == 58)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 58).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }

            }

            //активровать кнопки после показа ответа 
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
    }
}
