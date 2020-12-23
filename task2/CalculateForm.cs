using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class CalculateForm : Form
    {
        private static short n = 4;
        private short[,] tileSize = new short[n, 2];
        private short[] tileCount = new short[n];

        public CalculateForm()
        {
            InitializeComponent();
            tileSize[0, 0] = 10; 
            tileSize[0, 1] = 10; 
            tileSize[1, 0] = 15; 
            tileSize[1, 1] = 15; 
            tileSize[2, 0] = 10; 
            tileSize[2, 1] = 15; 
            tileSize[3, 0] = 20; 
            tileSize[3, 1] = 20; //заполениесписка "количество"       
            tileCount[0] = 8;       
            tileCount[1] = 10;       
            tileCount[2] = 12;       
            tileCount[3] = 20;

            for (int i = 0; i < n; i++) 
                comboBox1.Items.Add(String.Format("{0}x{1}", tileSize[i, 0], tileSize[i, 1]));
            for   ( int   i = 0; i < n; i++) 
                comboBox2.Items.Add(String.Format("{0}", tileCount[i]));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8)) e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal square = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            decimal _square = tileSize[comboBox1.SelectedIndex, 0] * tileSize[comboBox1.SelectedIndex, 1];
            decimal result = Math.Ceiling(square/_square / tileCount[comboBox2.SelectedIndex]);
            textBox3.Text = result.ToString();
        }
    }
}
