namespace Filatelist1
{
    partial class AllCollectors
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
            this.collectorGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.collectorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // collectorGridView
            // 
            this.collectorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collectorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.country,
            this.phone});
            this.collectorGridView.Location = new System.Drawing.Point(5, 12);
            this.collectorGridView.Name = "collectorGridView";
            this.collectorGridView.Size = new System.Drawing.Size(349, 150);
            this.collectorGridView.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // country
            // 
            this.country.HeaderText = "Страна";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(245, 210);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(109, 39);
            this.main.TabIndex = 2;
            this.main.Text = "На главную";
            this.main.UseVisualStyleBackColor = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // AllCollectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 261);
            this.Controls.Add(this.main);
            this.Controls.Add(this.collectorGridView);
            this.Name = "AllCollectors";
            this.Text = "AllCollectors";
            ((System.ComponentModel.ISupportInitialize)(this.collectorGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView collectorGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Button main;
    }
}