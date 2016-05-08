namespace Filatelist1
{
    partial class AddMark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.nominalBox = new System.Windows.Forms.TextBox();
            this.tirageBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.specialBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.collectorBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CollectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CollectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стоимость: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тираж: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год выпуска: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Особенность: ";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(104, 6);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(144, 20);
            this.countryBox.TabIndex = 5;
            // 
            // nominalBox
            // 
            this.nominalBox.Location = new System.Drawing.Point(104, 34);
            this.nominalBox.Name = "nominalBox";
            this.nominalBox.Size = new System.Drawing.Size(144, 20);
            this.nominalBox.TabIndex = 6;
            // 
            // tirageBox
            // 
            this.tirageBox.Location = new System.Drawing.Point(104, 63);
            this.tirageBox.Name = "tirageBox";
            this.tirageBox.Size = new System.Drawing.Size(144, 20);
            this.tirageBox.TabIndex = 7;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(104, 89);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(144, 20);
            this.yearBox.TabIndex = 8;
            // 
            // specialBox
            // 
            this.specialBox.Location = new System.Drawing.Point(104, 155);
            this.specialBox.Multiline = true;
            this.specialBox.Name = "specialBox";
            this.specialBox.Size = new System.Drawing.Size(144, 54);
            this.specialBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Коллекционер: ";
            // 
            // collectorBox
            // 
            this.collectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collectorBox.FormattingEnabled = true;
            this.collectorBox.Location = new System.Drawing.Point(104, 125);
            this.collectorBox.Name = "collectorBox";
            this.collectorBox.Size = new System.Drawing.Size(144, 21);
            this.collectorBox.TabIndex = 11;
            this.collectorBox.SelectedIndexChanged += new System.EventHandler(this.collectorBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(51, 250);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 43);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить марку";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(157, 250);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(91, 43);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CollectorBindingSource
            // 
        //    this.CollectorBindingSource.DataSource = typeof(Filatelist1.Collector);
            // 
            // AddMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 305);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.collectorBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.specialBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.tirageBox);
            this.Controls.Add(this.nominalBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMark";
            this.Text = "AddMark";
            this.Load += new System.EventHandler(this.AddMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CollectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox nominalBox;
        private System.Windows.Forms.TextBox tirageBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox specialBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox collectorBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.BindingSource CollectorBindingSource;
    }
}