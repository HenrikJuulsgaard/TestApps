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
            string sFileName = "";
            if (sFileName == "")
            {
                sFileName= PathTextBox.Text;    // @"C:\Temp\AlgoLog_2.txt";
            }

           
            string[] sFile = File.ReadAllLines(sFileName);
            // Get value out from CSV element
          
            double[] iData = new double[sFile.Length];

            // convert to double array
            for (int i = 0; i < sFile.Length; i++)
            {
                // Get each element loaded and convert to double, save in data array
                int PosStart = sFile[i].IndexOf("Closing weight") + 14;
                string sTemp = sFile[i].Substring(PosStart + 1);
                int PosStop = sTemp.IndexOf(@"Item") - 1;
                sTemp = sTemp.Remove(PosStop);
                iData[i] = double.Parse(sTemp);
               // iData[i] /= 10;
            }

            
            //********************************************************************************************************
            // Work with the data
            //********************************************************************************************************

            // Variables
            int BatchMaxWeight;
            int BatchAvgWeight;
            int BatchMinWeight;

            // Sort numbers
            Array.Sort(iData);
            d.arrData = iData;
            int[] arrMax = d.GrafData(20);

            // Calculate std dev
            Double StDev = d.StandardDeviation(iData);

            // Get Array data
            BatchMaxWeight = d.Max();
            BatchAvgWeight = d.Avg();
            BatchMinWeight = d.Min();


            //********************************************************************************************************
            // Add data to barchart
            //********************************************************************************************************
            string SerieName = "Batch Weight";
            chart1.Series[SerieName].Points.Clear();
            string Temp = "";

             for (int i = 0; i < arrMax.Length; i++)
            {
                Temp =  arrMax[i].ToString() + (i + 1).ToString();

                chart1.Series[SerieName].Points.AddXY(Temp, arrMax[i]);
                chart1.ChartAreas[0].AxisX.Interval = 2;

              //   chart1.ChartAreas[0].AxisX.CustomLabels.Add(arrMax.Length, i, (i+1).ToString());
            }
            

            // Add text when file load done
            InfoText.Text = "Data loaded correct";

            // Add text to standard diviation textbox
            StdDevTxtBox.Text = StDev.ToString("N4");

            // Add data to batch weight info
            TxtBoxMax.Text = BatchMaxWeight.ToString();
            TxtBoxAvg.Text = BatchAvgWeight.ToString();
            TxtBoxMin.Text = BatchMinWeight.ToString();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Set 
            InfoText.Text = " Series 1 data ";
        }
        
 

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Data
    {
        public double[] arrData { get; set; }



        // Standard diviation
        public double StandardDeviation(IEnumerable<double> values)
        {
            double avg = values.Average();
            return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
        }

        // Get array max
        public int Max()
        {
            return (int)arrData.Max();
        }

        // Get array average
        public int Avg()
        {
            return (int)arrData.Average();
        }

        // Get array minimum
        public int Min()
        {
            return (int) arrData.Min();
        }

        public int[] GrafData(int ChartLenght)
        {
            // Number of bars in chart
            int[] _GrafData = new int[ChartLenght];

            // tester
            double span = (arrData[arrData.Length-1] - arrData[0]) / _GrafData.Length;
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
