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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool f=false;
        private void button1_Click(object sender, EventArgs e)
        {
            f = true;
            Close();
        }

        public int A
        {
            get
            {
                return (int)numericUpDown_a.Value;
            }
        }

        public int B
        {
            get
            {
                return (int)numericUpDown_b.Value;
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
