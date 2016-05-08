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
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
            if (Serial.collectorsList[listBox1.SelectedIndex].Listmarks == null)
            {
                MessageBox.Show("У данного коллекционера еще нет марок");
            }
            else
            {
                foreach (Marka mark in Serial.collectorsList[listBox1.SelectedIndex].Listmarks)
                 listBox2.Items.Add(mark.Special);
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
    }
}

