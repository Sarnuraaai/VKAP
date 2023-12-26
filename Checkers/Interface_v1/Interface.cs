/**
    @file Interface.cs
    @brief ���� ���������� ���� �����
    @copyright VKAP
    @author ������������ �.�. � ��������� �.�.
    @date 27-12-2023
    @version 1.1.20
\par ���������� �����:
    @ref Two_Players.cs
    @ref Help.cs
    @ref About_us.cs
\par ���������� �����:
    @ref Interface
\par �������� �����:
    @ref Interface
*/
using Interface_v1.Properties;

namespace Interface_v1
{
    /**
    @brief Class Interface
   
    */
    public partial class Interface : Form
    {
        /// Metod of Initialization
        /** 
        */
        public Interface()
        {
            InitializeComponent();
        }

        /// �����-���������� ���������
        /** ����������, ����� ��������� ���� ����������� �� ��������
        */
        private void Two_Players_MouseEnter(object sender, EventArgs e)
        {
            Two_Players.BackgroundImage = Properties.Resources.Button_Two_Players;
        }

        /// �����-���������� ����������
        /** ����������, ����� ��������� ���� ��������� � ��������
        */
        private void Two_Players_MouseLeave(object sender, EventArgs e)
        {
            Two_Players.BackgroundImage = Properties.Resources.Button_Two_Players_v2;
        }

        /// �����-���������� ����������
        /** ������������ ������� ����������, ����� ��������� ���� ��������� �� ��������
        */
        private void Two_Players_MouseUp(object sender, MouseEventArgs e)
        {
            Two_Players.BackgroundImage = Properties.Resources.Button_Two_Players;
        }

        /// �����-���������� �������
        /** ������������ ������� �������, ����� ��������� ���� ��������� �� ��������
        */
        private void Two_Players_MouseDown(object sender, MouseEventArgs e)
        {
            Two_Players.BackgroundImage = Properties.Resources.Button_Two_Players_v2;
        }

        /// �����-���������� ���������
        /** ����������, ����� ��������� ���� ����������� �� ��������
        */
        private void Help_MouseEnter(object sender, EventArgs e)
        {
            Help.BackgroundImage = Properties.Resources.Button_Help;
        }

        /// �����-���������� ����������
        /** ����������, ����� ��������� ���� ��������� � ��������
        */
        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.BackgroundImage = Properties.Resources.Button_Help_v2;
        }

        /// �����-���������� ����������
        /** ������������ ������� ����������, ����� ��������� ���� ��������� �� ��������
        */
        private void Help_MouseUp(object sender, MouseEventArgs e)
        {
            Help.BackgroundImage = Properties.Resources.Button_Help;
        }

        /// �����-���������� �������
        /** ������������ ������� �������, ����� ��������� ���� ��������� �� ��������
        */
        private void Help_MouseDown(object sender, MouseEventArgs e)
        {
            Help.BackgroundImage = Properties.Resources.Button_Help_v2;
        }

        /// �����-���������� �������
        /** ������������ ������� ������� (�����) �� �������
        */
        private void Help_Click(object sender, EventArgs e)
        {
            var help = new Help();
            help.Show();
            this.Hide();
        }

        /// �����-���������� ���������
        /** ����������, ����� ��������� ���� ����������� �� ��������
        */
        private void About_Us_MouseEnter(object sender, EventArgs e)
        {
            About_Us.BackgroundImage = Properties.Resources.Button_About_us;
        }

        /// �����-���������� ����������
        /** ����������, ����� ��������� ���� ��������� � ��������
        */
        private void About_Us_MouseLeave(object sender, EventArgs e)
        {
            About_Us.BackgroundImage = Properties.Resources.Button_About_us_v2;
        }

        /// �����-���������� ����������
        /** ������������ ������� ����������, ����� ��������� ���� ��������� �� ��������
        */
        private void About_Us_MouseUp(object sender, MouseEventArgs e)
        {
            About_Us.BackgroundImage = Properties.Resources.Button_About_us;
        }

        /// �����-���������� �������
        /** ������������ ������� �������, ����� ��������� ���� ��������� �� ��������
        */
        private void About_Us_MouseDown(object sender, MouseEventArgs e)
        {
            About_Us.BackgroundImage = Properties.Resources.Button_About_us_v2;
        }

        /// �����-���������� �������
        /** ������������ ������� ������� (�����) �� �������
        */
        private void About_Us_Click(object sender, EventArgs e)
        {
            var about_us = new About_us();
            about_us.Show();
            this.Hide();
        }

        /// �����-���������� �������
        /** ������������ ������� ������� (�����) �� �������
        */
        private void Two_Players_Click(object sender, EventArgs e)
        {
            var two_Players = new Two_Players();
            two_Players.Show();
            this.Hide();
        }
    }
}