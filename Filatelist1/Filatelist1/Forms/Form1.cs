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

namespace Filatelist1
{
    [Serializable]
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка меню "Добавить..." -> "Коллекционера". Открывает окно добавления коллекционера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void коллекционераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCollector AC = new AddCollector();
            AC.Show();
        }

        /// <summary>
        /// Кнопка меню "Добавить..." -> "Марку". Открывает окно добавления марки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void маркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMark AM = new AddMark();
            AM.Show();
        }

        /// <summary>
        /// Кнопка меню "Выход".Закрывает программу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        /// <summary>
        /// Обновление списков марок и коллекционеров.
        /// </summary>
        private void RefreshAll()
        {
            Serial.OpenMark();
            Serial.OpenCollector();
        }

        /// <summary>
        /// Обновление/заполнение списка коллекционеров в главном меню.
        /// </summary>
        public void RefreshForm()
        {
            RefreshAll();
            foreach (Collector name in Serial.collectorsList)
            {
                listBox1.Items.Add(name.Name);
            }
            listBox2.Items.Clear();
        }

        /// <summary>
        /// Появление списка марок в listBox2, при выборе коллекционера в listBox1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshAll();
            listBox2.Items.Clear();
            ClearLabel();

            try
            {

                if (Serial.collectorsList[listBox1.SelectedIndex].Listmarks.Count == 0)
                {
                    MessageBox.Show("У данного коллекционера еще нет марок");
                }
                else
                {
                    int sum = 0;

                    foreach (Marka mark in Serial.collectorsList[listBox1.SelectedIndex].Listmarks)
                    {
                        listBox2.Items.Add(mark.Special);
                        sum += Convert.ToInt32(mark.Nominal);
                    }
                    priceLabel.Text = sum.ToString();
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        /// <summary>
        /// Обновление списка коллекционеров в главном меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            RefreshForm();
        }

        /// <summary>
        /// Кнопка меню "Марки". Открывает окно общего списка марок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void маркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMark AM = new AllMark();
            AM.Show();
        }

        /// <summary>
        /// Кнопка меню "Коллекционеры". Открывает окно общего списка коллекционеров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void коллекционерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCollectors AC = new AllCollectors();
            AC.Show();
        }

        /// <summary>
        /// Появление информации о марке, при выборе марки в listBox2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
            try
            {
                yearLabel.Text = Serial.collectorsList[Serial.collectorsList[listBox1.SelectedIndex].Id].Listmarks[Serial.marksList[listBox2.SelectedIndex].Id].Year;
                nominalLabel.Text = Serial.collectorsList[Serial.collectorsList[listBox1.SelectedIndex].Id].Listmarks[Serial.marksList[listBox2.SelectedIndex].Id].Nominal;
                countryLabel.Text = Serial.collectorsList[Serial.collectorsList[listBox1.SelectedIndex].Id].Listmarks[Serial.marksList[listBox2.SelectedIndex].Id].Country;
                tirageLabel.Text = Serial.collectorsList[Serial.collectorsList[listBox1.SelectedIndex].Id].Listmarks[Serial.marksList[listBox2.SelectedIndex].Id].Tirage;
                specialLabel.Text = Serial.collectorsList[Serial.collectorsList[listBox1.SelectedIndex].Id].Listmarks[Serial.marksList[listBox2.SelectedIndex].Id].Special;
                deleteButton.Visible = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                ClearLabel();
            }
        }

        /// <summary>
        /// Кнопка меню "О программе...". Открывает окно информации про программу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About Ab = new About();
            Ab.Show();
        }

        /// <summary>
        /// Очистка полей.
        /// </summary>
        private void ClearLabel()
        {
            yearLabel.Text = "";
            nominalLabel.Text = "";
            countryLabel.Text = "";
            tirageLabel.Text = "";
            specialLabel.Text = "";
            deleteButton.Visible = false;
            priceLabel.Text = "";
        }

        /// <summary>
        /// Кнопка "Удалить марку из коллекции".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Serial.OpenCollector();
            Serial.OpenMark();
            Serial.collectorsList[Serial.collectorsList[listBox1.SelectedIndex].Id].Listmarks.Remove(Serial.collectorsList[listBox1.SelectedIndex].Listmarks[Serial.marksList[listBox2.SelectedIndex].Id]);
            Serial.marksList[listBox2.SelectedIndex].Coll.Name = "Сохранено в базе";
            Serial.SaveMark();
            Serial.SaveCollector();
        }

        /// <summary>
        /// Кнопка меню "Сохранить в ТХТ". Сохраняет базу марок в локальном диске D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьВTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("d:\\ListOfMarks.txt", false, Encoding.UTF8))
            {
                foreach (Marka mark in Serial.marksList)
                {
                    writer.WriteLine(mark.ToString());
                }
            }
            MessageBox.Show("Сохранение прошло успешно.");
        }

        /// <summary>
        /// Кнопка меню "Помощь". Открывает окно помощи программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm HF = new HelpForm();
            HF.Show();

        }
    }
}

