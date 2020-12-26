using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static task3.Data;

namespace task3
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isUnique(textBox1.Text))
            addNewEntry(ref furnitureArray, textBox1.Text,
                comboBox1.SelectedItem.ToString(), textBox2.Text);
            else
            {
                MessageBox.Show("Такой уже есть!");
                textBox1.Text = "";
            }
        }

        bool isUnique(string input)
        {
            for (int i = 0; i < arrSize; i++)
            {
                if (input == furnitureArray[i, 0]) return false;
            } 
            return true;
        }
    }
}
