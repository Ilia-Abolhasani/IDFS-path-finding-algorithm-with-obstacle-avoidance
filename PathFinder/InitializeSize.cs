using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathFinder
{
    public partial class InitializeSize : Form
    {
        public InitializeSize()
        {
            InitializeComponent();
            Data.Width = (int)numericUpDown1.Value;
            Data.Height = (int)numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Data.Width= (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Data.Height = (int)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main form = new Main();
            form.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data.Is8Side = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Data.Is8Side = true;
        }
    }
}
