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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CastingSheet));
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnChkNames = new System.Windows.Forms.Button();
            this.lblChkNames = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZoomUp = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.panAll = new System.Windows.Forms.Panel();
            this.lLblAbout = new System.Windows.Forms.LinkLabel();
            this.lblLock = new System.Windows.Forms.Label();
            this.lblNextLock = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 3);
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
            this.btnChkNames.Location = new System.Drawing.Point(697, 3);
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
            this.lblChkNames.Location = new System.Drawing.Point(452, 1);
            this.lblChkNames.Name = "lblChkNames";
            this.lblChkNames.Size = new System.Drawing.Size(239, 36);
            this.lblChkNames.TabIndex = 6;
            this.lblChkNames.Text = "Not checking names";
            this.lblChkNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(318, 15);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(34, 13);
            this.lblZoom.TabIndex = 8;
            this.lblZoom.Text = "Zoom";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblNextLock);
            this.panel1.Controls.Add(this.lblLock);
            this.panel1.Controls.Add(this.btnZoomUp);
            this.panel1.Controls.Add(this.btnZoomOut);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.lblZoom);
            this.panel1.Controls.Add(this.btnChkNames);
            this.panel1.Controls.Add(this.lblChkNames);
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnZoomUp
            // 
            this.btnZoomUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomUp.Location = new System.Drawing.Point(400, 3);
            this.btnZoomUp.Name = "btnZoomUp";
            this.btnZoomUp.Size = new System.Drawing.Size(36, 36);
            this.btnZoomUp.TabIndex = 10;
            this.btnZoomUp.Text = "+";
            this.btnZoomUp.UseVisualStyleBackColor = true;
            this.btnZoomUp.Click += new System.EventHandler(this.BtnZoomUp_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(358, 3);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(36, 36);
            this.btnZoomOut.TabIndex = 9;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.BtnZoomOut_Click);
            // 
            // panAll
            // 
            this.panAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAll.AutoScroll = true;
            this.panAll.Location = new System.Drawing.Point(0, 8);
            this.panAll.Name = "panAll";
            this.panAll.Size = new System.Drawing.Size(786, 167);
            this.panAll.TabIndex = 0;
            // 
            // lLblAbout
            // 
            this.lLblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lLblAbout.AutoSize = true;
            this.lLblAbout.Location = new System.Drawing.Point(728, 234);
            this.lLblAbout.Name = "lLblAbout";
            this.lLblAbout.Size = new System.Drawing.Size(44, 13);
            this.lLblAbout.TabIndex = 2;
            this.lLblAbout.TabStop = true;
            this.lLblAbout.Text = "About...";
            this.lLblAbout.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lLblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblAbout_LinkClicked);
            // 
            // lblLock
            // 
            this.lblLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLock.AutoSize = true;
            this.lblLock.Location = new System.Drawing.Point(108, 3);
            this.lblLock.Name = "lblLock";
            this.lblLock.Size = new System.Drawing.Size(55, 13);
            this.lblLock.TabIndex = 11;
            this.lblLock.Text = "Next lock:";
            // 
            // lblNextLock
            // 
            this.lblNextLock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextLock.Location = new System.Drawing.Point(169, 3);
            this.lblNextLock.Name = "lblNextLock";
            this.lblNextLock.Size = new System.Drawing.Size(133, 36);
            this.lblNextLock.TabIndex = 12;
            this.lblNextLock.Text = "None";
            // 
            // CastingSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 256);
            this.Controls.Add(this.lLblAbout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 250);
            this.Name = "CastingSheet";
            this.Text = "Casting Sheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CastingSheet_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnChkNames;
        private System.Windows.Forms.Label lblChkNames;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panAll;
        private System.Windows.Forms.Button btnZoomUp;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.LinkLabel lLblAbout;
        private System.Windows.Forms.Label lblNextLock;
        private System.Windows.Forms.Label lblLock;
    }
}

