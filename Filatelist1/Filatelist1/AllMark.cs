using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filatelist1
{
    public partial class AllMark : Form
    {
        public AllMark()
        {
            InitializeComponent();
            FillGridView();
        }

        public void FillGridView()
        {
            MarksGridView.Rows.Clear();
            Serial.OpenMark();
            foreach (Marka marka in Serial.marksList)
                MarksGridView.Rows.Add(marka.Year, marka.Nominal, marka.Tirage, marka.Special, marka.Coll.Name);

        }

        private void main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
