using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            (this.Owner as TestForm).lblChange.Text = "已经改变";
        }

        
        //窗体初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            this.imgListCount = 0;
            this.tmrAni.Enabled = false;

            //初始化radiobtn的checkchange 函数
            //初始化combobox的可选择item
            foreach (var ctl in grpFont.Controls)
            {
                if (ctl is RadioButton)
                {
                    (ctl as RadioButton).CheckedChanged += ModifyFont;
                }

                //字体从5到19大小变化
                if (ctl is ComboBox)
                {
                    for( int fontsize = 5; fontsize < 20; fontsize++)
                    {
                        (ctl as ComboBox).Items.Add(fontsize);
                    }
                }
            }
        }

        private void ModifyFont(object sender, EventArgs e)
        {
            //遍历所有groupbox中的控件
            foreach (var ctl in grpFont.Controls)
            {
                //如果是RadioBtn
                if (ctl is RadioButton)
                {
                    //如果被选中就改变字体
                    if ((ctl as RadioButton).Checked)
                    {
                        (this.Owner as TestForm).Font = new Font((ctl as RadioButton).Text, 12);
                    }
                }
            }
        }

        private void CboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontname = (this.Owner as TestForm).Font.Name;   //获取当前使用字体名字
            (this.Owner as TestForm).Font = new Font(fontname, float.Parse(cboFontSize.Text));
        }

        private void PicPhoto_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            //打开文件对话框选择图片后获取其路径
            if (openFilePic.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(openFilePic.FileName);
            }
        }

        private void tmrAni_Tick(object sender, EventArgs e)
        {
            picPhoto.Image = imgList.Images[(imgListCount++) % imgList.Images.Count];
        }

        private void btnAni_Click(object sender, EventArgs e)
        {
            if (tmrAni.Enabled)
            {
                tmrAni.Stop();
                this.imgListCount = 0;
            }
            else
            {
                tmrAni.Start();
            }
        }
    }
}
