using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krikorian_Programming_Assignment
{

    public partial class Form1 : Form
    {
        public static String UserInput { get; set; }
        public static bool UpdateList { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Clear the listbox
            while (listBox1.Items.Count != 0)
            {
                listBox1.Items.RemoveAt(0);
            }

            //Generate 1000 random numbers and add them to the listbox
            Random r = new Random();
            for (int x=0; x<1000; x++)
            {
                listBox1.Items.Add(r.Next(10000000));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormDialog f2 = new FormDialog();
            f2.ShowDialog();

            //If user clicked OK, clear the listbox and display their input
            if(UpdateList == true)
            {
                while (listBox1.Items.Count != 0)
                {
                    listBox1.Items.RemoveAt(0);
                }
                listBox1.Items.Add(UserInput);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //Write message to text file
            string pathString = @"c:\output";
            System.IO.Directory.CreateDirectory(pathString);
            string path = @"C:\output\output.txt";
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine("The Program has closed successfully.");
            }

            this.Close();
        }

    }
}