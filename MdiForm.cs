using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < MaxNum)
            {
                var frm = new BlankForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void 全部最大化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Maximized;
            }
        }

        private void 全部最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Minimized;
            }
        }

        private void 全部关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in this.MdiChildren)
            {
                item.Close();
            }
        }

        private void 层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
