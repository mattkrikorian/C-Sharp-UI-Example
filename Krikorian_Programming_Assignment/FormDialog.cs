using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krikorian_Programming_Assignment
{
    public partial class FormDialog : Form
    {

        public FormDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //OK Button
        {
            Form1.UserInput = textBox1.Text;
            Form1.UpdateList = true;
            this.Close();

        }
        private void button2_Click(object sender, EventArgs e) //Cancel Button
        {
            Form1.UpdateList = false;
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
