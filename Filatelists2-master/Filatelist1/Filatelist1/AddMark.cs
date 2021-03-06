﻿using System;
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
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            else if (!CheckYear())
            {
                MessageBox.Show("Введена неверная дата");
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
            Form1.ActiveForm.Refresh();
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
        /// Проверка на вводимую дату.
        /// </summary>
        /// <returns></returns>
        private bool CheckYear()
        {
            if (Convert.ToInt32(yearBox.Text) > DateTime.Now.Year || Convert.ToInt32(yearBox.Text)<0)
            {
                yearBox.Text = string.Empty;
                return false;
            }
            else
                return true;
        }     
        
        private void nominalBox_TextChanged(object sender, EventArgs e)
        {          
            if (!System.Text.RegularExpressions.Regex.IsMatch(nominalBox.Text, "^[0-9]*$"))
            {
                nominalBox.Text = string.Empty;
                MessageBox.Show("Можно вводить только цифры.");
            }
        }

        private void countryBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(countryBox.Text, "^[a-zA-Zа-яА-Я]*$"))
            {
                countryBox.Text = string.Empty;
                MessageBox.Show("Можно вводить только буквы.");
            }
        }

        private void tirageBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tirageBox.Text, "^[0-9]*$"))
            {
                tirageBox.Text = string.Empty;
                MessageBox.Show("Можно вводить только цифры.");
            }
        }

        private void yearBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(yearBox.Text, "^[0-9]*$"))
            {
                yearBox.Text = string.Empty;
                MessageBox.Show("Можно вводить только цифры.");
            }

        }
    }
}
