using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;


namespace SvoyaIgraEFCore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            // Поможет ли это ускорить вывод форм??? , вроде да...
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Questions.Load();
            }
            

        }

        # region [ Костыли для добавления очков командам ]
        static class PointCount //Очки команд
        {
            public static int point1 { get; set; }
            public static int point2 { get; set; }
            public static int point3 { get; set; }

        }

        //Костыли для добавления очков командам, т.к. static class PointCount в Program.cs почемуто не виден, нет такого пишет...
        public void Point100Comand1()
        {
            PointCount.point1 = PointCount.point1 + 100;
        }
        public void Point200Comand1()
        {
            PointCount.point1 = PointCount.point1 + 200;
        }
        public void Point300Comand1()
        {
            PointCount.point1 = PointCount.point1 + 300;
        }
        public void Point400Comand1()
        {
            PointCount.point1 = PointCount.point1 + 400;
        }
        public void Point500Comand1()
        {
            PointCount.point1 = PointCount.point1 + 500;
        }
        //2-я команда
        public void Point100Comand2()
        {
            PointCount.point2 = PointCount.point2 + 100;
        }
        public void Point200Comand2()
        {
            PointCount.point2 = PointCount.point2 + 200;
        }
        public void Point300Comand2()
        {
            PointCount.point2 = PointCount.point2 + 300;
        }
        public void Point400Comand2()
        {
            PointCount.point2 = PointCount.point2 + 400;
        }
        public void Point500Comand2()
        {
            PointCount.point2 = PointCount.point2 + 500;
        }
        //3-я команда
        public void Point100Comand3()
        {
            PointCount.point3 = PointCount.point3 + 100;
        }
        public void Point200Comand3()
        {
            PointCount.point3 = PointCount.point3 + 200;
        }
        public void Point300Comand3()
        {
            PointCount.point3 = PointCount.point3 + 300;
        }
        public void Point400Comand3()
        {
            PointCount.point3 = PointCount.point3 + 400;
        }
        public void Point500Comand3()
        {
            PointCount.point3 = PointCount.point3 + 500;
        }
        #endregion


        public static class HowShowAnswer //Костыль для вывода соответ Ответа при нажатии кнопки на дочерней форме
        {
            public static int showAnswerToId { get; set; }

        }

        //Обновить
        private void button100_Click(object sender, EventArgs e)
        {
            //созд новый экзеипляр формы (озможно показапть)
            // и код со старого проекта сюда форма.пкыпцпЮ,   форма .цкпукп
            if (textBox1 != null)
            {
                textBox1.Text = PointCount.point1.ToString();

            }

            if (textBox2 != null)
            {
                textBox2.Text = PointCount.point2.ToString();

            }

            if (textBox3 != null)
            {
                textBox3.Text = PointCount.point3.ToString();

            }

        }

        # region [ Первый блок вопросов ]
        
        private void button1_Click(object sender, EventArgs e)
        {
            //созд экз второй формы и подвязываем к первой как дочернюю, и уже с ним работаем
            Form1 form1 = new Form1(this);
            form1.Show();
            button1.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 1).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 1;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //созд экз второй формы и подвязываем к первой как дочернюю, и уже с ним работаем
            Form2 form2 = new Form2(this);
            form2.Show();
            button2.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 2).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form2.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 2;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //созд экз второй формы и подвязываем к первой как дочернюю, и уже с ним работаем
            Form3 form3 = new Form3(this);
            form3.Show();
            button3.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 3).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form3.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 3;

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //созд экз второй формы и подвязываем к первой как дочернюю, и уже с ним работаем
            Form4 form4 = new Form4(this);
            form4.Show();
            button4.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 4).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form4.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 4;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //созд экз второй формы и подвязываем к первой как дочернюю, и уже с ним работаем
            Form5 form5 = new Form5(this);
            form5.Show();
            button5.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 5).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form5.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 5;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            button6.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 6).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 6;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            button7.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 7).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form2.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            button8.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 8).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form3.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 8;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            button9.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 9).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form4.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 9;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            button10.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 10).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form5.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 10;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            button11.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 11).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 11;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            button12.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 12).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form2.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 12;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            button13.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 13).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form3.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 13;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            button14.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 14).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form4.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 14;

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            button15.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 15).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form5.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 15;

            }
        }


        //картинки-клейма (тоже первый блок вопросов)
        private void button16_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
            button16.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 16).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form6.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 16;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this);
            form7.Show();
            button17.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 17).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form7.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 17;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this);
            form8.Show();
            button18.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 18).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form8.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 18;

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(this);
            form9.Show();
            button19.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 19).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form9.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 19;

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(this);
            form10.Show();
            button20.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 20).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form10.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 20;

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            button21.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 21).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 21;

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            button22.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 22).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form2.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 22;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            button23.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 23).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form3.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 23;

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            button24.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 24).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form4.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 24;

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            button25.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 25).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form5.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 25;

            }
        }

        # endregion


        # region [ Второй блок вопросов ]
        private void button26_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            button26.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 26).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 26;

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            button27.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 27).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form2.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 27;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            button28.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 28).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form3.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 28;

            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            button29.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 29).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form4.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 29;

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            button30.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 30).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form5.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 30;

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            button31.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 31).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 31;

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            button32.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 32).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form2.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 32;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            button33.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 33).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form3.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 33;

            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            button34.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 34).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form4.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 34;

            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            button35.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 35).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form5.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 35;

            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            button36.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 36).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 36;

            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            button37.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 37).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form2.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 37;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            button38.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 38).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form3.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 38;

            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            button39.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 39).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form4.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 39;

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            button40.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 40).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form5.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 40;

            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            button41.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 41).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 41;

            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            button42.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 42).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form2.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 42;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            button43.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 43).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form3.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 43;

            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            button44.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 44).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form4.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 44;

            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            button45.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 45).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form5.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 45;

            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            button46.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 46).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 46;

            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            button47.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 47).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form2.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 47;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            button48.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 48).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form3.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 48;

            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            button49.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 49).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form4.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 49;

            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            button50.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 50).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form5.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 50;

            }
        }
        # endregion


        # region [ Третий блок вопросов ]
        private void button51_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
            button51.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form6.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("konstryk1");


            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 51).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form6.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 51;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this);
            form7.Show();
            button52.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form7.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("konstryk2");

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 52).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form7.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 52;
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this);
            form8.Show();
            button53.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form8.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("konstryk3");

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 53).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form8.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 53;
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(this);
            form9.Show();
            button54.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form9.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("konstryk4");

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 54).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form9.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 54;
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(this);
            form10.Show();
            button55.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form10.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("konstryk5");

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 55).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект questЗомбилэндion!
                form10.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 55;
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
            button56.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form6.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("oryjie1");


            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 56).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form6.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 56;
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this);
            form7.Show();
            button57.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form7.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("oryjie2");

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 57).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form7.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 57;
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this);
            form8.Show();
            button58.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form8.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("oryjie3");

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 58).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form8.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 58;
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(this);
            form9.Show();
            button59.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form9.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("oryjie4");

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 59).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form9.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 59;
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(this);
            form10.Show();
            button60.Enabled = false;

            //меняем картинку по соответствующему вопросу 
            form10.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("oryjie5");

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 60).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект questЗомбилэндion!
                form10.textBox1.Text = question[0].Text.ToString();

                //изменяем параметр у костыля чтоб ответ показывался по соответ id
                HowShowAnswer.showAnswerToId = 60;
            }
        }
        # endregion

        
        //Game over
        private void button101_Click(object sender, EventArgs e)
        {
            GameOver gameOver = new GameOver(this);
            gameOver.Show();
            button101.Enabled = false;

            string komand1Win = "1";
            string komand2Win = "2";
            string komand3Win = "3";
            
            //выводим в первый текстбокс наиб число
            if (PointCount.point1 > (PointCount.point2 | PointCount.point3))
            {
                gameOver.textBox1.Text = komand1Win;
            }
            else if (PointCount.point2 > (PointCount.point1 | PointCount.point3))
            {
                gameOver.textBox1.Text = komand2Win;
            }
            else if (PointCount.point3 > (PointCount.point1 | PointCount.point2))
            {
                gameOver.textBox1.Text = komand3Win;
            }



            // выводим во второй текстбокс наиб число, с учётом первого набольшего
            if (gameOver.textBox1.Text == komand1Win)
            {
                if(PointCount.point2 > PointCount.point3)
                {
                    gameOver.textBox2.Text = komand2Win;
                }
                else
                {
                    gameOver.textBox2.Text = komand3Win;
                }
            }
            else if (gameOver.textBox1.Text == komand2Win)
            {
                if (PointCount.point1 > PointCount.point3)
                {
                    gameOver.textBox2.Text = komand1Win;
                }
                else
                {
                    gameOver.textBox2.Text = komand3Win;
                }
            }
            else if (gameOver.textBox1.Text == komand3Win)
            {
                if (PointCount.point1 > PointCount.point2)
                {
                    gameOver.textBox2.Text = komand1Win;
                }
                else
                {
                    gameOver.textBox2.Text = komand2Win;
                }
            }


        }

        // Закрыть приложение Да-Нет?
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Закрыть приложение?",
        "Закрытие",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Error,
        MessageBoxDefaultButton.Button2,
        MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                //Close(); будет просто закрыться MessageBox, тк на НЁМ ты его вызываешь !
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            };
        }

        private void создатьОтчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportform = new ReportForm(this);
            reportform.Show();

            using (ApplicationContext db = new ApplicationContext())
            {
                reportform.dataGridView1.DataSource = db.Questions.ToList();

            }
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo procInfo = new ProcessStartInfo();
            // исполняемый файл программы - браузер хром
            procInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome";
            // аргументы запуска - адрес интернет-ресурса
            procInfo.Arguments = "https://vk.com/dimaruss195";
            Process.Start(procInfo);
        }
    }
}