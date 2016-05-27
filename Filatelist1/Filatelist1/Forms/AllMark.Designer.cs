namespace Filatelist1
{
    partial class AllMark
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
            this.MarksGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tirage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mintextBox = new System.Windows.Forms.TextBox();
            this.maxtextBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MarksGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MarksGridView
            // 
            this.MarksGridView.AllowUserToAddRows = false;
            this.MarksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.country,
            this.year,
            this.nominal,
            this.tirage,
            this.special,
            this.collector});
            this.MarksGridView.Location = new System.Drawing.Point(12, 149);
            this.MarksGridView.Name = "MarksGridView";
            this.MarksGridView.Size = new System.Drawing.Size(750, 201);
            this.MarksGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Номер марки";
            this.id.Name = "id";
            // 
            // country
            // 
            this.country.HeaderText = "Страна";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // year
            // 
            this.year.HeaderText = "Год издания";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // nominal
            // 
            this.nominal.HeaderText = "Стоимость";
            this.nominal.Name = "nominal";
            this.nominal.ReadOnly = true;
            // 
            // tirage
            // 
            this.tirage.HeaderText = "Тираж";
            this.tirage.Name = "tirage";
            this.tirage.ReadOnly = true;
            // 
            // special
            // 
            this.special.HeaderText = "Тема";
            this.special.Name = "special";
            this.special.ReadOnly = true;
            // 
            // collector
            // 
            this.collector.HeaderText = "Коллекционер";
            this.collector.Name = "collector";
            this.collector.ReadOnly = true;
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(653, 356);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(109, 39);
            this.main.TabIndex = 1;
            this.main.Text = "На главную";
            this.main.UseVisualStyleBackColor = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textbox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mintextBox);
            this.groupBox1.Controls.Add(this.maxtextBox);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(158, 29);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(558, 38);
            this.textbox.TabIndex = 6;
            this.textbox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "C";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "по";
            this.label1.Visible = false;
            // 
            // mintextBox
            // 
            this.mintextBox.Location = new System.Drawing.Point(26, 73);
            this.mintextBox.Name = "mintextBox";
            this.mintextBox.Size = new System.Drawing.Size(100, 20);
            this.mintextBox.TabIndex = 2;
            this.mintextBox.Visible = false;
            this.mintextBox.TextChanged += new System.EventHandler(this.mintextBox_TextChanged);
            this.mintextBox.VisibleChanged += new System.EventHandler(this.searchBox_SelectedIndexChanged);
            // 
            // maxtextBox
            // 
            this.maxtextBox.Location = new System.Drawing.Point(158, 73);
            this.maxtextBox.Name = "maxtextBox";
            this.maxtextBox.Size = new System.Drawing.Size(100, 20);
            this.maxtextBox.TabIndex = 1;
            this.maxtextBox.Visible = false;
            this.maxtextBox.TextChanged += new System.EventHandler(this.maxtextBox_TextChanged);
            // 
            // searchBox
            // 
            this.searchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(6, 29);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(121, 21);
            this.searchBox.TabIndex = 0;
            this.searchBox.SelectedIndexChanged += new System.EventHandler(this.searchBox_SelectedIndexChanged);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Показать все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AllMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.main);
            this.Controls.Add(this.MarksGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllMark";
            this.Text = "Марки";
            ((System.ComponentModel.ISupportInitialize)(this.MarksGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView MarksGridView;
        private System.Windows.Forms.Button main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mintextBox;
        private System.Windows.Forms.TextBox maxtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn collector;
        private System.Windows.Forms.DataGridViewTextBoxColumn special;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
    }
}