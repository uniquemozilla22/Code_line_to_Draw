using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Write_code_to_draw
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label3.Text = "Circle<space><radius>";
            this.label4.Text = "Circle 50 | circle 20";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.label3.Text = "Rectangle<space><length>,<breadth>";
            this.label4.Text = "Rectangle 50,50";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.label3.Text = "Triangle<space><side1>,<side2>,<side3>";
            this.label4.Text = "Triangle 30,50,100";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.label3.Text = "moveto<space><point1>,<point2>";
            this.label4.Text = "moveto 30,100";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.label3.Text = "drawto<space><point1>,<point2>";
            this.label4.Text = "drawto 30,100";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label3.Text = "pen<space><color_name>";
            this.label4.Text = "pen green";

        }
    }
}
