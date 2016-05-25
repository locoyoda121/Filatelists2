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
    public partial class AllMark : Form
    {
        private int n;
                

        public AllMark()
        {
            InitializeComponent();
            FillGridView();

        }

        public void FillGridView()
        {
            MarksGridView.Rows.Clear();
            Serial.OpenMark();
            foreach (Marka marka in Serial.marksList)
                MarksGridView.Rows.Add(marka.Id, marka.Country, marka.Year, marka.Nominal, marka.Tirage, marka.Special, marka.Coll.Name);

            searchBox.Items.Add("По году");
            searchBox.Items.Add("По стоимости");
            searchBox.Items.Add("По тиражу");
            searchBox.Items.Add("По коллекционеру");
            searchBox.Items.Add("По теме");
            searchBox.Items.Add("По стране");

        }

        private void main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            
            
            if (searchBox.Text == "По году") n = 1;
            if (searchBox.Text == "По стоимости") n = 2;
            if (searchBox.Text == "По тиражу") n = 3;
            if (searchBox.Text == "По коллекционеру") n = 4;
            if (searchBox.Text == "По теме") n = 5;
            if (searchBox.Text == "По стране") n = 6;
        }
        
        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {             
            switch (n)
            {
                case 1:
                    VisDigits();
                    textbox.Visible = false;
                    break;
                case 2:
                    VisDigits();
                    textbox.Visible = false;
                    break;
                case 3:
                    VisDigits();
                    textbox.Visible = false;
                    break;
                case 4:
                    NonVisDigits();
                    textbox.Visible = true;
                    break;
                case 5:
                    NonVisDigits();
                    textbox.Visible = true;
                    break;
                case 6:
                    NonVisDigits();
                    textbox.Visible = true;
                    break;
            }
        }

        private void mintextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(mintextBox.Text, "^[0-9]*$"))
            {
                mintextBox.Text = string.Empty;
                MessageBox.Show("Можно вводить только цифры.");
            }
        }

        private void VisDigits()
        {
            label1.Visible = true;
            label2.Visible = true;
            mintextBox.Visible = true;
            maxtextBox.Visible = true;
        }
        private void NonVisDigits()
        {
            label1.Visible = false;
            label2.Visible = false;
            mintextBox.Visible = false;
            maxtextBox.Visible = false;
        }

        private void maxtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(maxtextBox.Text, "^[0-9]*$"))
            {
                maxtextBox.Text = string.Empty;
                MessageBox.Show("Можно вводить только цифры.");
            }
        }

        private void FillGridViewSearch(IEnumerable<Marka> a)
        {
            MarksGridView.Rows.Clear();
            foreach (Marka marka in a)
                MarksGridView.Rows.Add(marka.Id,marka.Country, marka.Year, marka.Nominal, marka.Tirage, marka.Special, marka.Coll.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(n==4 || n == 5 || n == 6)
            {
                FillGridViewSearch(SearchText());
            }
            else
            {
                FillGridViewSearch(SearchDigits());
            }
            
        }

        private ListOfMarks SearchText()
        {
            ListOfMarks searchList = new ListOfMarks();
            if (textbox.Text.Length == 0)
            {
                MessageBox.Show("Вы ничего не ввели");
            }
            else
            {
                foreach(Marka mark in Serial.marksList)
                {
                    if ((n==4 && mark.Coll.Name.ToLower().Contains(textbox.Text.ToLower())) || (n == 5 && mark.Special.ToLower().Contains(textbox.Text.ToLower())) || (n == 6 && mark.Country.ToLower().Contains(textbox.Text.ToLower())))
                    {
                        searchList.Add(mark);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return searchList;
        }

        private IEnumerable<Marka> SearchDigits()
        {
            
            if (mintextBox.Text.Length == 0 || maxtextBox.Text.Length == 0)
            {
                MessageBox.Show("Вы ничего не ввели");
                return null;
            }
            else
            {
                switch (n)
                {
                    case 1:                        
                    var searchList = Serial.marksList.Where(mark => Convert.ToInt32(mark.Year) >= Convert.ToInt32(mintextBox.Text) && Convert.ToInt32(mark.Year) <= Convert.ToInt32(maxtextBox.Text));
                        return searchList;
                    case 2:
                        searchList = Serial.marksList.Where(mark => Convert.ToInt32(mark.Nominal) >= Convert.ToInt32(mintextBox.Text) && Convert.ToInt32(mark.Nominal) <= Convert.ToInt32(maxtextBox.Text));
                        return searchList;
                    case 3:
                        searchList = Serial.marksList.Where(mark => Convert.ToInt32(mark.Tirage) >= Convert.ToInt32(mintextBox.Text) && Convert.ToInt32(mark.Tirage) <= Convert.ToInt32(maxtextBox.Text));
                        return searchList;
                    default:
                        return null;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Serial.OpenMark();
            DataGridViewRow selectedRow = MarksGridView.Rows[MarksGridView.SelectedCells[0].RowIndex];
            Serial.marksList.Remove(Serial.marksList.Find(mark => mark.Id == Convert.ToInt32(selectedRow.Cells["id"].Value)));
            Serial.SaveMark();
            FillGridView();
        }

        private void MarksGridView_Click(object sender, EventArgs e)
        {
            deleteButton.Visible = true;
        }
    }
}
