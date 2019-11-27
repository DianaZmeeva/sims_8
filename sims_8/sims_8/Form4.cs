using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_8
{
    public partial class Form4 : Form
    {
        public Form4(string s1, string s2)
        {
            InitializeComponent();
            label_p.Text = s1;
            label_r.Text = s2;
        }

        bool f = false;
        private void button1_Click(object sender, EventArgs e)
        {
            f = true;
            Close();
        }

        public double P
        {
            get
            {
                return (double)numeric_p.Value;
            }
        }

        public int R
        {
            get
            {
                return (int)numericUpDown_r.Value;
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
