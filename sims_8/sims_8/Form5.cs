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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        bool f = false;
        private void button1_Click(object sender, EventArgs e)
        {
            f = true;
            Close();
        }

        public double L
        {
            get
            {
                return (double)numericUpDown_l.Value;
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
