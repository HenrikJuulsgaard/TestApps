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
            //  Read to string
            //********************************************************************************************************
            string[] s3 = File.ReadAllLines(@"C:\Temp\Test.txt");
            int[] iData = new int[s3.Length];

            // convert to int
            for (int i = 0; i < s3.Length; i++)
            {
                iData[i] = int.Parse(s3[i]);
            }

            // Sort numbers
            Array.Sort(iData);


            //********************************************************************************************************
            // Add data to barchart
            //********************************************************************************************************
            string SerieName = "Batch Weight";
            int NumberOfBar = 40;
            this.chart1.Series[SerieName].Points.Clear();
            for (int i = 0; i < iData.Length; i++)
            {
                chart1.Series[SerieName].Points.AddXY((i + 1).ToString(), iData[i]);
             
            }
            // Add text when file load done
            InfoText.Text = "Data loaded correct";




            //********************************************************************************************************
            // 
            //********************************************************************************************************
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Set 
            InfoText.Text = " Series 1 data ";
        }
        
        private void InfoText_TextChanged(object sender, EventArgs e)
        {
          
        }
   

    }

   

}
