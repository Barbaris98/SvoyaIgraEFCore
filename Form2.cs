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
            mainForm.Point200Comand1();

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
            mainForm.Point200Comand2();

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
            mainForm.Point200Comand3();

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

        //никто не ответил
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        //показать ответ
        private void button100_Click(object sender, EventArgs e)
        {
            
            if(MainForm.HowShowAnswer.showAnswerToId == 2)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 2).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 7)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 7).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 12)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 12).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 22)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 22).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 27)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 27).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 32)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 32).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 37)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 37).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 42)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 42).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 47)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 47).ToList();
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
