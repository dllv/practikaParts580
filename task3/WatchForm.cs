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
    public partial class WatchForm : Form
    {
        public WatchForm()
        {
            InitializeComponent();
            printArray();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            int matchingRows = 0;
            if (comboBox1.SelectedItem.ToString() != "Всё")
            {
                label1.Text = "Название\n";
                label2.Text = "Тип\n";
                label3.Text = "Производитель\n";
                
                for (int i = 1; i < arrSize; i++)
                {
                    if (furnitureArray[i, 1] == comboBox1.SelectedItem.ToString())
                    {
                        matchingRows++;
                        label1.Text += furnitureArray[i, 0] + '\n';
                        label2.Text += furnitureArray[i, 1] + '\n';
                        label3.Text += furnitureArray[i, 2] + '\n';
                    }
                }
            }
            else
            {
                matchingRows = arrSize - 1;
                printArray();
            }
            label4.Text = "Совпадений: " + matchingRows;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "") 
            {
                label1.Text = "Название\n";
                label2.Text = "Тип\n";
                label3.Text = "Производитель\n";
                for (int i = 1; i < arrSize; i++)
                    if (furnitureArray[i, 0].ToString().ToLower().StartsWith(textBox1.Text.ToLower()))
                    {
                        label1.Text += furnitureArray[i, 0] + '\n';
                        label2.Text += furnitureArray[i, 1] + '\n';
                        label3.Text += furnitureArray[i, 2] + '\n';
                    }

            } else
            {
                printArray();
            }
        }

        void printArray()
        {
            label1.Text = "Название\n";
            label2.Text = "Тип\n";
            label3.Text = "Производитель\n";

            for (int i = 1; i < arrSize; i++)
            {
                label1.Text += furnitureArray[i, 0] + '\n';
                label2.Text += furnitureArray[i, 1] + '\n';
                label3.Text += furnitureArray[i, 2] + '\n';
            }
        }
    }
}
