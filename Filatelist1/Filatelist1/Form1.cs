using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filatelist1
{
    [Serializable]
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void коллекционераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCollector AC = new AddCollector();
            AC.Show();
        }

        private void маркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMark AM = new AddMark();
            AM.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Refresh();
            RefreshForm();
        }

        private void RefreshAll()
        {
            Serial.OpenMark();
            Serial.OpenCollector();
        }

        public void RefreshForm()
        {

            RefreshAll();
            foreach (Collector name in Serial.collectorsList)
                listBox1.Items.Add(name.Name);
            listBox2.Items.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            RefreshAll();
            listBox2.Items.Clear();
            ClearLabel();

            try {

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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            RefreshForm();
        }

        private void маркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMark AM = new AllMark();
            AM.Show();

        }

        private void коллекционерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCollectors AC = new AllCollectors();
            AC.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
           try {
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About Ab = new About();
            Ab.Show();
        }
         
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

        private void button2_Click(object sender, EventArgs e)
        {
            Serial.OpenCollector();
            Serial.OpenMark();
            Serial.collectorsList[Serial.collectorsList[listBox1.SelectedIndex].Id].Listmarks.Remove(Serial.collectorsList[listBox1.SelectedIndex].Listmarks[Serial.marksList[listBox2.SelectedIndex].Id]);
            Serial.marksList[listBox2.SelectedIndex].Coll.Name = "Сохранено в базе";
            Serial.SaveMark();
            Serial.SaveCollector();
        }
    }
}

