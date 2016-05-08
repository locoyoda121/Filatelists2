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
    public partial class AllCollectors : Form
    {
        public AllCollectors()
        {
            InitializeComponent();
            FillGridView();
        }

        public void FillGridView()
        {
            collectorGridView.Rows.Clear();
            Serial.OpenCollector();
            foreach (Collector collector in Serial.collectorsList)
                collectorGridView.Rows.Add(collector.Name, collector.Country, collector.Phone);

        }

        private void main_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
