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
    public partial class Panel : Form
    {
        public static Graphics g;

        public Panel()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            g = this.pictureBox1.CreateGraphics();
            Command_validator cv = new Command_validator(this.textBox1.Text,this.textBox2.Text);
            string[] error = cv.error_command_handler();
            label3.Text = error[0];
            label16.Text = error[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            label3.Text = "";
            label16.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
        public void Reset()
        {
            this.Clear();
            pictureBox1.Refresh();
            g.ResetTransform();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
