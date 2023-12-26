/**
    @file About_us.cs
    @brief Файл о разработчике игры Шашки
    @copyright VKAP
    @author Красильников В.Г. и Преснухин А.П.
    @date 27-12-2023
    @version 1.1.20
\par Использует класс:
    @ref About_us
\par Содержит класс:
    @ref About_us
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_v1
{
    /**
    @brief Класс About_us
    
    Основной и единственный класс, отвечающий за отображение информации о разработчике игры
    */
    public partial class About_us : Form
    {

        /// Метод инициализации
        /** Инициализация всех компонентов окна О разработчике
        */
        public About_us()
        {
            InitializeComponent();
        }

        /// Метод, показывающий окно О разработчиках
        /** 
        */
        private void About_us_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Interface = Application.OpenForms[0];
            Interface.Show();
        }
    }
}
