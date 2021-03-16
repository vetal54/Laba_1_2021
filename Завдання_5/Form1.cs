using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();             
        }
        private bool n = true;

        private void destroyLabels_Click(object sender, EventArgs e)
        {
            if (n == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    Controls.RemoveAt(0);
                }
                n = false;
            }         

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
