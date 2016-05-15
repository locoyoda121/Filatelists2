using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Filatelist1
{
    [Serializable]
    public partial class AddCollector : Form
    {
       
        Collector temp;
        private int id;
        public AddCollector()
        {
            InitializeComponent();
        }
                
        /// <summary>
        /// Запуск формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCollector_Load(object sender, EventArgs e)
        {
           Serial.OpenCollector();
        }

        /// <summary>
        /// Кнопка "Добавить": добавление коллекционера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!this.Check())
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else if (nameTextBox.Text.Length<=1)
            {
                MessageBox.Show("Имя не может быть одной буквой.");
                return;
            }

            else if (!IsDigits(phoneTextBox.Text) || IsDigits(countryTextBox.Text) || IsDigits(nameTextBox.Text))
            {
                MessageBox.Show("Неверный ввод.");
                return;
            }

            else
            {
                id = Serial.collectorsList.Count;
                temp = new Collector(nameTextBox.Text, countryTextBox.Text, phoneTextBox.Text, id);
                if (Serial.collectorsList.IsCopy(temp))
                  {
                    MessageBox.Show("Этот коллекционер уже существует.");
                    return;
                  }
                else
                  {
                        Serial.collectorsList.Add(temp);
                        MessageBox.Show("Клиент добавлен");
                        Serial.SaveCollector();
                  }
                
             }

            this.ClearAll();
            this.Close();
        }
    
        /// <summary>
        /// Кнопка "Отмена".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Проверка на то, заполнены ли поля.
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (String.IsNullOrWhiteSpace(nameTextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(countryTextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(phoneTextBox.Text)) return false;
            return true;
        }

        /// <summary>
        /// Очистка всех полей.
        /// </summary>
        private void ClearAll()
        {
            nameTextBox.Text = "";
            countryTextBox.Text = "";
            phoneTextBox.Text = "";
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
