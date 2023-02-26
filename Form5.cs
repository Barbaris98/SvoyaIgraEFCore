﻿using System;
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
    public partial class Form5 : Form
    {
        readonly MainForm mainForm;
        public Form5(MainForm owner)
        {
            mainForm = owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Point500Comand1();

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
            mainForm.Point500Comand2();

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
            mainForm.Point500Comand3();

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
            
            if (MainForm.HowShowAnswer.showAnswerToId == 5)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 5).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 10)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 10).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 15)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 15).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 25)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 25).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 30)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 30).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 35)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 35).ToList();
                    textBox2.Text = question[0].Answer.ToString();
                }
            }

            if (MainForm.HowShowAnswer.showAnswerToId == 40)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<Question> question = new List<Question>();
                    question = db.Questions.Where(q => q.Id == 40).ToList();
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
