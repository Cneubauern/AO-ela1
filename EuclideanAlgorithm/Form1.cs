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

        public Form1()
        {
            InitializeComponent();

            comboBox_Method.SelectedIndex = 0;  //Sub
            comboBox_count.SelectedIndex = 0; //Steps
            MIN = 10000;
            MAX = 1000000;
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

        public static List<ulong> getPrimeNumbers(ulong n)
        {
            List<ulong> primeNumbers = new List<ulong>();

            //ToDo: your implementation
            for (ulong i = 2; i <= n; i++)
            {
                numIterations++;
                while (n % i == 0)
                {
                    primeNumbers.Add(i);
                    n /= i;
                }
            }
            return primeNumbers;
        }

        public static ulong getGCDPrimeFactorization(ulong a, ulong b)
        {
            //ToDo: your implementation
            List<ulong> primeNumbersA = getPrimeNumbers(a);
            List<ulong> primeNumbersB = getPrimeNumbers(b);
            List<ulong> commonFactors = new List<ulong>();
            foreach (ulong _a in primeNumbersA)
            {
                foreach (ulong _b in primeNumbersB)
                {
                    numIterations++;
                    if (_a == _b & !commonFactors.Contains(_a))
                        commonFactors.Add(_a);
                }
            }

            if (!commonFactors.Any())
            {
                return 0;
            }
            ulong x = 1;
            foreach (ulong factor in commonFactors)
            {
                numIterations++;
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

            ulong l_a = (ulong)rnd.Next(MIN,MAX);//Convert.ToUInt64(numericUpDown_a.Value);
            ulong l_b = (ulong)rnd.Next(MIN, MAX);//Convert.ToUInt64(numericUpDown_b.Value);

            List<long> listCPUTimes = new List<long>();
            List<long> listStepsTaken = new List<long>();


            int numOfLoops = (int)numericUpDown_loops.Value;

            Stopwatch timer = new Stopwatch();   //other way to initialize: Stopwatch timer = Stopwatch.StartNew();



            for (int i = 0; i < numOfLoops; i++)
            {
                timer.Reset();
                timer.Start();

                numIterations = 0;

                switch (comboBox_Method.SelectedIndex)
                {
                    case 0:
                        getGCDSub(l_a, l_b);
                        break;
                    case 1:
                        getGCDMod(l_a, l_b);
                        break;
                    case 2:
                        getGCDPrimeFactorization(l_a, l_b);
                        break;
                    default:
                        return;
                }

                timer.Stop();
                listCPUTimes.Add(timer.ElapsedTicks);
                listStepsTaken.Add(numIterations);
                textBox_Results.AppendText("\r\n Iteration " + i.ToString() + ", CPU-time(ticks):" + timer.ElapsedTicks + ", steps taken:"+numIterations);
            }

            //Get Mean and SD
            double meanCPUTicks = getMean(listCPUTimes);
            double varianceCPUTicks = getVariance(listCPUTimes);
            double standardDeviationCPUTicks = Math.Sqrt(varianceCPUTicks);

            textBox_Results.AppendText("\r\n Mean CPU-time(ticks):" + meanCPUTicks);
            textBox_Results.AppendText("\r\n Standard Deviation CPU-time(ticks):" + standardDeviationCPUTicks);

            //Get Median
			//ToDo: your implementation
            double medianCPUTicks = getMedian(listCPUTimes);
            textBox_Results.AppendText("\r\n median CPU-time(ticks):" + medianCPUTicks);

            
            //Get Histogram            
			//ToDo: your implementation
            long startHisto = getMinValue(listCPUTimes); //get min value
            long endHisto = getMaxValue(listCPUTimes); //get max value

            List<int> histo = getHistogram(startHisto, endHisto, listCPUTimes);

            //Get Mode
			//ToDo: your implementation

            

            //show normalized histogram, probability density of CPU-time (ticks)
            double[] histoNormalized = getNormalizedHistogram(startHisto, endHisto, listCPUTimes);
            textBox_Results.AppendText("\r\n Normalized histogram:");
            for (int i = 0; i < histoNormalized.Count(); i++)
                textBox_Results.AppendText("\r\n" + i.ToString() + ": " + histoNormalized[i]);

            //add data to chart
            chart1.Series[0].Points.Clear();
            
            //ToDo: your implementation
            double cpuTicksHistoCounter=0;
            
            foreach (double probCPUTicks in histoNormalized)
            {
                //add datapoint X,Y to chart
                chart1.Series[0].Points.AddXY(cpuTicksHistoCounter, probCPUTicks);

                //compute next counter
                //ToDo: your implementation
            }
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
            return d / resultset.Count;

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
            ulong maxValue = 0;
            ulong secondValue = 0;

            foreach (ulong t1 in resultSet)
            {
                if (t1 > maxValue)
                {
                    secondValue = maxValue;
                    maxValue = t1;
                }
            }

            return maxValue - secondValue;
        }

        public static List<int> getHistogram(double start, double end, List<long> data)
        {
			//ToDo: your implementation
            int num_bins = 1;

            List<int> histo = new List<int>(num_bins);
            int bin_size = (int)(end - start) / num_bins;

            for (int k = 0; k < data.Count; k++)
            {
                for (int i = 0; i > num_bins; i++)
                {
                    if (data[k] >= (start + i * bin_size) && data[k] < (end + (i + 1) * bin_size))
                        histo[i]++;
                }
            }
           
            return histo;
        }

        public static double[] getNormalizedHistogram(double start, double end, List<long> data)
        {
			//ToDo: your implementation
            int num_bins = (int)Math.Round(Math.Sqrt(data.Count));

            double[] histo = new double[num_bins];

            
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

    }
}
