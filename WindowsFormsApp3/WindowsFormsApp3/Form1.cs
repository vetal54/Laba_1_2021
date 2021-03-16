using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Button[] arr = new Button[8];
       
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load_1(object sender, EventArgs e)
        {
            arr[0] = button2;
            arr[1] = button3;
            arr[2] = button4;
            arr[3] = button5;
            arr[4] = button6;
            arr[5] = button7;
            arr[6] = button8;
            arr[7] = button9;

            this.Controls.OfType<Button>().ToList().ForEach(button =>
            button.Click += button_Click);
        }
        
        void button_Click(object sender, EventArgs e)
        {
            string a = "button";
            
            for(int i =0;i<arr.Length;i++)
            {
                a += Convert.ToString(i + 1);
                if (((Button)sender).Name == a && ((Button)sender).Name!="button1") arr[i].Enabled = false;
                else if(((Button)sender).Name == "button9") arr[0].Enabled = false;
                a = a.Remove(a.Length - 1, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arr[0].Enabled = true;
            for (int i=0;i<arr.Length;i++)
                arr[i].Enabled = true;
            
        }
    }
}
