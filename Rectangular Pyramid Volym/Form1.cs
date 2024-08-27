using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangular_Pyramid_Volym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string PyramidVolym()
        {
            double H = double.Parse(textBox3.Text);
            double A = PyramidArea();
            double V = (A * H) / 3;
            return V.ToString();


        }


        public double PyramidArea()
        {
            double L = double.Parse(textBox1.Text);
            double B = double.Parse(textBox2.Text);
            double A = L * B;
            AreaText.Text = A.ToString();   
            return A;

        }
            


        private void button1_Click(object sender, EventArgs e)
        {
            VolymText.Text = PyramidVolym();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
