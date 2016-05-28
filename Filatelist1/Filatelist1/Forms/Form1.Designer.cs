namespace Filatelist1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коллекционераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маркиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коллекционерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.nominalLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.tirageLabel = new System.Windows.Forms.Label();
            this.specialLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.маркиToolStripMenuItem,
            this.коллекционерыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.сохранитьВTXTToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.маркуToolStripMenuItem,
            this.коллекционераToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // маркуToolStripMenuItem
            // 
            this.маркуToolStripMenuItem.Name = "маркуToolStripMenuItem";
            this.маркуToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.маркуToolStripMenuItem.Text = "Марку";
            this.маркуToolStripMenuItem.Click += new System.EventHandler(this.маркуToolStripMenuItem_Click);
            // 
            // коллекционераToolStripMenuItem
            // 
            this.коллекционераToolStripMenuItem.Name = "коллекционераToolStripMenuItem";
            this.коллекционераToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.коллекционераToolStripMenuItem.Text = "Коллекционера";
            this.коллекционераToolStripMenuItem.Click += new System.EventHandler(this.коллекционераToolStripMenuItem_Click);
            // 
            // сохранитьВTXTToolStripMenuItem
            // 
            this.сохранитьВTXTToolStripMenuItem.Name = "сохранитьВTXTToolStripMenuItem";
            this.сохранитьВTXTToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитьВTXTToolStripMenuItem.Text = "Сохранить в текстовый файл";
            this.сохранитьВTXTToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВTXTToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // маркиToolStripMenuItem
            // 
            this.маркиToolStripMenuItem.Name = "маркиToolStripMenuItem";
            this.маркиToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.маркиToolStripMenuItem.Text = "Марки";
            this.маркиToolStripMenuItem.Click += new System.EventHandler(this.маркиToolStripMenuItem_Click);
            // 
            // коллекционерыToolStripMenuItem
            // 
            this.коллекционерыToolStripMenuItem.Name = "коллекционерыToolStripMenuItem";
            this.коллекционерыToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.коллекционерыToolStripMenuItem.Text = "Коллекционеры";
            this.коллекционерыToolStripMenuItem.Click += new System.EventHandler(this.коллекционерыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 290);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(147, 27);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(152, 264);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Год издания: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Стоимость(грн): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тираж: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Тема: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Обновить страницу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Страна: ";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(410, 40);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(0, 13);
            this.yearLabel.TabIndex = 16;
            // 
            // nominalLabel
            // 
            this.nominalLabel.AutoSize = true;
            this.nominalLabel.Location = new System.Drawing.Point(410, 75);
            this.nominalLabel.Name = "nominalLabel";
            this.nominalLabel.Size = new System.Drawing.Size(0, 13);
            this.nominalLabel.TabIndex = 17;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(410, 102);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(0, 13);
            this.countryLabel.TabIndex = 18;
            // 
            // tirageLabel
            // 
            this.tirageLabel.AutoSize = true;
            this.tirageLabel.Location = new System.Drawing.Point(410, 128);
            this.tirageLabel.Name = "tirageLabel";
            this.tirageLabel.Size = new System.Drawing.Size(0, 13);
            this.tirageLabel.TabIndex = 19;
            // 
            // specialLabel
            // 
            this.specialLabel.AutoSize = true;
            this.specialLabel.Location = new System.Drawing.Point(410, 154);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(0, 13);
            this.specialLabel.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Общая стоимость: ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(255, 306);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 13);
            this.priceLabel.TabIndex = 22;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(481, 201);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 37);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Удалить марку из коллекции";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 27);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Примечение: обновляйте страницу после добавления/удаления коллекционера.";
            // 
            // Form1
            // 
            this.AccessibleDescription = "form1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.specialLabel);
            this.Controls.Add(this.tirageLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.nominalLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Справочник филателиста";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CausesValidationChanged += new System.EventHandler(this.коллекционераToolStripMenuItem_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маркуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллекционераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маркиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллекционерыToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label nominalLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label tirageLabel;
        private System.Windows.Forms.Label specialLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВTXTToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

