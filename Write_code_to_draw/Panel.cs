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
        public static Graphics graphic;

        public Panel()
        {
            InitializeComponent();
            graphic = this.pictureBox1.CreateGraphics();

        }

        public void Clear()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.label3.Text = "";
            this.label16.Text = "";
        }
        public void Reset()
        {
            this.Clear();
            pictureBox1.Refresh();
            graphic.ResetTransform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comm = this.textBox2.Text.ToLower().Trim();
            if(comm=="")
            {
                this.label16.Text = "**Feild is empty**";
            }
            else if (comm == "run")
            {
                Validation valid = new Validation(this.textBox1.Text, graphic);
                string[] errors = valid.error_handling_validation();
                this.label3.Text = errors[0];
                this.label16.Text = errors[1];

            }
            else if (comm == "clear")
            {
                Clear();
            }
            else if (comm == "reset")
            {
                Reset();
            }
            else
            {
                label16.Text = "**Please enter a valid command**";
            }
            

        }
        
        public void button2_Click(object sender, EventArgs e)
        {

            this.Clear();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
