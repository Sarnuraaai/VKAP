/**
    @file Interface.cs
    @brief Файл интерфейса игры Шашки
    @copyright VKAP
    @author Красильников В.Г. и Преснухин А.П.
    @date 27-12-2023
    @version 1.1.20
\par Использует файлы:
    @ref Two_Players.cs
    @ref Help.cs
    @ref About_us.cs
\par Использует класс:
    @ref Interface
\par Содержит класс:
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

        /// Метод-обработчик наведения
        /** Происходит, когда указатель мыши оказывается на элементе
        */
        private void Two_Players_MouseEnter(object sender, EventArgs e)
        {
            Two_Players.BackgroundImage = Properties.Resources.Button_Two_Players;
        }

        /// Метод-обработчик отпускания
        /** Происходит, когда указатель мыши убирается с элемента
        */
        private void Two_Players_MouseLeave(object sender, EventArgs e)
        {
            Two_Players.BackgroundImage = Properties.Resources.Button_Two_Players_v2;
        }

        /// Метод-обработчик отпускания
        /** Обрабатывает событие отпускания, когда указатель мыши находится на элементе
        */
        private void Two_Players_MouseUp(object sender, MouseEventArgs e)
        {
            Two_Players.BackgroundImage = Properties.Resources.Button_Two_Players;
        }

        /// Метод-обработчик нажатия
        /** Обрабатывает событие нажатия, когда указатель мыши находится на элементе
        */
        private void Two_Players_MouseDown(object sender, MouseEventArgs e)
        {
            Two_Players.BackgroundImage = Properties.Resources.Button_Two_Players_v2;
        }

        /// Метод-обработчик наведения
        /** Происходит, когда указатель мыши оказывается на элементе
        */
        private void Help_MouseEnter(object sender, EventArgs e)
        {
            Help.BackgroundImage = Properties.Resources.Button_Help;
        }

        /// Метод-обработчик отпускания
        /** Происходит, когда указатель мыши убирается с элемента
        */
        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.BackgroundImage = Properties.Resources.Button_Help_v2;
        }

        /// Метод-обработчик отпускания
        /** Обрабатывает событие отпускания, когда указатель мыши находится на элементе
        */
        private void Help_MouseUp(object sender, MouseEventArgs e)
        {
            Help.BackgroundImage = Properties.Resources.Button_Help;
        }

        /// Метод-обработчик нажатия
        /** Обрабатывает событие нажатия, когда указатель мыши находится на элементе
        */
        private void Help_MouseDown(object sender, MouseEventArgs e)
        {
            Help.BackgroundImage = Properties.Resources.Button_Help_v2;
        }

        /// Метод-обработчик нажатия
        /** Обрабатывает событие нажатия (клика) на элемент
        */
        private void Help_Click(object sender, EventArgs e)
        {
            var help = new Help();
            help.Show();
            this.Hide();
        }

        /// Метод-обработчик наведения
        /** Происходит, когда указатель мыши оказывается на элементе
        */
        private void About_Us_MouseEnter(object sender, EventArgs e)
        {
            About_Us.BackgroundImage = Properties.Resources.Button_About_us;
        }

        /// Метод-обработчик отпускания
        /** Происходит, когда указатель мыши убирается с элемента
        */
        private void About_Us_MouseLeave(object sender, EventArgs e)
        {
            About_Us.BackgroundImage = Properties.Resources.Button_About_us_v2;
        }

        /// Метод-обработчик отпускания
        /** Обрабатывает событие отпускания, когда указатель мыши находится на элементе
        */
        private void About_Us_MouseUp(object sender, MouseEventArgs e)
        {
            About_Us.BackgroundImage = Properties.Resources.Button_About_us;
        }

        /// Метод-обработчик нажатия
        /** Обрабатывает событие нажатия, когда указатель мыши находится на элементе
        */
        private void About_Us_MouseDown(object sender, MouseEventArgs e)
        {
            About_Us.BackgroundImage = Properties.Resources.Button_About_us_v2;
        }

        /// Метод-обработчик нажатия
        /** Обрабатывает событие нажатия (клика) на элемент
        */
        private void About_Us_Click(object sender, EventArgs e)
        {
            var about_us = new About_us();
            about_us.Show();
            this.Hide();
        }

        /// Метод-обработчик нажатия
        /** Обрабатывает событие нажатия (клика) на элемент
        */
        private void Two_Players_Click(object sender, EventArgs e)
        {
            var two_Players = new Two_Players();
            two_Players.Show();
            this.Hide();
        }
    }
}