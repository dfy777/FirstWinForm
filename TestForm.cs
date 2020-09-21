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

        private void btn_input_Click(object sender, EventArgs e)
        {
            lis_names.Items.Add(txtb_input.Text);
        }

        private void txtb_input_TextChanged(object sender, EventArgs e)
        {
            lbl_num.Text = txtb_input.Text.Length.ToString();
        }

        
    }
}
