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

            form1 = new Form1();//созд
            //form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4();
            form5 = new Form5();
            // Поможет ли это ускорить вывод форм??? , вроде да...
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Questions.Load();


            }
            

        }

        Form1 form1;  //привязали к первой  форме
        //Form2 form2;
        Form3 form3;
        Form4 form4;
        Form5 form5;


        static class PointCount //Очки команд
        {
            public static int point1 { get; set; }
            public static int point2 { get; set; }
            public static int point3 { get; set; }

        }

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
        
        public void Point100Comand1()
        {
            PointCount.point1 = PointCount.point1 + 100;
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Form1 form1= new Form1();
                //new Form1().Show(this); в прмере так 

                List<Question> question = new List<Question>();
                form1.Show();
                question = db.Questions.Where(q => q.Id == 1).ToList();
                //выводим содержимое question по нулевому индексу, а не сам объект question!
                form1.textBox1.Text = question[0].Text.ToString();

            }

            




            //form1.button1.Click+= new EventHandler(button1_Click);//.....
            /* Нужно чтоб выполялся этот код
            private void button1_Click(object sender, EventArgs e)//1 -я команда
            {
                PointCount.point1 = PointCount.point1 + 100;

                // делаем загреивание нажатой кнопки
                button2.Enabled = false;
                // делаем загреивание остальных кнопок, чтоб присуждать очки
                // одной и только одной комаде
                if (button3.Enabled & button4.Enabled)
                {
                    button3.Enabled = false;
                    button4.Enabled = false;
                }

                //и закрываем форму
                Close();
            }
            */


            // нэ работает... нажо через винформы в этх св-вах ??......п.ееррепрервапкецукуцуопр
            //form1.FormClosed += (s, e1) => button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new Form2(this).Show();
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

                HowShowAnswer.showAnswerToId = 1;

                //form2.textBox2.Text = question[0].Answer.ToString();



            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}