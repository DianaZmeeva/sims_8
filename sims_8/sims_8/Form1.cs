using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace sims_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        int rv_type = -1;
        bool flag =true;
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            switch (comboBox1.Text)
            {
                case "Choose RV type":
                    rv_type = -1;
                    break;
                case "Uniform distribution":
                    rv_type = 0;
                    break;
                case "Geometric distribution":
                    rv_type = 1;
                    break;
                case "Negative binomial distribution":
                    rv_type = 2;
                    break;
                case "Binomial distribution":
                    rv_type = 3;
                    break;
                case "Poisson distribution":
                    rv_type = 4;
                    break;
                case "Exponential distribution":
                    rv_type = 5;
                    break;
                case "RV given by histogram":
                    rv_type = 6;
                    break;
                case "Hyperexponential distribution":
                    rv_type = 7;
                    break;
                case "Standard normal distribution №1":
                    rv_type = 8;
                    break;
                case "Standard normal distribution №2":
                    rv_type = 9;
                    break;
                case "Gamma distribution":
                    rv_type = 10;
                    break;
            }
        }

        double p;
        int n;

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                button1.Enabled = flag;
                chart1.ChartAreas[0].AxisY.Minimum = double.NaN;
                chart1.ChartAreas[0].AxisY.Maximum = double.NaN;
                chart1.Series[2]["PointWidth"] = "1";

                int N = (int)numeric_size.Value;
                switch (rv_type)
                {
                    case -1:
                        label1.Visible = true;
                        f();
                        break;
                    case 0:
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                        if (f2.Flag)
                        {
                           int a = f2.A;
                           int b = f2.B;
                           Uniform(a, b, N);
                        }
                        break;
                    case 1:
                        Form3 f3 = new Form3();
                        f3.ShowDialog();
                        if (f3.Flag)
                        {
                            p = f3.P;
                            Geom(p, N);
                        }
                        break;
                    case 2:
                        string s1= "p = ", s2="r = ";
                        Form4 f4 = new Form4(s1,s2);
                        f4.ShowDialog();
                        if (f4.Flag)
                        {
                            p = f4.P;
                            int r = f4.R;
                            Negative(p, r, N);
                        }
                        break;
                    case 3:
                        s1 = "p = ";
                        s2 = "n = ";
                        f4 = new Form4(s1, s2);
                        f4.ShowDialog();
                        if (f4.Flag)
                        {
                            p = f4.P;
                            n = f4.R;
                            Binomial(p, n, N);
                        }
                        break;
                    case 4:
                        Form5 f5 = new Form5();
                        f5.ShowDialog();
                        if (f5.Flag)
                        {
                            double l = f5.L;
                            Poisson(l, N);
                        }
                        break;
                    case 5:
                        Form5 f6 = new Form5();
                        f6.ShowDialog();
                        if (f6.Flag)
                        {
                            double l = f6.L;
                            Exponential(l, N);
                        }
                        break;
                    case 6:
                        Form6 f66 = new Form6();
                        f66.ShowDialog();
                        if (f66.Flag)
                        {
                            List<double> xs = f66.X;
                            List<double> ys = f66.Y;
                            Hist(xs, ys, N);
                        }
                        break;
                    case 7:
                        Form7 f7 = new Form7();
                        f7.ShowDialog();
                        if (f7.Flag)
                        {
                            n = f7.N;
                            Hyper(n, N);
                        }
                        break;
                    case 8:
                        s1 = "σ = ";
                        s2 = "a =";
                        Form8 f8 = new Form8(s1,s2);
                        f8.ShowDialog();
                        if (f8.Flag)
                        {
                            p = f8.A;
                            double f = f8.F;
                            SND1(f,p, N);
                        }
                        break;
                    case 9:
                        s1 = "σ = ";
                        s2 = "a =";
                        Form8 f88 = new Form8(s1, s2);
                        f88.ShowDialog();
                        if (f88.Flag)
                        {
                            p = f88.A;
                            double f = f88.F;
                            SND2(f, p, N);
                        }
                        break;
                    case 10:
                        s1 = "α = ";
                        s2 = "β =";
                        Form8 f9 = new Form8(s1, s2);
                        f9.ShowDialog();
                        if (f9.Flag)
                        {
                            p = f9.A;
                            double f = f9.F;
                            Gamma(f, p, N);
                        }
                        break;
                }
            }
        }


        private void Uniform(int a, int b, int N)
        {
            int n = Math.Abs(b - a);
            Random rnd = new Random();
            double alpha;
            Dictionary<int, int> nums = new Dictionary<int, int>();
            //int[] nums = new int[n + 1];

            c();

            chart1.Series[0].Name = "Uniform distribution";
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1;

            for (int i = 0; i < N; i++)
            {
                alpha = rnd.NextDouble();
                int x = (int)(alpha*(n+1)+a);
                if (nums.ContainsKey(x))
                {
                    nums[x] += 1;
                }
                else
                {
                    nums.Add(x, 1);
                }
            }
            for (int i = a; i <= b; i++)
            {
                chart1.Series[1].Points.AddXY(i, Math.Round(((double)1 / (n + 1)), 2));
                if (nums.ContainsKey(i))
                {
                    chart1.Series[0].Points.AddXY(i, ((double)nums[i] / N));
                }
            }

            Mean_Varianse_2(nums, N);
             //Mean_Varianse(a, n+a);

            //for (int i = 0; i < n + 1; i++)
            //{
            //    chart1.Series[0].Points.AddXY(a, ((double)nums[i] / N));
            //    a++;
            //}
            f();
        }

        private void Geom(double p, int N)
        {
            Random rnd = new Random();

            double alpha;
            int t, max=0;
            int[] nums = new int[100000];

            c();
            chart1.Series[0].Name = "p= " + p;
            for (int i=0; i<N; i++)
            {
                alpha = rnd.NextDouble();
                t = (int)(Math.Log(alpha) / Math.Log(1 - p));
                nums[t]++;
                if (t > max)
                    max = t;
            }


            for (int i=0;i<max; i++)
            {
                chart1.Series[0].Points.AddXY(i, ((double)nums[i]/N));
                double y = p * Math.Pow((1 - p), i);
                chart1.Series[1].Points.AddXY(i, y);
            }

            Mean_Varianse(0, max, nums, N);
            f();
        }


        private void Negative(double p, int r, int N)
        {
            Random rnd = new Random();
            double alpha;
            int x, max=0;
            int[] nums = new int[100000];

            c();
            chart1.Series[0].Name = "p= " + p + "     r= "+r;

            for (int i=0; i<N; i++)
            {
                x = 0;
                for (int j=1; j<=r; j++)
                {
                    alpha = rnd.NextDouble();
                    x += (int)((Math.Log(alpha)/(Math.Log(1-p))));
                }

                nums[x]++;
                if (x > max)
                    max = x;
            }

            for (int i = 0; i < max; i++)
            {
                chart1.Series[0].Points.AddXY(i, ((double)nums[i] / N));
                if (i+r-1<170)
                {
                    double y = (Factorial(i + r - 1) / (Factorial(i) * Factorial(r - 1))) * Math.Pow(p,r)*Math.Pow((1-p), i);
                    chart1.Series[1].Points.AddXY(i, y);
                }
            }

            Mean_Varianse(0, max, nums, N);
            f();
        }

        private void Binomial(double p, int n, int N)
        {
            Random rnd = new Random();
            double alpha;
            int x, max = 0;
            int[] nums = new int[100000];

            c();
            chart1.Series[0].Name = "p= " + p + "     n = " + n;

            for (int i=0;i<N; i++)
            {
                x = 0;
                for (int j = 1; j <= n; j++)
                {
                    alpha = rnd.NextDouble();
                    if (p - alpha >= 0)
                        x += (int)(1 + (p - alpha));
                    else
                        x += (int) Math.Abs(p - alpha);

                }
                nums[x]++;
                if (x > max)
                    max = x;
            }

            for (int i = 0; i < max; i++)
            {
                chart1.Series[0].Points.AddXY(i, ((double)nums[i] / N));
                if (n < 170)
                {
                    double y = Factorial(n) / (Factorial(i) * Factorial(n - i)) * Math.Pow(p, i) * Math.Pow((1-p),(n-i));
                    chart1.Series[1].Points.AddXY(i, y);
                }
            }

            Mean_Varianse(0, max, nums, N);
            f();
        }

        private void Poisson(double l, int N) 
        {
            Random rnd = new Random();
            double alpha;
            int x, max = 0;
            double S=0;
            int[] nums = new int[100000];

            c();
            chart1.Series[0].Name = "λ= " + l;
            for (int i = 0; i < N; i++)
            {
                S = 0;
                x = -1;
               while (!(S<-l))
                {
                    alpha = rnd.NextDouble();
                    S += Math.Log(alpha);
                    x++;
                }
                nums[x]++;
                if (x > max)
                    max = x;
            }

            for (int i = 0; i < max; i++)
            {
                chart1.Series[0].Points.AddXY(i, ((double)nums[i] / N));
                if (i<170)
                {
                    double y = Math.Pow(l, i) / Factorial(i) * Math.Exp(-l);
                    chart1.Series[1].Points.AddXY(i, y);
                }
            }

            Mean_Varianse(0, max, nums, N);
            f();
        }

        private void Exponential(double la, int N)
        {
            Random rnd = new Random();
            double alpha;
            alpha = rnd.NextDouble();
            int x, max = 0;
            int[] nums = new int[100000];

            c();
            chart1.Series[0].Name = "RV type";
            chart1.Series[2].Name = "λ= " + la;

            for (int i = 0; i < N; i++)
            {
                alpha = rnd.NextDouble();
                x= (int)(-Math.Log(alpha) / la);
                nums[x]++;
                if (x > max)
                    max = x;

            }


            for (int i = 0; i <= max; i++)
            {
                chart1.Series[2].Points.AddXY(i + 0.5, ((double)nums[i] / N));
                double y = la* Math.Exp(-la * i);
                chart1.Series[1].Points.AddXY(i, y);

            }

            Mean_Varianse(0, max, nums, N);
            f();
            chart1.Series[2].Name = " ";
        }

        //private int e(double la)
        //{
        //    Random rnd = new Random();
        //    double alpha;
        //    alpha = rnd.NextDouble();
        //    int x = (int)(-Math.Log(alpha) / la);
        //    return x;
        //}

        private void Hist(List<double> xs, List<double> ys, int N)
        {
            Random rnd = new Random();
            double alpha, xn;
            Dictionary<int, int> nums = new Dictionary<int, int>();
            int x, max = 0, min=100000;

            c();
            chart1.Series[0].Name = "RV given by histogram";

            for (int i=0;i<N; i++)
            {
                alpha = rnd.NextDouble();
                int k = -1;
                while (alpha>0)
                {
                    k++;
                    alpha -= ys[k] * (xs[k + 1] - xs[k]);
                }

                xn = xs[k + 1] + alpha / ys[k];
                x = (int)Math.Ceiling(xn);
                //x = pr(xn);
      
                if (nums.ContainsKey(x))
                {
                    nums[x] += 1;
                }
                else
                {
                    nums.Add(x, 1);
                }
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }

            v(nums,N, 0.5);

            Mean_Varianse_2(nums, N);
            f();
        }

        private void Hyper(int n, int N)
        {
            Random rnd = new Random();

            c();

            int j = rnd.Next(n) +1;
            double l=j*0.1;
            Exponential(l, N);

        }

        private void SND1(double fi, double a, int N)
        {
            Random rnd = new Random();
            int x, max = 0, min = 10000;
            double xn;
            Dictionary<int, int> nums = new Dictionary<int, int>();


            c();
            chart1.Series[2].Name = "σ= " + fi + "     a = " + a;

            for (int i=0; i<N; i++)
            {
                double sig = 0,s;
          
                for (int j =1; j<=12; j++)
                {
                    sig += rnd.NextDouble();
                }
                sig -= 6;
                //s = sig + (1 / 240) * (Math.Pow(sig, 3) - 3 * sig);
                xn = fi * sig + a;

                x = (int)Math.Ceiling(xn);
                //x = pr(xn);

                if (nums.ContainsKey(x))
                {
                    nums[x] += 1;
                }
                else
                {
                    nums.Add(x, 1);
                }
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }

            v(nums, N,0);
            norm(min, max, fi, a);

            //string s222="";
            //for (int i=min; i<=max; i++)
            //{
            //    if (!nums.ContainsKey(i))
            //        s222 = s222+" "+ i;
            //}
            //D.Text = s222;

            Mean_Varianse_2(nums, N);
            f();
        }

        private void SND2(double fi, double a, int N) 
        {
            Random rnd = new Random();
            int x, max = 0, min = 10000;
            double xn, alpha;
            Dictionary<int, int> nums = new Dictionary<int, int>();

            c();
            chart1.Series[2].Name = "σ= " + fi + "     a = " + a;

            for (int i = 0; i < N; i++)
            {
                double s = 0;
                alpha = rnd.NextDouble();
                s = F();
                if (alpha < 0.5)
                {
                    s *= -1;
                }
                xn = fi * s + a;
                x = (int)Math.Ceiling(xn);
                //x = pr(xn);

                if (nums.ContainsKey(x))
                {
                    nums[x] += 1;
                }
                else
                {
                    nums.Add(x, 1);
                }
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }

            v(nums, N, 0);
            norm(min, max, fi, a);

            Mean_Varianse_2(nums, N);
            f();
        }

        private void Gamma(double a, double b, int N)
        {
            Random rnd = new Random();
            int x, max = 0, min = 10000, d;
            double alpha, fi,n1,n2,xn;
            Dictionary<int, int> nums = new Dictionary<int, int>();

            c();
            chart1.Series[2].Name = "α= " + a + "     β = " + b;
            for (int i=0; i<N; i++)
            {
                double x1= 0, x2 = 0;
                int z = -1;
                d = (int)a;
                fi = a - d;
                if (d > 0)
                {
                    for (int j = 0; j < d; j++)
                    {
                        alpha = rnd.NextDouble();
                        x1 += -Math.Log(alpha);
                    }
                }
                if (fi > 0)
                {
                    double r = Math.Exp(1) / (Math.Exp(1) + fi);
                    while (z == -1)
                    {
                        double a1 = rnd.NextDouble();
                        double a2 = rnd.NextDouble();
                        if (a1 <= r)
                        {
                            n1 = Math.Pow((a1/r), (1 / fi));
                            n2 = a2 * Math.Pow(n1, (fi - 1));
                        }
                        else
                        {
                            n1 = 1 - Math.Log((a1 - r) / (1 - r));
                            n2 = a2 * Math.Exp(-n1);
                        }
                        if(!(n2>(Math.Pow(n1, (fi - 1))* Math.Exp(-n1))))
                        {
                            z = 0;
                            x2 = n1;
                        }
                    }
                }
                xn = (x1 + x2) / b;
                x = (int)Math.Ceiling(xn);

                if (nums.ContainsKey(x))
                {
                    nums[x] += 1;
                }
                else
                {
                    nums.Add(x, 1);
                }
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }

            v(nums, N, 0.5);

            Mean_Varianse_2(nums, N);
            f();
        }


        private void Mean_Varianse(int min, int max, int[] nums, int N)
        {
            double s = 0, s1 = 0;
            for (int i = min; i <= max; i++)
            {
                if (nums[i] != 0)
                {
                    s += (i * nums[i]);
                }
            }
            s /= N;
            for (int i = min; i <= max; i++)
            {
                if (nums[i] != 0)
                {
                     s1 += Math.Pow(((i*nums[i]) - s), 2);
                }  
            }
            s1 /= (N-1);
            M.Text = "Sample mean: " + s;
            D.Text = "Sample variance: " + s1;

        }


        private void Mean_Varianse_2(Dictionary<int, int> nums, int N)
        {
            double s = 0, s1 = 0;
            foreach (KeyValuePair<int, int> i in nums)
            {
                s += (i.Key*i.Value);
            }
            s /= N;
            foreach (KeyValuePair<int, int> i in nums)
            {
                s1 += Math.Pow(((i.Key * i.Value) - s), 2);
            }
            s1 /= (N - 1);
            M.Text = "Sample mean: " + s;
            D.Text = "Sample variance: " + s1;
        }

        Random rnd = new Random();
        private double F()
        {

            double fa = Math.Sqrt(-Math.Log(rnd.NextDouble()));
            double p = (2.30753 + 0.27061 * fa) / (1 + 0.99229 * fa + 0.04481 * Math.Pow(fa, 2)) - fa;
            return p;
        }

        public void f()
        {
            flag = true;
            button1.Enabled = true;
        }

        public void c()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
        }

        public double Factorial(int n)
        {
            double res = 1;
            for (int i = n; i > 1; i--)
                res *= i;
            return res;
        }


        public void v(Dictionary<int, int> nums, int N, double t)
        {
            foreach (KeyValuePair<int, int> i in nums)
            {
                if (i.Key < 0)
                {
                    chart1.Series[2].Points.AddXY((double)(i.Key - t), ((double)i.Value / N));
                }
                else
                {
                    chart1.Series[2].Points.AddXY((double)(i.Key - t), ((double)i.Value / N));
                }
            }
        }

        public int pr(double xn)
        {
            if (xn >= 0)
            {
                return (int)Math.Floor(xn);
            }
            else
            {
                return (int)Math.Ceiling(xn);
            }
        }

        private void norm(int min, int max, double fi, double a)
        {
            for (int i = min; i <= max; i++)
            {
                //double y = 1 / Math.Sqrt(1 / Math.PI) * Math.Exp(-Math.Pow(i, 2) / 2);
                double y = 1 / fi * Math.Sqrt(1 / Math.PI) * Math.Exp(-Math.Pow((i - a), 2) / 2 * Math.Pow(fi, 2));
                chart1.Series[1].Points.AddXY(i, y);
            }
        }
    }
}
