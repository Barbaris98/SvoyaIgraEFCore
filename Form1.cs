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
    public partial class Form1 : Form
    {
        readonly MainForm mainForm;

        public Form1(MainForm owner)
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

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.Point100Comand2();

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
            mainForm.Point100Comand3();

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

        //показать ответ
        private void button100_Click(object sender, EventArgs e)
        {
            
            if (MainForm.HowShowAnswer.showAnswerToId == 1)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 1).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 6)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 6).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 11)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 11).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 21)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 21).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 26)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 26).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 31)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 31).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 36)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 36).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 41)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 41).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 46)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 46).ToList();
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
