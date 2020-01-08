namespace LUTGCaster
{
    partial class CastingSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param rName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.btnChkBlk = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChkBlk
            // 
            this.btnChkBlk.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnChkBlk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChkBlk.Location = new System.Drawing.Point(258, 25);
            this.btnChkBlk.Name = "btnChkBlk";
            this.btnChkBlk.Size = new System.Drawing.Size(104, 23);
            this.btnChkBlk.TabIndex = 3;
            this.btnChkBlk.Text = "Check Blocks";
            this.btnChkBlk.UseVisualStyleBackColor = true;
            this.btnChkBlk.Click += new System.EventHandler(this.BtnChkBlk_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(12, 25);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(90, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save Sheet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(108, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load Sheet";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // CastingSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1588, 55);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnChkBlk);
            this.Name = "CastingSheet";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChkBlk;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

