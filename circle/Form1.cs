using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
          
           

            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius;
            radius = double.Parse(textBox1.Text);

            double circumfrence = 2.0 * Math.PI * radius;
            label1.Text = "circumfrence = " + circumfrence;

            double area = Math.PI * (radius * radius);
            label2.Text = "area = " + area;
        }





    }
}
 