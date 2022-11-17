using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShapesLib;

namespace ShapesUI
{
    public partial class Form1 : Form
    {
        private List<string[]> parametrs;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetDemoObject_Click(object sender, EventArgs e)
        {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Title = "Select your File";
                openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
                openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                {
                    textBox1.Text = "File selected.";
                    parametrs = ShapeOption.GetParam(openFileDialog1.FileName);
                }
                else
                { 
                    textBox1.Text = "Select the file!"; 
                }
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < int.Parse(parametrs[0][0])+1; i++)
            {
                var shape = ShapeOption.CreateShapes(parametrs, i);
                textAllocator.Text += shape.ToString() + "\r\n";
            }
        }
    }
}
