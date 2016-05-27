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
        Marka temp;         //буферная переменная
        private int id;     //номер марки в общем списке

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
            {
                collectorBox.Items.Add(name.Name);
            }
        }

        /// <summary>
        /// Кнопка "Добавить марку".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Очистка всех полей.
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
        /// Проверка на правильность вводимой даты.
        /// </summary>
        /// <returns></returns>
        private bool CheckYear()
        {
            if (Convert.ToInt32(yearBox.Text) > DateTime.Now.Year || Convert.ToInt32(yearBox.Text) < 1800)
            {
                yearBox.Text = string.Empty;
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Проверка правильности ввода в графе "Стоимость".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nominalBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(nominalBox.Text, "^[0-9]*$"))
            {
                nominalBox.Text = string.Empty;
                MessageBox.Show("Можно вводить только цифры.");
            }
        }

        /// <summary>
        /// Проверка правильности ввода в графе "Страна".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countryBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(countryBox.Text, "^[a-zA-Zа-яА-Я]*$"))
            {
                countryBox.Text = string.Empty;
                MessageBox.Show("Можно вводить только буквы.");
            }
        }

        /// <summary>
        /// Проверка правильности ввода в графе "Тираж".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tirageBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tirageBox.Text, "^[0-9]*$"))
            {
                tirageBox.Text = string.Empty;
                MessageBox.Show("Можно вводить только цифры.");
            }
        }

        /// <summary>
        /// Проверка правильности ввода в графе "Год".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
