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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            lis_names.Items.Add(txb_input.Text);
        }

        private void TxbInput_TextChanged(object sender, EventArgs e)
        {
            lbl_num.Text = txb_input.Text.Length.ToString();
        }

        private void btnNewWindow_Click(object sender, EventArgs e)
        {
            var frm1 = new Form1();
            frm1.Show(this);
        }

        private void btnShowImages_Click(object sender, EventArgs e)
        {
            var frm_images = new ImgForm();
            frm_images.Show();
        }
    }
}
