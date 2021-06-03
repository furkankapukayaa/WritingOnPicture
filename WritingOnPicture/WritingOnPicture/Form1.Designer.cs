
namespace WritingOnPicture
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnResim = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoyut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResim
            // 
            this.btnResim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResim.FlatAppearance.BorderSize = 0;
            this.btnResim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnResim, "btnResim");
            this.btnResim.ImageList = this.ımageList1;
            this.btnResim.Name = "btnResim";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "color.png");
            this.ımageList1.Images.SetKeyName(1, "image.png");
            this.ımageList1.Images.SetKeyName(2, "save.png");
            this.ımageList1.Images.SetKeyName(3, "writing.png");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRenk
            // 
            this.btnRenk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenk.FlatAppearance.BorderSize = 0;
            this.btnRenk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRenk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnRenk, "btnRenk");
            this.btnRenk.ImageList = this.ımageList1;
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdir.FlatAppearance.BorderSize = 0;
            this.btnYazdir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnYazdir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnYazdir, "btnYazdir");
            this.btnYazdir.ImageList = this.ımageList1;
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtMetin
            // 
            resources.ApplyResources(this.txtMetin, "txtMetin");
            this.txtMetin.Name = "txtMetin";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtBoyut
            // 
            resources.ApplyResources(this.txtBoyut, "txtBoyut");
            this.txtBoyut.Name = "txtBoyut";
            this.txtBoyut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoyut_KeyPress);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnRenk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoyut;
    }
}

