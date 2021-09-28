
namespace csrLogViewer
{
    partial class start
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
            this.whereis = new System.Windows.Forms.Button();
            this.whatis = new System.Windows.Forms.Button();
            this.isxy = new System.Windows.Forms.Button();
            this.dirbtn = new System.Windows.Forms.Button();
            this.logpath = new System.Windows.Forms.TextBox();
            this.seed = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // whereis
            // 
            this.whereis.Location = new System.Drawing.Point(12, 51);
            this.whereis.Name = "whereis";
            this.whereis.Size = new System.Drawing.Size(116, 23);
            this.whereis.TabIndex = 0;
            this.whereis.Text = "Where is item X?";
            this.whereis.UseVisualStyleBackColor = true;
            this.whereis.Click += new System.EventHandler(this.button1_Click);
            // 
            // whatis
            // 
            this.whatis.Location = new System.Drawing.Point(134, 51);
            this.whatis.Name = "whatis";
            this.whatis.Size = new System.Drawing.Size(116, 23);
            this.whatis.TabIndex = 1;
            this.whatis.Text = "What is Check X?";
            this.whatis.UseVisualStyleBackColor = true;
            this.whatis.Click += new System.EventHandler(this.button2_Click);
            // 
            // isxy
            // 
            this.isxy.Location = new System.Drawing.Point(256, 51);
            this.isxy.Name = "isxy";
            this.isxy.Size = new System.Drawing.Size(116, 23);
            this.isxy.TabIndex = 2;
            this.isxy.Text = "Is Check X Item Y?";
            this.isxy.UseVisualStyleBackColor = true;
            this.isxy.Click += new System.EventHandler(this.button3_Click);
            // 
            // dirbtn
            // 
            this.dirbtn.Location = new System.Drawing.Point(12, 25);
            this.dirbtn.Name = "dirbtn";
            this.dirbtn.Size = new System.Drawing.Size(75, 20);
            this.dirbtn.TabIndex = 3;
            this.dirbtn.Text = "Log path";
            this.dirbtn.UseVisualStyleBackColor = true;
            this.dirbtn.Click += new System.EventHandler(this.dirbtn_Click);
            // 
            // logpath
            // 
            this.logpath.Location = new System.Drawing.Point(93, 25);
            this.logpath.Name = "logpath";
            this.logpath.Size = new System.Drawing.Size(279, 20);
            this.logpath.TabIndex = 4;
            this.logpath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.logpath_KeyUp);
            // 
            // seed
            // 
            this.seed.AutoSize = true;
            this.seed.Location = new System.Drawing.Point(85, 9);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(0, 13);
            this.seed.TabIndex = 5;
            // 
            // start
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 86);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.logpath);
            this.Controls.Add(this.dirbtn);
            this.Controls.Add(this.isxy);
            this.Controls.Add(this.whatis);
            this.Controls.Add(this.whereis);
            this.Name = "start";
            this.Text = "csLogViewer";
            this.Load += new System.EventHandler(this.start_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.start_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.start_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button whereis;
        private System.Windows.Forms.Button whatis;
        private System.Windows.Forms.Button isxy;
        private System.Windows.Forms.Button dirbtn;
        private System.Windows.Forms.TextBox logpath;
        private System.Windows.Forms.Label seed;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

