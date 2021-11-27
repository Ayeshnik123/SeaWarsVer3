using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaWars
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();

        }

        private void Igrat_Click(object sender, EventArgs e) // конструктор поля
        {
            Form pole = new Pole();
            pole.Show();
            this.Hide();
        }



        private void oprog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра 'Морской Бой'\nРазработчик - Кучаев Сергей ИСП-41");
        }
    }
}
