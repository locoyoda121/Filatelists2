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
            this.main = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tirage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MarksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MarksGridView
            // 
            this.MarksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.country,
            this.nominal,
            this.tirage,
            this.special,
            this.collector});
            this.MarksGridView.Location = new System.Drawing.Point(12, 30);
            this.MarksGridView.Name = "MarksGridView";
            this.MarksGridView.Size = new System.Drawing.Size(573, 150);
            this.MarksGridView.TabIndex = 0;
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(472, 213);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(109, 39);
            this.main.TabIndex = 1;
            this.main.Text = "На главную";
            this.main.UseVisualStyleBackColor = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(357, 213);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(109, 39);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "Поиск";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // year
            // 
            this.year.HeaderText = "Год издания";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // country
            // 
            this.country.HeaderText = "Страна";
            this.country.Name = "country";
            this.country.ReadOnly = true;
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
            // AllMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 264);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.main);
            this.Controls.Add(this.MarksGridView);
            this.Name = "AllMark";
            this.Text = "AllMark";
            ((System.ComponentModel.ISupportInitialize)(this.MarksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView MarksGridView;
        private System.Windows.Forms.Button main;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn collector;
        private System.Windows.Forms.DataGridViewTextBoxColumn special;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
    }
}