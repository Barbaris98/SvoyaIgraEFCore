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

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            button6.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 6).ToList();
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form1.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form2.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form3.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form4.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form5.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form1.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form2.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form3.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form4.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form5.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
                HowShowAnswer.showAnswerToId = 15;

            }
        }

        //��������-������
        private void button16_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
            button16.Enabled = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                List<Question> question = new List<Question>();
                question = db.Questions.Where(q => q.Id == 16).ToList();
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form6.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form7.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form8.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form9.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form10.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form1.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form2.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form3.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form4.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
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
                //������� ���������� question �� �������� �������, � �� ��� ������ question!
                form5.textBox1.Text = question[0].Text.ToString();

                //�������� �������� � ������� ���� ����� ����������� �� ������� id
                HowShowAnswer.showAnswerToId = 25;

            }
        }
    }
}