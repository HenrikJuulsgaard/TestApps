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
            Data d = new Data();

            //********************************************************************************************************
            //  Read to string
            //********************************************************************************************************
            string[] s3 = File.ReadAllLines(@"C:\Temp\Test.txt");
            double[] iData = new double[s3.Length];

            // convert to int
            for (int i = 0; i < s3.Length; i++)
            {
                iData[i] = double.Parse(s3[i]);
                iData[i] /= 10;
            }

            // Sort numbers
            Array.Sort(iData);
            d.arrData = iData;
            int[] arrMax = d.GrafData();


            Double StDev = d.StandardDeviation(iData);


            //********************************************************************************************************
            // Add data to barchart
            //********************************************************************************************************
            string SerieName = "Batch Weight";
            int NumberOfBar = 40;
            this.chart1.Series[SerieName].Points.Clear();
            string Temp = "";

            for (int i = 0; i < arrMax.Length; i++)
            {
                Temp =  arrMax[i].ToString() + (i + 1).ToString();
                chart1.Series[SerieName].Points.AddXY(Temp, arrMax[i]);

            }


            //for (int i = 0; i < iData.Length; i++)
            //{
            //    chart1.Series[SerieName].Points.AddXY( iData[i], (i + 1).ToString());

            //}

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

    public class Data
    {
        public double[] arrData { get; set; }

        double _Max;


        // Standard diviation
        public double StandardDeviation(IEnumerable<double> values)
        {
            double avg = values.Average();
            return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
        }

        public int Max()
        {
            return (int) arrData.Max();
        }

        public int[] GrafData()
        {
            int[] _GrafData = new int[20];

            // tester
            double span = (arrData[arrData.Length-1] - arrData[0]) / 20;
            int GrafPoint = 0;

            for (int i = 0; i < (arrData.Length - 1); i++)
            {
                // Check bound and add to graph array
                if (arrData[i] < arrData[0] + span * (GrafPoint+1) )
                {
                    _GrafData[GrafPoint]++;
                }
                else
                {
                    GrafPoint++;
                }
            }

            _GrafData[0] = 100;


            return _GrafData;
        }

    }

}
