using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintingapp
{
    public partial class MyPaint : Form
    {
        Bitmap Bitmap = new Bitmap(1920, 1080);
        Pen pen = new Pen(Color.Black, 5);
        bool IsDrawing = false;
        int ThePenSize = 5;
        Image OpenedFile;

        public MyPaint()
        {
            InitializeComponent();

            for(int i = 0; i < Bitmap.Width; i++)
            {
                for(int j = 0; j < Bitmap.Height; j++)
                {
                    Bitmap.SetPixel(i, j, Color.White);
                }
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void Board_PB_MouseDown(object sender, MouseEventArgs e)
        {
            if(IsDrawing == true)
            {
                IsDrawing = false;
            }
            else
            {
                IsDrawing = true;
            }
        }

        private void Board_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing == true)
            {
                Graphics graphics = Graphics.FromImage(Bitmap);
                graphics.DrawRectangle(pen, e.X, e.Y, ThePenSize, ThePenSize);
                Board_PB.Image = Bitmap;
            } 
        }

        private void Black_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void Red_Btn_Click(object sender, EventArgs e)
        {
            pen.Color= Color.Red;
        }

        private void Yellow_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void Blue_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void PenSize_5_Click(object sender, EventArgs e)
        {
            ThePenSize = 5;
        }

        private void PenSize_10_Click(object sender, EventArgs e)
        {
            ThePenSize = 10;
        }

        private void PenSize_15_Click(object sender, EventArgs e)
        {
            ThePenSize = 15;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image *.bmp|";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            if(saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                switch(saveFileDialog.FilterIndex)
                {
                    case 1:
                        this.Board_PB.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.Board_PB.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
                fs.Close();
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog Op = new OpenFileDialog();
            DialogResult dr = Op.ShowDialog();
            if(dr == DialogResult.OK)
            {
                OpenedFile = Image.FromFile(Op.FileName);
                Board_PB.Image = OpenedFile;
            }
        }
    }
}
