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
    public partial class ConstructForm : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private int indexOfFlat;
        private int indexOfDecor;
        private int sizeOfDecor = 50;
        private bool flat = false;

        private List<PictureBox> decors = new List<PictureBox>();

        public ConstructForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            panel1.Controls.Clear();
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            flat = true;
            indexOfFlat = listView1.Items.IndexOf(listView1.GetItemAt(e.X, e.Y));
            if (indexOfFlat != -1) listView1.DoDragDrop(listView1.Items[indexOfFlat].
                ImageIndex, DragDropEffects.Copy);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (flat) panel1.BackgroundImage = imgListFlat.Images[indexOfFlat];
            else
            {
                decors.Add(new PictureBox());
                panel1.Controls.Add(decors[decors.Count - 1]);
                decors[decors.Count - 1].Width = decors[decors.Count - 1].Height = sizeOfDecor;
                decors[decors.Count - 1].Image = imgListDecor.Images[indexOfDecor];
                decors[decors.Count - 1].MouseUp += new MouseEventHandler(pictureBox_MouseUp);
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { 
                PictureBox img = sender as  PictureBox;
                img.Left = img.Left + e.X - img.Width / 2;
                img.Top = img.Top + e.Y - img.Height / 2; }
            }

        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {
            flat = false;
            indexOfDecor = listView2.Items.IndexOf(listView2.GetItemAt(e.X, e.Y));
            if (indexOfDecor != -1) listView2.DoDragDrop(listView2.Items[indexOfDecor].ImageIndex,
                 DragDropEffects.Copy);
        }
    }
}
