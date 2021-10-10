using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2CS
{
    public partial class Done : Form
    {
        public Done()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab2 start = new Lab2();
            start.StartPosition = FormStartPosition.Manual;
            start.Location = this.Location;
            start.ShowDialog();
            this.Close();
        }
    }
}
