using SC.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SC
{
     public partial class Form1 : Form
     {      
          ParserServices _parser = new ParserServices();

          public Form1()
          {
               InitializeComponent();
          }

          private void Browse_Click(object sender, EventArgs e)
          {
               OpenFileDialog im = new OpenFileDialog();
               im.Title = "Select Polices";
               im.Filter = "All files(*.*)|*.*|All files(*.*)|*.*";
               im.FilterIndex = 100;
               im.RestoreDirectory = true;
               if (im.ShowDialog() == DialogResult.OK)
               {
                    textBox1.Text = im.FileName;
               }

          }

          private void button1_Click(object sender, EventArgs e)
          {
               var im = new FolderBrowserDialog();              
               if (im.ShowDialog() == DialogResult.OK)
               {
                    textBox2.Text = im.SelectedPath;
               }
          }

          private void button2_Click(object sender, EventArgs e)
          {
               if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
               {
                    _parser.GetFileText(textBox1.Text, textBox2.Text, textBox3.Text);
               }
          }
     }
}
