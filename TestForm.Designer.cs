namespace FirstWinForm
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.btn_input = new System.Windows.Forms.Button();
            this.lis_names = new System.Windows.Forms.ListBox();
            this.txtb_input = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(50, 366);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 23);
            this.btn_input.TabIndex = 0;
            this.btn_input.Text = "添加";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // lis_names
            // 
            this.lis_names.FormattingEnabled = true;
            this.lis_names.ItemHeight = 18;
            this.lis_names.Location = new System.Drawing.Point(50, 232);
            this.lis_names.Name = "lis_names";
            this.lis_names.Size = new System.Drawing.Size(120, 94);
            this.lis_names.TabIndex = 2;
            // 
            // txtb_input
            // 
            this.txtb_input.Location = new System.Drawing.Point(50, 332);
            this.txtb_input.Name = "txtb_input";
            this.txtb_input.Size = new System.Drawing.Size(100, 28);
            this.txtb_input.TabIndex = 3;
            this.txtb_input.TextChanged += new System.EventHandler(this.txtb_input_TextChanged);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(173, 342);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(62, 18);
            this.lbl_num.TabIndex = 4;
            this.lbl_num.Text = "label1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.txtb_input);
            this.Controls.Add(this.lis_names);
            this.Controls.Add(this.btn_input);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TestForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.ListBox lis_names;
        private System.Windows.Forms.TextBox txtb_input;
        private System.Windows.Forms.Label lbl_num;
    }
}