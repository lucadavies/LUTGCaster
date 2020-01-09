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
            this.btnChkNames = new System.Windows.Forms.Button();
            this.lblChkNames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChkBlk
            // 
            this.btnChkBlk.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnChkBlk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChkBlk.Location = new System.Drawing.Point(258, 10);
            this.btnChkBlk.Name = "btnChkBlk";
            this.btnChkBlk.Size = new System.Drawing.Size(104, 36);
            this.btnChkBlk.TabIndex = 3;
            this.btnChkBlk.Text = "Check Blocks";
            this.btnChkBlk.UseVisualStyleBackColor = true;
            this.btnChkBlk.Click += new System.EventHandler(this.BtnChkBlk_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(12, 10);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(90, 36);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save Sheet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnChkNames
            // 
            this.btnChkNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChkNames.Location = new System.Drawing.Point(1501, 10);
            this.btnChkNames.Name = "btnChkNames";
            this.btnChkNames.Size = new System.Drawing.Size(75, 36);
            this.btnChkNames.TabIndex = 5;
            this.btnChkNames.Text = "Toggle Checking";
            this.btnChkNames.UseVisualStyleBackColor = true;
            this.btnChkNames.Click += new System.EventHandler(this.btnChkNames_Click);
            // 
            // lblChkNames
            // 
            this.lblChkNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChkNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChkNames.ForeColor = System.Drawing.Color.Red;
            this.lblChkNames.Location = new System.Drawing.Point(1256, 13);
            this.lblChkNames.Name = "lblChkNames";
            this.lblChkNames.Size = new System.Drawing.Size(239, 36);
            this.lblChkNames.TabIndex = 6;
            this.lblChkNames.Text = "Not checking names";
            this.lblChkNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CastingSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1588, 58);
            this.Controls.Add(this.lblChkNames);
            this.Controls.Add(this.btnChkNames);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnChkBlk);
            this.Name = "CastingSheet";
            this.Text = "Casting Sheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CastingSheet_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChkBlk;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnChkNames;
        private System.Windows.Forms.Label lblChkNames;
    }
}

