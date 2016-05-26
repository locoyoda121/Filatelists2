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
    public partial class AllCollectors : Form
    {
        private int n;      //определение критерия поиска

        /// <summary>
        /// Открытие и заполнение таблицы.
        /// </summary>
        public AllCollectors()
        {
            InitializeComponent();
            FillGridView();
        }

        /// <summary>
        /// Заполнение данными таблицу и добавление категории поиска.
        /// </summary>
        public void FillGridView()
        {
            collectorGridView.Rows.Clear();
            Serial.OpenCollector();
            foreach (Collector collector in Serial.collectorsList)
                collectorGridView.Rows.Add(collector.Id, collector.Name, collector.Country, collector.Phone);

            searchBox.Items.Add("По стране");
            searchBox.Items.Add("По имени");
            searchBox.Items.Add("По телефону");
        }

        /// <summary>
        /// Кнопка "На главную".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Редактирование телефона коллекционера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collectorGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = collectorGridView.Rows[collectorGridView.SelectedCells[0].RowIndex];
            string a = Convert.ToString(selectedRow.Cells["phone"].Value);
            try
            {
                Convert.ToInt64(a);
            }
            catch (FormatException)
            {
                MessageBox.Show("В телефоне могут быть только числа.");
            }

            foreach (Collector coll in Serial.collectorsList)
            {
                if (coll.Phone == a)
                {
                    MessageBox.Show("Этот коллекционер уже существует.");
                    selectedRow.Cells["phone"].Value = "";
                }
                else
                {
                    continue;
                }

            }

            Serial.collectorsList.Find(coll => coll.Id == Convert.ToInt32(selectedRow.Cells["id"].Value)).Phone = a;

        }

        /// <summary>
        /// Кнопка "Сохранить изменения".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savebutton_Click(object sender, EventArgs e)
        {
            Serial.SaveCollector();
        }

        /// <summary>
        /// Определение критерия поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "По стране") n = 1;
            if (searchBox.Text == "По имени") n = 2;
            if (searchBox.Text == "По телефону") n = 3;
            searchtextBox.Visible = true;
        }

        /// <summary>
        /// Заполнение данными таблицу после поиска.
        /// </summary>
        /// /// <param name="a"></param>
        private void FillGridViewSearch(IEnumerable<Collector> a)
        {
            collectorGridView.Rows.Clear();
            foreach (Collector coll in a)
                collectorGridView.Rows.Add(coll.Id, coll.Name, coll.Country, coll.Phone);
        }

        /// <summary>
        /// Кнопка "Поиск".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            FillGridViewSearch(SearchText());
        }

        /// <summary>
        /// Поиск.
        /// </summary>
        private ListOfCollectors SearchText()
        {
            ListOfCollectors searchList = new ListOfCollectors();
            if (searchtextBox.Text.Length == 0)
            {
                MessageBox.Show("Вы ничего не ввели");
            }
            else
            {
                foreach (Collector coll in Serial.collectorsList)
                {
                    if ((n == 1 && coll.Country.ToLower().Contains(searchtextBox.Text.ToLower())) || (n == 2 && coll.Name.ToLower().Contains(searchtextBox.Text.ToLower())) || (n == 3 && coll.Phone.ToString().ToLower().Contains(searchtextBox.Text.ToLower())))
                    {
                        searchList.Add(coll);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return searchList;
        }

        /// <summary>
        /// Кнопка "Удалить коллекционера".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {

            Serial.OpenCollector();
            Serial.OpenMark();
            DataGridViewRow selectedRow = collectorGridView.Rows[collectorGridView.SelectedCells[0].RowIndex];

            foreach (Marka mark in Serial.collectorsList.Find(coll => coll.Id == Convert.ToInt32(selectedRow.Cells["id"].Value)).Listmarks)
            {
                Serial.marksList.Remove(Serial.marksList.Find(marka => marka.Coll.Name == Serial.collectorsList.Find(coll => coll.Id == Convert.ToInt32(selectedRow.Cells["id"].Value)).Name));
            }

            Serial.collectorsList.Find(coll => coll.Id == Convert.ToInt32(selectedRow.Cells["id"].Value)).Listmarks.Clear();
            Serial.collectorsList.Remove(Serial.collectorsList.Find(coll => coll.Id == Convert.ToInt32(selectedRow.Cells["id"].Value)));

            Serial.SaveCollector();
            Serial.SaveMark();
            FillGridView();


        }

        /// <summary>
        /// Появление кнопки "Удалить коллекционера" после нажатия на ячейку коллекционера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collectorGridView_Click(object sender, EventArgs e)
        {
            deleteButton.Visible = true;
        }




    }
}



