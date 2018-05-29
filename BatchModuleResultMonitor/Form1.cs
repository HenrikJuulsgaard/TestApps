using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchModuleResultMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string SerieName = "Batch Weight";
            for (int i = 0; i < 10; i++)
            {
                this.chart1.Series[SerieName].Points.AddXY(i.ToString(), 200);

            }
            /*
            this.chart1.Series[SerieName].Points.AddXY("1131 - 1160", 220);
            this.chart1.Series[SerieName].Points.AddXY("1161 - 1190", 230);
            this.chart1.Series[SerieName].Points.AddXY("1191 - 1220", 250);
            this.chart1.Series[SerieName].Points.AddXY("1221 - 1250", 200);
            this.chart1.Series[SerieName].Points.AddXY("1251 - 1280", 270);
            this.chart1.Series[SerieName].Points.AddXY("1281 - 1310", 200);
            */
            InfoText.Text = "Data loaded correct";
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Set 
            InfoText.Text = " Series 1 data";
        }

        private void InfoText_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
