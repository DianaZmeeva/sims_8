using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_8
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        bool f = false;
        private void button1_Click(object sender, EventArgs e)
        {
            f = true;
            Close();
        }

        public List<double> X
        {
            get
            {
                List<double> xs = Regex.Split(X_text.Text, @";").ToList().Select(p => double.Parse(p)).ToList();
                return xs;
            }
        }

        public List<double> Y
        {
            get
            {
                List<double> ys = Regex.Split(Y_text.Text, @";").ToList().Select(p => double.Parse(p)).ToList();
                return ys;
            }
        }

        public bool Flag
        {
            get
            {
                return f;
            }
        }
    }
}
