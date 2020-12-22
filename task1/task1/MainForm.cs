using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.button1, "Выход из приложения");
            toolTip1.SetToolTip(this.button2, "Предпросмотр бейджа и печать");
            toolTip1.SetToolTip(this.button3, "Выберите изображение с вашего компьютера");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8)) e.Handled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox1.Text != "") && (openFileDialog1.FileName != ""))
            { 
                PreviewForm previewFrm = new PreviewForm(textBox1.Text, textBox2.Text,
                    comboBox1.Text, openFileDialog1.FileName);
                previewFrm.ShowDialog(); 
            }
        }
    }
}
