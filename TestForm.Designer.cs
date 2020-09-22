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
            this.btn_input = new System.Windows.Forms.Button();
            this.lis_names = new System.Windows.Forms.ListBox();
            this.txb_input = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.btnNewWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(50, 366);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 30);
            this.btn_input.TabIndex = 0;
            this.btn_input.Text = "添加";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.BtnInput_Click);
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
            // txb_input
            // 
            this.txb_input.Location = new System.Drawing.Point(50, 332);
            this.txb_input.Name = "txb_input";
            this.txb_input.Size = new System.Drawing.Size(100, 28);
            this.txb_input.TabIndex = 3;
            this.txb_input.TextChanged += new System.EventHandler(this.TxbInput_TextChanged);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(173, 342);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(17, 18);
            this.lbl_num.TabIndex = 4;
            this.lbl_num.Text = "0";
            // 
            // btnNewWindow
            // 
            this.btnNewWindow.Location = new System.Drawing.Point(50, 33);
            this.btnNewWindow.Name = "btnNewWindow";
            this.btnNewWindow.Size = new System.Drawing.Size(75, 33);
            this.btnNewWindow.TabIndex = 5;
            this.btnNewWindow.Text = "跳转";
            this.btnNewWindow.UseVisualStyleBackColor = true;
            this.btnNewWindow.Click += new System.EventHandler(this.btnNewWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 6;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(176, 33);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(17, 18);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "0";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewWindow);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.txb_input);
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
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.ListBox lis_names;
        private System.Windows.Forms.TextBox txb_input;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Button btnNewWindow;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblChange;
    }
}