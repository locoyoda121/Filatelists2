using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Filatelist1
{
    [Serializable]
    public partial class AddMark : Form
    {
        Marka temp;
        private int id;
               
        public AddMark()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Запуск формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMark_Load(object sender, EventArgs e)
        {
            Serial.OpenMark();
            Serial.OpenCollector();
            foreach (Collector name in Serial.collectorsList)
                collectorBox.Items.Add(name.Name);
                      
            collectorBox.SelectedIndex = -1;
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            else if (IsDigits(nominalBox.Text) || IsDigits(yearBox.Text) || IsDigits(tirageBox.Text)||!IsDigits(countryBox.Text))
            {
                 MessageBox.Show("Неверный ввод.");
                return;
            }

            else
            {
                Serial.OpenCollector(); 
                Serial.OpenMark();
                id = Serial.marksList.Count;
                temp = new Marka(countryBox.Text, nominalBox.Text, yearBox.Text, tirageBox.Text,
                        specialBox.Text, id, Serial.collectorsList[collectorBox.SelectedIndex]);
                Serial.marksList.Add(temp);
                Serial.collectorsList[Serial.collectorsList[collectorBox.SelectedIndex].Id].Listmarks.Add(temp);
                MessageBox.Show("Марка добавлена");
                
            }

            Serial.SaveCollector();
            Serial.SaveMark();
            this.ClearAll();
            this.Close();
        }

        /// <summary>
        /// Кнопка "Отмена".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Оччистка всех полей.
        /// </summary>
        private void ClearAll()
        {
            collectorBox.SelectedIndex = -1;
            countryBox.Text = "";
            yearBox.Text = "";
            nominalBox.Text = "";
            tirageBox.Text = "";
            specialBox.Text = "";
        }

        /// <summary>
        /// Проверка на то, заполнены ли поля.
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (collectorBox.SelectedIndex == -1) return false;
            if (String.IsNullOrWhiteSpace(countryBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(yearBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(nominalBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(tirageBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(specialBox.Text)) return false;
            return true;
        }

        /// <summary>
        /// Проверка на ввод данных.
        /// </summary>
        /// <param name="s"></param>
        private bool IsDigits(string s)
        {
            Regex pattern = new Regex(@"[0-9]");
            if (pattern.IsMatch(s))
                return true;
            else
                return false;
        }
    }
}
