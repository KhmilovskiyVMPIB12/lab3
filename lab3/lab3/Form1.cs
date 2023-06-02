using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запретить изменение размера формы
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            //получаем значение текстового поля + отрезаем пробелы по краям;
            string userName = tbName.Text.Trim();
            if (userName.Length < 3)
            {
                MessageBox.Show("введите имя пользователя!");
            }
            else
            {
                MessageBox.Show("Привет " + userName);
            }
        }
    }
}