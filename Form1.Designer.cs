namespace FirstWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChange = new System.Windows.Forms.Button();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.cboFontSize = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.openFilePic = new System.Windows.Forms.OpenFileDialog();
            this.btnAni = new System.Windows.Forms.Button();
            this.tmrAni = new System.Windows.Forms.Timer(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.grpFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 12);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 33);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "变化";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.cboFontSize);
            this.grpFont.Controls.Add(this.radioButton3);
            this.grpFont.Controls.Add(this.radioButton2);
            this.grpFont.Controls.Add(this.radioButton1);
            this.grpFont.Location = new System.Drawing.Point(13, 61);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(200, 157);
            this.grpFont.TabIndex = 1;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "改变字体";
            // 
            // cboFontSize
            // 
            this.cboFontSize.FormattingEnabled = true;
            this.cboFontSize.Location = new System.Drawing.Point(7, 112);
            this.cboFontSize.Name = "cboFontSize";
            this.cboFontSize.Size = new System.Drawing.Size(121, 26);
            this.cboFontSize.TabIndex = 3;
            this.cboFontSize.SelectedIndexChanged += new System.EventHandler(this.CboFontSize_SelectedIndexChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(105, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "微软雅黑";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "宋体";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "黑体";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPhoto.Location = new System.Drawing.Point(257, 12);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(100, 100);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPhoto.TabIndex = 2;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.PicPhoto_Click);
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(257, 167);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(94, 32);
            this.btnAddPic.TabIndex = 3;
            this.btnAddPic.Text = "添加图片";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // openFilePic
            // 
            this.openFilePic.FileName = "photo";
            // 
            // btnAni
            // 
            this.btnAni.Location = new System.Drawing.Point(257, 208);
            this.btnAni.Name = "btnAni";
            this.btnAni.Size = new System.Drawing.Size(94, 35);
            this.btnAni.TabIndex = 4;
            this.btnAni.Text = "图片动画";
            this.btnAni.UseVisualStyleBackColor = true;
            this.btnAni.Click += new System.EventHandler(this.btnAni_Click);
            // 
            // tmrAni
            // 
            this.tmrAni.Interval = 1000;
            this.tmrAni.Tick += new System.EventHandler(this.tmrAni_Tick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "64.png");
            this.imgList.Images.SetKeyName(1, "65.png");
            this.imgList.Images.SetKeyName(2, "66.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 313);
            this.Controls.Add(this.btnAni);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.grpFont);
            this.Controls.Add(this.btnChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private int imgListCount = 0;

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cboFontSize;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.OpenFileDialog openFilePic;
        private System.Windows.Forms.Button btnAni;
        private System.Windows.Forms.Timer tmrAni;
        private System.Windows.Forms.ImageList imgList;
    }
}

