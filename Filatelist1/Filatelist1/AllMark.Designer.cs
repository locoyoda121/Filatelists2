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
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tirage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MarksGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MarksGridView
            // 
            this.MarksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.nominal,
            this.tirage,
            this.special,
            this.collector});
            this.MarksGridView.Location = new System.Drawing.Point(12, 149);
            this.MarksGridView.Name = "MarksGridView";
            this.MarksGridView.Size = new System.Drawing.Size(547, 150);
            this.MarksGridView.TabIndex = 0;
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
            this.main.Location = new System.Drawing.Point(450, 305);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(109, 39);
            this.main.TabIndex = 1;
            this.main.Text = "На главную";
            this.main.UseVisualStyleBackColor = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(24, 35);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(121, 21);
            this.searchBox.TabIndex = 0;
            this.searchBox.SelectedIndexChanged += new System.EventHandler(this.searchBox_SelectedIndexChanged);
            // 
            // AllMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.main);
            this.Controls.Add(this.MarksGridView);
            this.Name = "AllMark";
            this.Text = "AllMark";
            ((System.ComponentModel.ISupportInitialize)(this.MarksGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView MarksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn collector;
        private System.Windows.Forms.DataGridViewTextBoxColumn special;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.Button main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox searchBox;
    }
}