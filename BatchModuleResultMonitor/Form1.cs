using System;
using System.IO;
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
            //********************************************************************************************************
            // Add data to barchart
            //********************************************************************************************************
            string SerieName = "Batch Weight";
            int NumberOfBar = 40;
            this.chart1.Series[SerieName].Points.Clear();
            for (int i = 0; i < NumberOfBar; i++)
            {
                chart1.Series[SerieName].Points.AddXY((i+1).ToString() , 200);
            }
            // Add text when file load done
            InfoText.Text = "Data loaded correct";



            //********************************************************************************************************
            //  Read to string
            //********************************************************************************************************
            string[] s3 = File.ReadAllLines(@"C:\Temp\Test.txt");


            //********************************************************************************************************
            // 
            //********************************************************************************************************
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
