using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Write_code_to_draw
{
    /// <summary>
    /// This is the panel for the designs that will work functionally for out application
    /// </summary>
    public partial class Panel : Form
    {

        /// <summary>
        /// Initiallizing the Graphics named graphic to draw in the application for the different commands in the code
        /// </summary>
        public static Graphics graphic;


        /// <summary>
        /// Panel is the constructor that initializes the application.
        /// </summary>
        public Panel()
        {
            InitializeComponent();
            graphic = this.pictureBox1.CreateGraphics();

        }

        /// <summary>
        /// method that removes the output / errors or text changed 
        /// </summary>

        public void Clear()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.label3.Text = "";
            this.label16.Text = "";
        }

        /// <summary>
        /// Resets that application for a fresh start.
        /// </summary>
        public void Reset()
        {
            this.Clear();
            pictureBox1.Refresh();
            graphic.ResetTransform();
        }

        /// <summary>
        /// Function that is called whenever the button1 in the form is clicked.
        /// executes the programme for further operations
        /// </summary>
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string comm = this.textBox2.Text.ToLower().Trim();
            if (comm == "")
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

        /// <summary>
        /// Function that is called whenever the button2 in the form is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e)
        {

            this.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.WriteLine(textBox1.Text +"/run ");
                write.Close();
                MessageBox.Show("File Saved Successfully");
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Browse file from specified folder";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Filter = "DOCX files (*.docx)|*.docx|All files (*.*)|*.*";

            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            //Browse .txt file from computer
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

                //displays the text inside the file on TextBox named as txtInput
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);

            }
        }
    }
}
