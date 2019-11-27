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
    public partial class Form8 : Form
    {
        public Form8(string s1, string s2)
        {
            InitializeComponent();
            label_l.Text = s1;
            label2.Text = s2;
        }

        bool f = false;
        private void button1_Click(object sender, EventArgs e)
        {
            f = true;
            Close();
        }

        public double F
        {
            get
            {
                return (double)numericUpDown1.Value;
            }
        }
        public double A
        {
            get
            {
                return (double)numericUpDown2.Value;
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
