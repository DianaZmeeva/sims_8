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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        public bool Flag
        {
            get
            {
                return f;
            }
        }
    }
}
