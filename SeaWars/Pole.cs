using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SeaWars
{

    public partial class Pole : Form
    {
        int rastanovka = 0;
        int a = 0; // Счётчик для расстановки кораблей
        int schet = 0; // Счётчик ходов
        public Pole()
        {
            InitializeComponent();
        }

        private void Pole_Load(object sender, EventArgs e)
        {
            if (File.Exists("result.txt")) listBox1.Items.AddRange(File.ReadAllLines("result.txt")); // Записываем результаты в листбокс из текстового документа, если документа нет, то создаём его
            button1.Enabled = false;
            textBox1.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox4.Visible = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            groupBox1.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            dataGridView1.ReadOnly = true; //запрет на ввод данных
            dataGridView2.ReadOnly = true; //запрет на ввод данных

            // конструктор поля
            //первое поле
            dataGridView1.ColumnCount = 10; // кол-во колонок по умолчанию
            dataGridView1.RowCount = 10; // кол-во строк по умолчанию
            dataGridView1.Columns[0].HeaderText = "А"; // Название колонки
            dataGridView1.Columns[1].HeaderText = "Б";
            dataGridView1.Columns[2].HeaderText = "В";
            dataGridView1.Columns[3].HeaderText = "Г";
            dataGridView1.Columns[4].HeaderText = "Д";
            dataGridView1.Columns[5].HeaderText = "Е";
            dataGridView1.Columns[6].HeaderText = "Ж";
            dataGridView1.Columns[7].HeaderText = "З";
            dataGridView1.Columns[8].HeaderText = "И";
            dataGridView1.Columns[9].HeaderText = "К";
            dataGridView1.Rows[0].HeaderCell.Value = "1"; // Название строки
            dataGridView1.Rows[1].HeaderCell.Value = "2";
            dataGridView1.Rows[2].HeaderCell.Value = "3";
            dataGridView1.Rows[3].HeaderCell.Value = "4";
            dataGridView1.Rows[4].HeaderCell.Value = "5";
            dataGridView1.Rows[5].HeaderCell.Value = "6";
            dataGridView1.Rows[6].HeaderCell.Value = "7";
            dataGridView1.Rows[7].HeaderCell.Value = "8";
            dataGridView1.Rows[8].HeaderCell.Value = "9";
            dataGridView1.Rows[9].HeaderCell.Value = "10";
            //второе поле
            dataGridView2.ColumnCount = 10; // кол-во колонок по умолчанию
            dataGridView2.RowCount = 10; // кол-во строк по умолчанию
            dataGridView2.Columns[0].HeaderText = "А"; // Название колонки
            dataGridView2.Columns[1].HeaderText = "Б";
            dataGridView2.Columns[2].HeaderText = "В";
            dataGridView2.Columns[3].HeaderText = "Г";
            dataGridView2.Columns[4].HeaderText = "Д";
            dataGridView2.Columns[5].HeaderText = "Е";
            dataGridView2.Columns[6].HeaderText = "Ж";
            dataGridView2.Columns[7].HeaderText = "З";
            dataGridView2.Columns[8].HeaderText = "И";
            dataGridView2.Columns[9].HeaderText = "К";
            dataGridView2.Rows[0].HeaderCell.Value = "1"; // Название строки
            dataGridView2.Rows[1].HeaderCell.Value = "2";
            dataGridView2.Rows[2].HeaderCell.Value = "3";
            dataGridView2.Rows[3].HeaderCell.Value = "4";
            dataGridView2.Rows[4].HeaderCell.Value = "5";
            dataGridView2.Rows[5].HeaderCell.Value = "6";
            dataGridView2.Rows[6].HeaderCell.Value = "7";
            dataGridView2.Rows[7].HeaderCell.Value = "8";
            dataGridView2.Rows[8].HeaderCell.Value = "9";
            dataGridView2.Rows[9].HeaderCell.Value = "10";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Выход из программы
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear(); // Очистка текстбокса
            textBox4.Visible = false; // делаем его невидимым
            button1.Visible = true; // делаем видимым
            //button1.Enabled = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[i, j].Style.BackColor = default; // цикл покраски ячеек в цвет по умолчанию
                }
            for (int i = 0; i < dataGridView2.RowCount; i++)
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView2[i, j].Style.BackColor = default; // цикл покраски ячеек в цвет по умолчанию
                }
            groupBox1.Visible = false;
            korabli.Visible = true;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            radioButton1.Enabled = true;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            a = 0; // Обнуляем счётчик
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            Bot.Pole(dataGridView2, rastanovka); // при нажатии на кнопку происходит расстановка кораблей на поле бота
            groupBox1.Visible = false;
            korabli.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = true;
            button1.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // событие на клик по ячейки
        {
            int poskol = dataGridView1.CurrentCell.ColumnIndex; // запоминаем индекс выбронной колонки
            int posstr = dataGridView1.CurrentCell.RowIndex; // запоминаем индекс выбронной строки
            if (dataGridView1.CurrentCell.Style.BackColor == default) // если цвет ячейки по умолчанию, то условие выполняется, если нет, то выводится messagebox
            {
                if (radioButton5.Checked == true) // проверка на расположение кораблей. Горизонтальное расположение кораблей
                {
                    if (radioButton1.Checked) // однопалубный корабль
                        {
                            {
                                dataGridView1.CurrentCell.Style.BackColor = Color.Black; // при клике на ячейку красим её в черный цвет
                            try
                            {
                                dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Transparent; // делаем вокруг неё границы прозрачного цвета
                            }
                            catch
                            {}
                            try 
                            { 
                                dataGridView1[poskol - 1, posstr].Style.BackColor = Color.Transparent; 
                            }
                            catch
                            {}
                            try
                            {
                                dataGridView1[poskol, posstr + 1].Style.BackColor = Color.Transparent;
                            }
                            catch
                            {}
                            try
                            {
                                dataGridView1[poskol, posstr - 1].Style.BackColor = Color.Transparent;
                            }
                            catch
                            {}
                            try
                            {
                                dataGridView1[poskol + 1, posstr + 1].Style.BackColor = Color.Transparent;
                            }
                            catch
                            {}
                            try
                            {
                                dataGridView1[poskol - 1, posstr + 1].Style.BackColor = Color.Transparent;
                            }
                            catch
                            {}
                            try
                            {
                                dataGridView1[poskol - 1, posstr - 1].Style.BackColor = Color.Transparent;
                            }
                            catch
                            {}
                            try
                            {
                                dataGridView1[poskol + 1, posstr - 1].Style.BackColor = Color.Transparent;
                            }
                            catch
                            {}
                                a++; // Начинаем отсчёт расстановки
                                if (a == 4) radioButton1.Enabled = false; // Если счётчик равен 4, то делаем все элементы ниже не кликабельными
                                if (a == 4) dataGridView1.Enabled = false;
                                if (a == 4) radioButton2.Enabled = true;
                            }
                        }
                    if (radioButton2.Checked) // двухпалубный корабль
                    {
                        try // проверка на выход корабля за границы поля
                        {       
                            dataGridView1.CurrentCell.Style.BackColor = Color.Black;
                            dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Black;    
                        }
                                
                        catch  
                        {    
                            MessageBox.Show("Корабль вышел за границы поля");        
                            dataGridView1.CurrentCell.Style.BackColor = default; //если он вышел за границу перекрашиваем ячейку в цвет по умолчанию
                            return; 
                        }
                        try
                        {
                            dataGridView1[poskol + 2, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 2, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 2, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}

                        a++;
                        if (a == 3) radioButton2.Enabled = false;
                        if (a == 3) dataGridView1.Enabled = false;
                        if (a == 3) radioButton3.Enabled = true;

                    }
                    if (radioButton3.Checked) // трехпалубный корабль
                    {
                        try
                        {   
                            dataGridView1.CurrentCell.Style.BackColor = Color.Black;    
                            dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Black;
                            dataGridView1[poskol + 2, posstr].Style.BackColor = Color.Black;      
                        }                                
                        catch                                
                        {                                   
                            MessageBox.Show("Корабль вышел за границы поля");                                    
                            dataGridView1.CurrentCell.Style.BackColor = default;                                    
                            try                                   
                            {
                                if (dataGridView1[poskol + 1, posstr].Style.BackColor == Color.Black) 
                                    dataGridView1[poskol + 1, posstr].Style.BackColor = default;
                            }  
                            catch 
                            {}  
                            return;   
                        }
                        try
                        {
                            dataGridView1[poskol + 3, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 3, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 3, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 2, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 2, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        a++;
                        if (a == 2) radioButton4.Enabled = true;
                        if (a == 2) radioButton3.Enabled = false;
                        if (a == 2) dataGridView1.Enabled = false;
                    }
                    if (radioButton4.Checked) // четырёх палубный корабль
                    {                               
                        try                                
                        {                                   
                            dataGridView1.CurrentCell.Style.BackColor = Color.Black;                                    
                            dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Black;                                   
                            dataGridView1[poskol + 2, posstr].Style.BackColor = Color.Black;                                   
                            dataGridView1[poskol + 3, posstr].Style.BackColor = Color.Black;                                
                        }                               
                        catch                               
                        {                                    
                            MessageBox.Show("Корабль вышел за границы поля");                                    
                            dataGridView1.CurrentCell.Style.BackColor = default;                                   
                            try                  
                            {                                        
                                if (dataGridView1[poskol + 1, posstr].Style.BackColor == Color.Black)                                            
                                    dataGridView1[poskol + 1, posstr].Style.BackColor = default;                                   
                            }                                   
                            catch                                   
                            {}       
                            try                                    
                            {                                        
                                if (dataGridView1[poskol + 2, posstr].Style.BackColor == Color.Black)                                           
                                    dataGridView1[poskol + 2, posstr].Style.BackColor = default;                                   
                            }                                    
                            catch                                    
                            {}                                   
                            return;                                
                        }
                        try
                        {
                            dataGridView1[poskol + 4, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 4, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 4, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 3, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 3, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 2, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 2, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}

                        try
                        {
                            dataGridView1[poskol + 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        a++;
                        if (a == 1) radioButton4.Enabled = false;
                        if (a == 1) dataGridView1.Enabled = false;
                        if (a == 1) button1.Enabled = true;
                    }
                }


                if (radioButton6.Checked == true) // вертикальное расположение кораблей
                {
                    if (radioButton1.Checked) 
                    {
                        dataGridView1.CurrentCell.Style.BackColor = Color.Black;
                        try
                        {
                            dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}

                        try
                        {
                            dataGridView1[poskol + 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        a++;
                        if (a == 4) radioButton2.Enabled = true;
                        if (a == 4) radioButton1.Enabled = false;
                        if (a == 4) dataGridView1.Enabled = false;
                    }
                    if (radioButton2.Checked)
                    {   
                        try                              
                        {                                   
                            dataGridView1.CurrentCell.Style.BackColor = Color.Black;                                   
                            dataGridView1[poskol, posstr + 1].Style.BackColor = Color.Black;                               
                        }                               
                        catch                              
                        {
                            MessageBox.Show("Корабль вышел за границы поля");                                 
                            dataGridView1.CurrentCell.Style.BackColor = default;                                  
                            return;
                        }
                        try
                        {
                            dataGridView1[poskol + 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 2].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr + 2].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 2].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        a++;
                        if (a == 3) radioButton3.Enabled = true;
                        if (a == 3) radioButton2.Enabled = false;
                        if (a == 3) dataGridView1.Enabled = false;

                    }
                    if (radioButton3.Checked)
                    {                               
                        try                        
                        {                     
                            dataGridView1.CurrentCell.Style.BackColor = Color.Black;
                            dataGridView1[poskol, posstr + 1].Style.BackColor = Color.Black;
                            dataGridView1[poskol, posstr + 2].Style.BackColor = Color.Black;                           
                        }                        
                        catch                        
                        {                       
                            MessageBox.Show("Корабль вышел за границы поля");
                            dataGridView1.CurrentCell.Style.BackColor = default;                            
                            try                           
                            {
                                if (dataGridView1[poskol, posstr + 1].Style.BackColor == Color.Black)                                
                                    dataGridView1[poskol, posstr + 1].Style.BackColor = default;                                   
                            }                           
                            catch                           
                            {}                           
                            return;                           
                        }
                        try
                        {
                            dataGridView1[poskol + 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 2].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 3].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr + 3].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 2].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 3].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        a++;
                        if (a == 2) radioButton4.Enabled = true;
                        if (a == 2) radioButton3.Enabled = false;
                        if (a == 2) dataGridView1.Enabled = false;
                    }
                    if (radioButton4.Checked)
                    {                
                        try                      
                        {                     
                            dataGridView1.CurrentCell.Style.BackColor = Color.Black;                       
                            dataGridView1[poskol, posstr + 1].Style.BackColor = Color.Black;                         
                            dataGridView1[poskol, posstr + 2].Style.BackColor = Color.Black;                          
                            dataGridView1[poskol, posstr + 3].Style.BackColor = Color.Black;
                        }                      
                        catch                    
                        {                     
                            MessageBox.Show("Корабль вышел за границы поля");                         
                            dataGridView1.CurrentCell.Style.BackColor = default;                      
                            try                         
                            {                        
                                if (dataGridView1[poskol, posstr + 1].Style.BackColor == Color.Black)                 
                                    dataGridView1[poskol, posstr + 1].Style.BackColor = default;                         
                            }                          
                            catch                           
                            {}                         
                            try         
                            {
                                if (dataGridView1[poskol, posstr + 2].Style.BackColor == Color.Black)                               
                                    dataGridView1[poskol, posstr + 2].Style.BackColor = default;                                   
                            }                           
                            catch
                            {}                            
                            return;                           
                        }
                        try
                        {
                            dataGridView1[poskol + 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 2].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 3].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol + 1, posstr + 4].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol, posstr + 4].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr - 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 1].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 2].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 3].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        try
                        {
                            dataGridView1[poskol - 1, posstr + 4].Style.BackColor = Color.Transparent;
                        }
                        catch
                        {}
                        a++;
                        if (a == 1) radioButton4.Enabled = false;
                        if (a == 1) dataGridView1.Enabled = false;
                        if (a == 1) button1.Enabled = true;
                    }
                }
            }
            else MessageBox.Show("Здесь уже есть корабль"); // Вывод если попали на корабль или в границу
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) // событие на клик по ячейки 
        {
            if (dataGridView2.CurrentCell.Style.BackColor == default || dataGridView2.CurrentCell.Style.BackColor == Color.Transparent) schet++; // если попали в эти ячейки, то прибавляем счётчик ходов
            if (dataGridView2.CurrentCell.Style.BackColor == default) Bot.shoot(dataGridView1, rastanovka); // если промахнулись, то бот начинает стрелять
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Transparent) dataGridView2.CurrentCell.Style.BackColor = Color.Red; //перекраска ячейки при попадании
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Red) dataGridView2.CurrentCell.Style.BackColor = Color.Red; // при повторном нажатии на ячейку она не перекрашивается
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Crimson) dataGridView2.CurrentCell.Style.BackColor = Color.Crimson; // при повторном нажатии на ячейку она не перекрашивается
            if (dataGridView2.CurrentCell.Style.BackColor == default) dataGridView2.CurrentCell.Style.BackColor = Color.Aqua; //перекраска ячейки при промахе
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Aqua) textBox4.Text = "Мимо"; // вывод в текст бокс о промахе
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Red) textBox4.Text = "Попал"; // вывод в текст бокс о попадании
            //if (dataGridView2.CurrentCell.Style.BackColor == Color.Aqua || dataGridView2.CurrentCell.Style.BackColor == Color.Crimson) dataGridView2.CurrentCell.ReadOnly = true;
            Bot.ubil(dataGridView2, textBox1, textBox2); // при потаплении корабля
            textBox1.Text = Convert.ToString(schet); // записываем счётчик ходов
        }

        private void korabli_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true; // показываем groupbox
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView2.ClearSelection(); // очистка выделения ячейки
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection(); // очистка выделения ячейки
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            a = 0; // обнуляем счётчик
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            a = 0; // обнуляем счётчик
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            a = 0; // обнуляем счётчик
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
        }
    }
}
