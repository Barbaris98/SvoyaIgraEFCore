using System;
using System.Windows.Forms;


namespace SvoyaIgraEFCore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
        
        /* �� ����� ���� ����� �� ��������... �������� 25 ������� ������..
        static class PointCount //���� ������
        {
            public static int point1 { get; set; }
            public static int point2 { get; set; }
            public static int point3 { get; set; }

        }
        */
    }
}