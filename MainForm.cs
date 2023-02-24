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
            
            // ������� �� ��� �������� ����� ����??? , ����� ��...
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Questions.Load();
            }
            

        }

        # region [ ������� ��� ���������� ����� �������� ]
        static class PointCount //���� ������
        {
            public static int point1 { get; set; }
            public static int point2 { get; set; }
            public static int point3 { get; set; }

        }

        //������� ��� ���������� ����� ��������, �.�. static class PointCount � Program.cs �������� �� �����, ��� ������ �����...
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
        //2-� �������
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
        //3-� �������
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


        public static class HowShowAnswer //������� ��� ������ ������� ������ ��� ������� ������ �� �������� �����
        {
            public static int showAnswerToId { get; set; }

        }

        //��������
        private void button100_Click(object sender, EventArgs e)
        {
            //���� ����� ��������� ����� (������� ���������)
            // � ��� �� ������� ������� ���� �����.�������,   ����� .������
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

        private void button1_Click(object sender, EventArgs e)
        {
            //���� ��� ������ ����� � ����������� � ������ ��� ��������, � ��� � ��� ��������
            Form1 form1 = new Form1(this);
            form1.Show();
            button1.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 1).ToList();
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form1.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
                HowShowAnswer.showAnswerToId = 1;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //���� ��� ������ ����� � ����������� � ������ ��� ��������, � ��� � ��� ��������
            Form2 form2 = new Form2(this);
            form2.Show();
            button2.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 2).ToList();
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form2.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
                HowShowAnswer.showAnswerToId = 2;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //���� ��� ������ ����� � ����������� � ������ ��� ��������, � ��� � ��� ��������
            Form3 form3 = new Form3(this);
            form3.Show();
            button3.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 3).ToList();
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form3.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
                HowShowAnswer.showAnswerToId = 3;

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //���� ��� ������ ����� � ����������� � ������ ��� ��������, � ��� � ��� ��������
            Form4 form4 = new Form4(this);
            form4.Show();
            button4.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 4).ToList();
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form4.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
                HowShowAnswer.showAnswerToId = 4;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //���� ��� ������ ����� � ����������� � ������ ��� ��������, � ��� � ��� ��������
            Form5 form5 = new Form5(this);
            form5.Show();
            button5.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 5).ToList();
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form5.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
                HowShowAnswer.showAnswerToId = 5;

            }
        }
    }
}