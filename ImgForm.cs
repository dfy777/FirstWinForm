using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class ImgForm : Form
    {
        public ImgForm()
        {
            InitializeComponent();
        }

        private void ImgForm_Load(object sender, EventArgs e)
        {
            var images = GetImageFileNameList();
            ShowImages(images);
        }


        private void ShowImages(List<string> images)
        {
            int x = 0;
            int y = 0;
            int index = 0;

            foreach(var item in images)
            {
                if (index % 4 == 0 && index > 0)
                {
                    x = 0;
                    y += 110;
                }

                PictureBox picbox = new PictureBox();
                picbox.Size = new System.Drawing.Size(100, 100);
                picbox.Location = new Point(x, y);

                picbox.Load(item);
                this.Controls.Add(picbox);
                x += 110;
                index += 1;
            }
        }
        

        private List<string> GetImageFileNameList()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return Directory.GetFiles(path, "*.png", SearchOption.TopDirectoryOnly).ToList(); ;
        }
    }
}
