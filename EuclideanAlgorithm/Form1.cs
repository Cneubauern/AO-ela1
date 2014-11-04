using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuclideanAlgorithm
{
    public partial class Form1 : Form
    {
        public static int numIterations;
        private int MIN;
        private int MAX;
        List<ulong> listAllRandomA = new List<ulong>();
        List<ulong> listAllRandomB = new List<ulong>();
        List<ulong> listRndAvg = new List<ulong>();
        List<KeyValuePair<ulong, int>> plotValue;
        List<KeyValuePair<ulong, int>> plotValueCPU;


        private bool gotRndList = false; 

        public Form1()
        {
            InitializeComponent();

            comboBox_Method.SelectedIndex = 0;  //Sub
            comboBox_count.SelectedIndex = 0; //Steps
            MIN = Convert.ToInt32(numericUpDownMin.Value);
            MAX = Convert.ToInt32(numericUpDownMax.Value);
            

        }

        private void button_getGCD_Click(object sender, EventArgs e)
        {
            ulong l_a = Convert.ToUInt64(numericUpDown_a.Value);
            ulong l_b = Convert.ToUInt64(numericUpDown_b.Value);

            Stopwatch timer = new Stopwatch();   //other way to initialize: Stopwatch timer = Stopwatch.StartNew();

            timer.Start();

            ulong gcd;

            numIterations = 0;

            switch (comboBox_Method.SelectedIndex)
            {
                case 0:
                    gcd = getGCDSub(l_a, l_b);
                    textBox_Results.AppendText("\r\n Subtraction Method: GCD=" + gcd.ToString());
                    break;
                case 1:
                    gcd = getGCDMod(l_a, l_b);
                    textBox_Results.AppendText("\r\n Modulo Method: GCD=" + gcd.ToString());
                    break;
                case 2:
                    gcd = getGCDPrimeFactorization(l_a, l_b);
                    textBox_Results.AppendText("\r\n Prime Factorization Method: GCD=" + gcd.ToString());
                    break;
                default:
                    return;
            }

            timer.Stop();

            textBox_Results.AppendText("\r\n CPU-time(ticks):" + timer.ElapsedTicks);
            textBox_Results.AppendText("\r\n CPU-time(ms):" + timer.ElapsedMilliseconds);
            textBox_Results.AppendText("\r\n Number of iterations:" + numIterations);
        }

        public static ulong getGCDMod(ulong a, ulong b)
        {
			//ToDo: your implementation
                while (b != 0)
            {
                numIterations++;
                ulong t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public static List<ulong> getPrimeNumbers(ulong value)
        {
            List<ulong> primeNumbers = new List<ulong>();

            //ToDo: your implementation
           List<bool> tmpList = new List<bool>((int)value);
            tmpList.Add(false);
            tmpList.Add(false);

            // init sieve List
            for (int i = 2; i <= (int)value; ++i)
            {
                tmpList.Add(true);
            }

            // unmark not prime numbers
            for (int i = 2; i * i < (int)value; ++i)
            {
                if (tmpList[i])
                {
                    for (int j = i * i; j < (int)value; j += i)
                    {
                        tmpList[j] = false;
                    }
                }
            }

            // add each prime number to the list
            for (int x = 0; x < tmpList.Count; ++x)
            {
                if (tmpList[x])
                {
                    primeNumbers.Add((ulong)x);
                }
            }

            return primeNumbers;
        }

        public static ulong getGCDPrimeFactorization(ulong a, ulong b)
        {
            //ToDo: your implementation 
            ulong tmp_a = a/2;
            ulong tmp_b = b/2;
            List<ulong> primeNumbersA = getPrimeNumbers(Math.Min(tmp_a, tmp_b));
   //         List<ulong> primeNumbersB = getPrimeNumbers(Math.Max(a,b));
            List<ulong> commonFactors = new List<ulong>();

            for (int i = 0; i < primeNumbersA.Count; i++ )
            {
                ulong _a = primeNumbersA[i];

                while (tmp_a % _a == 0 & tmp_b % _a == 0)
                {
                    commonFactors.Add(_a);
                    tmp_a /= _a;
                    tmp_b /= _a;
                }
                if (tmp_a == 1 & tmp_b == 1)
                    break;
                numIterations++;
            }

            if (!commonFactors.Any())
            {
                return 1;
            }
            ulong x = 1;
            foreach (ulong factor in commonFactors)
            {
               // numIterations++;
                x *= factor;
            }

            return x;
        }

   
        public static ulong getGCDSub(ulong a, ulong b)
        {
            
            if (a == 0)
                return b;

            while (b != 0)
            {
                numIterations++;

                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }

            return a;
        }


        /** LOOPS */
        private void button_loops_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            plotValue = new List<KeyValuePair<ulong, int>>();
            plotValueCPU = new List<KeyValuePair<ulong, int>>();

            List<long> listCPUTimes = new List<long>();
            List<long> listCPUTimesAvg = new List<long>();
            List<long> listStepsTaken = new List<long>();

            int numOfLoops = (int)numericUpDown_loops.Value;
            int numOfRndNumbers = (int)numberoRndNumbers.Value;
            string series = "subtraction";

            Stopwatch timer = new Stopwatch();   //other way to initialize: Stopwatch timer = Stopwatch.StartNew();

            ulong l_a = 0;
            ulong l_b = 0;
            for (int k = 0; k < numOfLoops; k++)
            {
                listCPUTimes.Clear();
                listStepsTaken.Clear();
                for (int i = 0; i < numOfRndNumbers; i++)
                {
                    if (!gotRndList)
                    {
                        l_a = (ulong)rnd.Next(MIN, MAX);
                        l_b = (ulong)rnd.Next(MIN, MAX);
                    }
                    else if (gotRndList)
                    {
                        l_a = listAllRandomA[i];//Convert.ToUInt64(numericUpDown_a.Value);
                        l_b = listAllRandomB[i];//Convert.ToUInt64(numericUpDown_b.Value);
                    }
                    timer.Reset();
                    timer.Start();

                    numIterations = 0;

                    switch (comboBox_Method.SelectedIndex)
                    {
                        case 0:
                            getGCDSub(l_a, l_b);
                            series = "subtraction";
                            break;
                        case 1:
                            getGCDMod(l_a, l_b);
                            series = "modulo";
                            break;
                        case 2:
                            getGCDPrimeFactorization(l_a, l_b);
                            series = "prime";
                            break;
                        default:
                            return;
                    }

                    timer.Stop();
                    listCPUTimes.Add(timer.ElapsedTicks);
                    listStepsTaken.Add(numIterations);
                    ulong avg = (l_a + l_b) / 2;
                    plotValue.Add(new KeyValuePair<ulong, int>(avg, numIterations));


                    if (!gotRndList)
                    {
                        listAllRandomA.Add(l_a);
                        listAllRandomB.Add(l_b);
                        listRndAvg.Add((l_a + l_b) / 2);
                    }
                    
                    //textBox_Results.AppendText("\r\n a: " + l_a + ", b:" + l_b);
                    //textBox_Results.AppendText("\r\n Iteration " + i.ToString() + ", CPU-time(ticks):" + timer.ElapsedTicks + ", steps taken:" + numIterations);

                    

                  //  textBox_Results.AppendText("\r \n Average" + listCPUTimesAvg[i]);

                }

                gotRndList = true;

                if(listCPUTimesAvg.Count==0)
                    listCPUTimesAvg = listCPUTimes;
                else
                {
                    for(int i = 0; i<listCPUTimesAvg.Count; i++){
                        long b = listCPUTimes[i];
                        listCPUTimesAvg[i] += b;
                    }
                }
             /*   for (int n=0; n < listCPUTimes.Count(); n++)
                {
                    listCPUTimesAvg[n] += listCPUTimes[n];
                }
                for (int i = 0; i < listCPUTimesAvg.Count();i++ )
            */
                //Get Mean and SD
             //   double meanCPUTicks = getMean(listCPUTimes);
             //   double varianceCPUTicks = getVariance(listCPUTimes);
             //   double standardDeviationCPUTicks = Math.Sqrt(varianceCPUTicks);

             //   textBox_Results.AppendText("\r\n Mean CPU-time(ticks):" + meanCPUTicks);
             //   textBox_Results.AppendText("\r\n Variance CPU-time(ticks):" + varianceCPUTicks);
             //   textBox_Results.AppendText("\r\n Standard Deviation CPU-time(ticks):" + standardDeviationCPUTicks);


                //Get Median
                //ToDo: your implementation
          //      double medianCPUTicks = getMedian(listCPUTimes);
          //      textBox_Results.AppendText("\r\n median CPU-time(ticks):" + medianCPUTicks);

                //Get Mode
                //ToDo: your implementation
            }
                //add data to chart
            for (int i = 0; i < listRndAvg.Count; i++ )
                plotValueCPU.Add(new KeyValuePair<ulong, int>(listRndAvg[i], (int)listCPUTimesAvg[i]));

                  plotValue.Sort(CompareValues);
                  plotValueCPU.Sort(CompareValues);
                switch (comboBox_count.SelectedIndex)
                {
                    case 0:

                        if (!chart1.Series.IsUniqueName(series))
                            chart1.Series.Remove(chart1.Series[series]);
                        chart1.Series.Add(series);
                        chart1.Series[series].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        long minimum = getMinValue(listStepsTaken); //get min value
                        long maximum = getMaxValue(listStepsTaken); //get max value
                      
                            for (int i = 0; i < listStepsTaken.Count; i++)
                            chart1.Series[series].Points.AddXY(plotValue[i].Key,plotValue[i].Value);
                            break;
                    case 1:
                       
                        if (chart1.Series.IsUniqueName(series + "Avg"))
                        {
                            chart1.Series.Add(series + "Avg");
                            chart1.Series[series + "Avg"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                            chart1.Series.Add(series + "SD");
                            chart1.Series[series + "SD"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
                        } 
                        for (int i = 1; i < plotValueCPU.Count; i++){
                            
                            chart1.Series[series + "Avg"].Points.AddXY(plotValueCPU[i].Key, plotValueCPU[i].Value);
                          //  textBox_Results.AppendText("\r\n AVG:"+listCPUTimesAvg[i]);
                        }
                        break;
                    default:
                        return;
                }
                /*     //Get Histogram            
                     //ToDo: your implementation
                     long startHisto = getMinValue(mode); //get min value
                     long endHisto = getMaxValue(mode); //get max value
                     textBox_Results.AppendText("\r\n min_Value:" + startHisto + ",max_Value:"+endHisto);
         
                     //List<int> histo = getHistogram(startHisto, endHisto, listCPUTimes);
                     //textBox_Results.AppendText("\r\n  histogram:");
                     //for (int i = 0; i < histo.Count(); i++)
                     //    textBox_Results.AppendText("\r\n" + i.ToString() + ": " + histo[i]);

            
       
                     //show normalized histogram, probability density of CPU-time (ticks)
                     double[] histoNormalized = getNormalizedHistogram(startHisto, endHisto, mode);
                     textBox_Results.AppendText("\r\n Normalized histogram:");
                     for (int i = 0; i < histoNormalized.Count(); i++)
                         textBox_Results.AppendText("\r\n" + i.ToString() + ": " + histoNormalized[i]);

          
                     //ToDo: your implementation
                     double cpuTicksHistoCounter=0;
            
                     foreach (double probCPUTicks in histoNormalized)
                     {
                         //add datapoint X,Y to chart
                         chart1.Series[comboBox_Method.SelectedIndex + 1].Points.AddXY(cpuTicksHistoCounter, probCPUTicks);

                         //compute next counter
                         //ToDo: your implementation
                     }*/
            
        }

        private static long getMinValue(List<long> resultset)
        {
            long min = long.MaxValue;
            foreach (long t in resultset)
            {
                if (t < min)
                {
                    min = t;
                }
            }
            return min;
        }

        private static long getMaxValue(List<long> resultset)
        {
            long max = 0;
            foreach (long t in resultset)
            {
                if (t > max)
                {
                    max = t;
                }
            }
            return max;
        }

        private static long getMedian(List<long> resultset)
        {
            
                long d = 0;
                foreach (long t in resultset)
                {
                    d += t;
                }
                if (resultset.Count!= 0)
                    return d / resultset.Count;
                else
                    return d;
        }

        public static double getMean(List<long> resultset)
        {
            //ToDo: your implementation
            ulong number = Convert.ToUInt64(resultset.Count);
            ulong x = 0;
            foreach (ulong time in resultset)
            {
                x += time;
            }

            return x / number;
        }

        public static double getVariance(List<long> resultSet)
        {
            //ToDo: your implementation
            int v = 0;
            int n = resultSet.Count();
            int m = (int)getMean(resultSet);
            foreach (int x in resultSet)
            {
                v += (x - m) * (x-m);
            }
                return v/n;
          
        }

        public  List<int> getHistogram(double start, double end, List<long> data)
        {
            textBox_Results.AppendText("\r\n histo");

			//ToDo: your implementation
            int num_bins = 5; //data.Count();
//            int num_bins = (int)Math.Round(Math.Sqrt(data.Count));

            textBox_Results.AppendText("\r\n num_bins"+ num_bins);
            textBox_Results.AppendText("\r\n num_bins" + data.Count());



            List<int> histo = new List<int>(num_bins);
            int bin_size = (int)(end - start) / num_bins;
            textBox_Results.AppendText("\r\n bin_size"+bin_size);


            for (int k = 0; k < data.Count(); k++) // over all data
            {
                textBox_Results.AppendText("\r\n k="+k);

                for (int i = 0; i < num_bins-1; i++) // over all bins
                {
                    textBox_Results.AppendText("\r\n i="+i);

                    if (data[k] >= (start + i * bin_size) && data[k] < (end + (i + 1) * bin_size))
                    {

                       //histo[i] = histo[i] + 1;
                       textBox_Results.AppendText("\r\n i=" + i);
                        textBox_Results.AppendText("\r\n histo:");
                    }
                }
            }
            
            return histo;
        }

       
        public  double[] getNormalizedHistogram(double start, double end, List<long> data)
        {
			//ToDo: your implementation
            int num_bins = (int)Math.Round(Math.Sqrt(data.Count));
            int bin_size = (int)(end - start) / num_bins;

            double[] histo = new double[num_bins];

            for (int k = 0; k < data.Count(); k++) // over all data
            {
                //textBox_Results.AppendText("\r\n k=" + k);

                for (int i = 0; i < num_bins - 1; i++) // over all bins
                {
                    //textBox_Results.AppendText("\r\n i=" + i);

                    if (data[k] >= (start + i * bin_size) && data[k] < (end + (i + 1) * bin_size))
                    {
                        histo[i]++;
                        //histo[i] = histo[i] + 1;
                        //textBox_Results.AppendText("\r\n i=" + i);
                        //textBox_Results.AppendText("\r\n histo:");
                    }
                }
            }
            
            return histo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Method_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int rndNum = rnd.Next(MIN,MAX);
            numericUpDown_a.Value = rndNum;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int rndNum = rnd.Next(MIN, MAX);
            numericUpDown_b.Value = rndNum;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            chart1.Series.Clear();
           // listAllRandomA.Clear();
           // listAllRandomB.Clear();
            //listRndAvg.Clear();
         //   gotRndList = false;
            textBox_Results.AppendText("\r\n clear");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownMax_ValueChanged(object sender, EventArgs e)
        {
            MAX = Convert.ToInt32(numericUpDownMax.Value);
        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            MIN = Convert.ToInt32(numericUpDownMin.Value);

        }
        public static int CompareValues(KeyValuePair<ulong, int> a, KeyValuePair<ulong, int> b)
        {
            return a.Key.CompareTo(b.Key);
        }
    }
}
