namespace OpMinimize
{
    partial class frmScript
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.txtName = new System.Windows.Forms.TextBox();
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.lstbxHosts = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.btnSave);
            this.scMain.Panel1.Controls.Add(this.txtName);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scContent);
            this.scMain.Size = new System.Drawing.Size(451, 331);
            this.scMain.SplitterDistance = 29;
            this.scMain.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 22);
            this.txtName.TabIndex = 0;
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.Location = new System.Drawing.Point(0, 0);
            this.scContent.Name = "scContent";
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.txtCommands);
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.lstbxHosts);
            this.scContent.Panel2MinSize = 100;
            this.scContent.Size = new System.Drawing.Size(451, 298);
            this.scContent.SplitterDistance = 347;
            this.scContent.TabIndex = 0;
            // 
            // txtCommands
            // 
            this.txtCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommands.Location = new System.Drawing.Point(0, 0);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(347, 298);
            this.txtCommands.TabIndex = 0;
            // 
            // lstbxHosts
            // 
            this.lstbxHosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxHosts.FormattingEnabled = true;
            this.lstbxHosts.ItemHeight = 16;
            this.lstbxHosts.Location = new System.Drawing.Point(0, 0);
            this.lstbxHosts.Name = "lstbxHosts";
            this.lstbxHosts.Size = new System.Drawing.Size(100, 298);
            this.lstbxHosts.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(351, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Gem";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 331);
            this.Controls.Add(this.scMain);
            this.Name = "frmScript";
            this.Text = "frmScript";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel1.PerformLayout();
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.ListBox lstbxHosts;
        private System.Windows.Forms.Button btnSave;
    }
}