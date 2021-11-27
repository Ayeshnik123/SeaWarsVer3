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
        int a = 0;
        int schet = 0;
        public Pole()
        {
            InitializeComponent();
        }

        private void Pole_Load(object sender, EventArgs e)
        {
            if (File.Exists("result.docx")) textBox3.Text = File.ReadAllText("result.docx");
            //button1.Enabled = false;
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
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
            dataGridView1.ColumnCount = 9;
            dataGridView1.RowCount = 10;
            dataGridView1.Columns[0].HeaderText = "А";
            dataGridView1.Columns[1].HeaderText = "Б";
            dataGridView1.Columns[2].HeaderText = "В";
            dataGridView1.Columns[3].HeaderText = "Г";
            dataGridView1.Columns[4].HeaderText = "Д";
            dataGridView1.Columns[5].HeaderText = "Е";
            dataGridView1.Columns[6].HeaderText = "Ж";
            dataGridView1.Columns[7].HeaderText = "З";
            dataGridView1.Columns[8].HeaderText = "И";
            dataGridView1.Columns[9].HeaderText = "К";
            dataGridView1.Rows[0].HeaderCell.Value = "1";
            dataGridView1.Rows[1].HeaderCell.Value = "2";
            dataGridView1.Rows[2].HeaderCell.Value = "3";
            dataGridView1.Rows[3].HeaderCell.Value = "4";
            dataGridView1.Rows[4].HeaderCell.Value = "5";
            dataGridView1.Rows[5].HeaderCell.Value = "6";
            dataGridView1.Rows[6].HeaderCell.Value = "7";
            dataGridView1.Rows[7].HeaderCell.Value = "8";
            dataGridView1.Rows[8].HeaderCell.Value = "9";
            dataGridView1.Rows[9].HeaderCell.Value = "10";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //второе поле
            dataGridView2.ColumnCount = 10;
            dataGridView2.RowCount = 10;
            dataGridView2.Columns[0].HeaderText = "А";
            dataGridView2.Columns[1].HeaderText = "Б";
            dataGridView2.Columns[2].HeaderText = "В";
            dataGridView2.Columns[3].HeaderText = "Г";
            dataGridView2.Columns[4].HeaderText = "Д";
            dataGridView2.Columns[5].HeaderText = "Е";
            dataGridView2.Columns[6].HeaderText = "Ж";
            dataGridView2.Columns[7].HeaderText = "З";
            dataGridView2.Columns[8].HeaderText = "И";
            dataGridView2.Columns[9].HeaderText = "К";
            dataGridView2.Rows[0].HeaderCell.Value = "1";
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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Visible = false;
            button1.Visible = true;
            //button1.Enabled = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[i, j].Style.BackColor = default;
                }
            for (int i = 0; i < dataGridView2.RowCount; i++)
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView2[i, j].Style.BackColor = default;
                }
            groupBox1.Visible = false;
            korabli.Visible = true;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            radioButton1.Enabled = true;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            a = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            Bot.Pole(dataGridView2, rastanovka);
            groupBox1.Visible = false;
            korabli.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = true;
            button1.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int poskol = dataGridView1.CurrentCell.ColumnIndex;
            int posstr = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.CurrentCell.Style.BackColor == default
                /* && dataGridView1[poskol + 1,posstr].Style.BackColor == default && dataGridView1[poskol - 1, posstr].Style.BackColor == default
                && dataGridView1[poskol, posstr + 1].Style.BackColor == default && dataGridView1[poskol, posstr - 1].Style.BackColor == default
                && dataGridView1[poskol+ 1, posstr + 1].Style.BackColor == default && dataGridView1[poskol -1, posstr + 1].Style.BackColor == default
                && dataGridView1[poskol - 1, posstr - 1].Style.BackColor == default && dataGridView1[poskol + 1, posstr - 1].Style.BackColor == default*/)
            {
                if (radioButton5.Checked == true)
                {
                    if (radioButton1.Checked)
                        {
                            {
                                dataGridView1.CurrentCell.Style.BackColor = Color.Black;
                                /*dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Gray;
                                dataGridView1[poskol - 1, posstr].Style.BackColor = Color.Gray;
                                dataGridView1[poskol, posstr + 1].Style.BackColor = Color.Gray;
                                dataGridView1[poskol, posstr - 1].Style.BackColor = Color.Gray;
                                dataGridView1[poskol + 1, posstr + 1].Style.BackColor = Color.Gray;
                                dataGridView1[poskol - 1, posstr + 1].Style.BackColor = Color.Gray;
                                dataGridView1[poskol - 1, posstr - 1].Style.BackColor = Color.Gray;
                                dataGridView1[poskol + 1, posstr - 1].Style.BackColor = Color.Gray;*/
                                a++;
                                if (a == 4) radioButton1.Enabled = false;
                                if (a == 4) dataGridView1.Enabled = false;
                                if (a == 4) radioButton2.Enabled = true;
                            }
                        }
                    if (radioButton2.Checked)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.CurrentCell.Style.BackColor = Color.Black;
                                    dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Black;
                                }
                                catch
                                {
                                    MessageBox.Show("Корабль вышел за границы поля");
                                    dataGridView1.CurrentCell.Style.BackColor = default;
                                    return;
                                }
                            }
                        a++;
                        if (a == 3) radioButton2.Enabled = false;
                        if (a == 3) dataGridView1.Enabled = false;
                        if (a == 3) radioButton3.Enabled = true;

                    }
                    if (radioButton3.Checked)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
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
                                    {

                                    }
                                    return;
                                }
                            }
                        a++;
                        if (a == 2) radioButton4.Enabled = true;
                        if (a == 2) radioButton3.Enabled = false;
                        if (a == 2) dataGridView1.Enabled = false;
                    }
                    if (radioButton4.Checked)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
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
                                    {

                                    }
                                    try
                                    {
                                        if (dataGridView1[poskol + 2, posstr].Style.BackColor == Color.Black)
                                            dataGridView1[poskol + 2, posstr].Style.BackColor = default;
                                    }
                                    catch
                                    {

                                    }
                                    return;
                                }
                            }
                        a++;
                        if (a == 1) radioButton4.Enabled = false;
                        if (a == 1) dataGridView1.Enabled = false;
                        if (a == 1) button1.Enabled = true;
                    }
                }


                if (radioButton6.Checked == true)
                {
                    if (radioButton1.Checked)
                    {
                        dataGridView1.CurrentCell.Style.BackColor = Color.Black;
                        a++;
                        if (a == 4) radioButton2.Enabled = true;
                        if (a == 4) radioButton1.Enabled = false;
                        if (a == 4) dataGridView1.Enabled = false;
                    }
                    if (radioButton2.Checked)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
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
                            }
                        a++;
                        if (a == 3) radioButton3.Enabled = true;
                        if (a == 3) radioButton2.Enabled = false;
                        if (a == 3) dataGridView1.Enabled = false;

                    }
                    if (radioButton3.Checked)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
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
                                    {

                                    }
                                    return;
                                }
                            }
                        a++;
                        if (a == 2) radioButton4.Enabled = true;
                        if (a == 2) radioButton3.Enabled = false;
                        if (a == 2) dataGridView1.Enabled = false;
                    }
                    if (radioButton4.Checked)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
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
                                    {

                                    }
                                    try
                                    {
                                        if (dataGridView1[poskol, posstr + 2].Style.BackColor == Color.Black)
                                            dataGridView1[poskol, posstr + 2].Style.BackColor = default;
                                    }
                                    catch
                                    {

                                    }
                                    return;
                                }
                            }
                        a++;
                        if (a == 1) radioButton4.Enabled = false;
                        if (a == 1) dataGridView1.Enabled = false;
                        if (a == 1) button1.Enabled = true;
                    }
                }
            }
            else MessageBox.Show("Здесь уже есть корабль");
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Transparent) dataGridView2.CurrentCell.Style.BackColor = Color.Red;
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Red) dataGridView2.CurrentCell.Style.BackColor = Color.Red;
            else dataGridView2.CurrentCell.Style.BackColor = Color.Aqua;
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Aqua) textBox4.Text = "Мимо";
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Red) textBox4.Text = "Попал";
            if (dataGridView2.CurrentCell.Style.BackColor == Color.Aqua) Bot.shoot(dataGridView1, rastanovka);
            Bot.ubil(dataGridView2, textBox1, textBox2);
            schet++;
            textBox1.Text = Convert.ToString(schet);
        }

        private void korabli_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView2.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            a = 0;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            a = 0;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            a = 0;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
        }
    }
}
