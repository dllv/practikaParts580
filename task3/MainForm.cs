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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            furnitureArray[0, 0] = "Название";
            furnitureArray[0, 1] = "Тип";
            furnitureArray[0, 2] = "Производитель";

            furnitureArray[1, 0] = "Нормальный";
            furnitureArray[1, 1] = "Диван";
            furnitureArray[1, 2] = "Диваны и диваны";

            furnitureArray[2, 0] = "Сидячий";
            furnitureArray[2, 1] = "Стул";
            furnitureArray[2, 2] = "Компания";
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
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WatchForm watchForm = new WatchForm();
            watchForm.Show();
        }
    }
}
