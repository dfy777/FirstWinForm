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
            ///寻找桌面上的png图片并排列显示在窗口中
            //var images = GetImageFileNameList();
            //ShowImages(images);
            

            ///用listview列举出桌面png图片
            ///选择相应的图片并显示
            PopulateListView();
            InitializePictureBox();
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
                    y += 150;
                }

                PictureBox picbox = new PictureBox();
                picbox.Size = new System.Drawing.Size(140, 140);
                picbox.Location = new Point(x, y);
                picbox.SizeMode = PictureBoxSizeMode.StretchImage;      //拉伸
                picbox.BorderStyle = BorderStyle.Fixed3D;

                picbox.Load(item);
                this.Controls.Add(picbox);
                x += 145;
                index += 1;
            }
        }
        

        private List<string> GetImageFileNameList()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return Directory.GetFiles(path, "*.png", SearchOption.TopDirectoryOnly).ToList(); ;
        }


        private void PopulateListView()
        {
            listView.Width = 270;
            listView.Height = 300;
            listView.Location = new System.Drawing.Point(10, 10);

            // Declare and construct the ColumnHeader objects.
            ColumnHeader header1, header2;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();

            // Set the text, alignment and width for each column header.
            header1.Text = "File name";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 70;

            header2.TextAlign = HorizontalAlignment.Left;
            header2.Text = "Location";
            header2.Width = 200;

            // Add the headers to the ListView control.
            listView.Columns.Add(header1);
            listView.Columns.Add(header2);

            // Specify that each item appears on a separate line.
            listView.View = View.Details;

            // Populate the ListView.Items property.
            // Set the directory to the sample picture directory.
            DirectoryInfo dirInfo =
                new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            // Get the .jpg files from the directory
            FileInfo[] files = dirInfo.GetFiles("*.png");

            // Add each file name and full name including path
            // to the ListView.
            if (files != null)
            {
                foreach (FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.FullName);
                    listView.Items.Add(item);
                }
            }
        }

        private void InitializePictureBox()
        {
            //picBox = new PictureBox();

            // Set the location and size of the PictureBox control.
            this.picBox.Location = new System.Drawing.Point(350, 100);
            this.picBox.Size = new System.Drawing.Size(140, 140);
            this.picBox.TabStop = false;
    
            // Set the SizeMode property to the StretchImage value.  This
            // will shrink or enlarge the image as needed to fit into
            // the PictureBox.
            this.picBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Set the border style to a three-dimensional border.
            this.picBox.BorderStyle = BorderStyle.Fixed3D;

            // Add the PictureBox to the form.
            //this.Controls.Add(this.picBox);
        }

        private void listView_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem selection = listView.GetItemAt(e.X, e.Y);

            if (selection != null)
            {
                picBox.Image = Image.FromFile(selection.SubItems[1].Text);
            }
        }


    }
}
