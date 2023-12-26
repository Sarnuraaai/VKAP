/**
    @file Help.cs
    @brief Файл-инструкция к игре Шашки
    @copyright VKAP
    @author Красильников В.Г. и Преснухин А.П.
    @date 27-12-2023
    @version 1.1.20
\par Использует класс:
    @ref Help
\par Содержит класс:
    @ref Help
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
    @brief Класс Help
    
    Основной и единственный класс, отвечающий за отображение помощи по игре
    */
    public partial class Help : Form
    {

        /// Метод инициализации
        /** Инициализация всех компонентов окна Помощь
        */
        public Help()
        {
            InitializeComponent();
        }

        /// Метод, показывающий окно Помощь
        /** 
        */
        private void Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Interface = Application.OpenForms[0];
            Interface.Show();
        }
    }
}
