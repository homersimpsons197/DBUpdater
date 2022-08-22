namespace DBUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(266, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnPath
            // 
            this.btnPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPath.BackgroundImage")));
            this.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPath.Location = new System.Drawing.Point(284, 6);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(31, 31);
            this.btnPath.TabIndex = 1;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.pass});
            this.dgv.Location = new System.Drawing.Point(12, 48);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(266, 186);
            this.dgv.TabIndex = 2;
            // 
            // user
            // 
            this.user.HeaderText = "Username";
            this.user.Name = "user";
            // 
            // pass
            // 
            this.pass.HeaderText = "Password";
            this.pass.Name = "pass";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(221, 240);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(57, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 273);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "DB uploader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.Button btnUpload;
        public System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
    }
}

