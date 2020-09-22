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

        private void btnChange_Click(object sender, EventArgs e)
        {
            (this.Owner as TestForm).lblChange.Text = "已经改变";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化radiobtn的checkchange 函数
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
                    if ((ctl as RadioButton).Checked)
                    {
                        (this.Owner as TestForm).Font = new Font((ctl as RadioButton).Text, 12);
                    }
                }
            }
        }

        private void cboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontname = (this.Owner as TestForm).Font.Name;
            (this.Owner as TestForm).Font = new Font(fontname, float.Parse(cboFontSize.Text));
        }
    }
}
