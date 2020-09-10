﻿namespace LUTGCaster
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
            this.lblLock = new System.Windows.Forms.Label();
            this.btnZoomUp = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.panAll = new System.Windows.Forms.Panel();
            this.lLblAbout = new System.Windows.Forms.LinkLabel();
            this.txtNextLock = new System.Windows.Forms.TextBox();
            this.lblLockName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(907, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(50, 50);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save Sheet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnChkNames
            // 
            this.btnChkNames.Location = new System.Drawing.Point(639, 3);
            this.btnChkNames.Name = "btnChkNames";
            this.btnChkNames.Size = new System.Drawing.Size(114, 27);
            this.btnChkNames.TabIndex = 5;
            this.btnChkNames.Text = "Toggle Checking";
            this.btnChkNames.UseVisualStyleBackColor = true;
            this.btnChkNames.Click += new System.EventHandler(this.btnChkNames_Click);
            // 
            // lblChkNames
            // 
            this.lblChkNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChkNames.ForeColor = System.Drawing.Color.Red;
            this.lblChkNames.Location = new System.Drawing.Point(436, -5);
            this.lblChkNames.Name = "lblChkNames";
            this.lblChkNames.Size = new System.Drawing.Size(197, 36);
            this.lblChkNames.TabIndex = 6;
            this.lblChkNames.Text = "Not checking names";
            this.lblChkNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(679, 44);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(34, 13);
            this.lblZoom.TabIndex = 8;
            this.lblZoom.Text = "Zoom";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lLblAbout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLockName);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.txtNextLock);
            this.panel1.Controls.Add(this.lblLock);
            this.panel1.Controls.Add(this.btnZoomUp);
            this.panel1.Controls.Add(this.btnZoomOut);
            this.panel1.Controls.Add(this.lblZoom);
            this.panel1.Controls.Add(this.btnChkNames);
            this.panel1.Controls.Add(this.lblChkNames);
            this.panel1.Location = new System.Drawing.Point(12, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 79);
            this.panel1.TabIndex = 1;
            // 
            // lblLock
            // 
            this.lblLock.AutoSize = true;
            this.lblLock.Location = new System.Drawing.Point(3, 3);
            this.lblLock.Margin = new System.Windows.Forms.Padding(3);
            this.lblLock.Name = "lblLock";
            this.lblLock.Size = new System.Drawing.Size(55, 13);
            this.lblLock.TabIndex = 11;
            this.lblLock.Text = "Next lock:";
            // 
            // btnZoomUp
            // 
            this.btnZoomUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomUp.Location = new System.Drawing.Point(716, 33);
            this.btnZoomUp.Name = "btnZoomUp";
            this.btnZoomUp.Size = new System.Drawing.Size(36, 33);
            this.btnZoomUp.TabIndex = 10;
            this.btnZoomUp.Text = "+";
            this.btnZoomUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZoomUp.UseVisualStyleBackColor = true;
            this.btnZoomUp.Click += new System.EventHandler(this.BtnZoomUp_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(639, 34);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(36, 32);
            this.btnZoomOut.TabIndex = 9;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.panAll.Size = new System.Drawing.Size(984, 356);
            this.panAll.TabIndex = 0;
            // 
            // lLblAbout
            // 
            this.lLblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lLblAbout.AutoSize = true;
            this.lLblAbout.Location = new System.Drawing.Point(913, 59);
            this.lLblAbout.Margin = new System.Windows.Forms.Padding(3);
            this.lLblAbout.Name = "lLblAbout";
            this.lLblAbout.Size = new System.Drawing.Size(44, 13);
            this.lLblAbout.TabIndex = 2;
            this.lLblAbout.TabStop = true;
            this.lLblAbout.Text = "About...";
            this.lLblAbout.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lLblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblAbout_LinkClicked);
            // 
            // txtNextLock
            // 
            this.txtNextLock.BackColor = System.Drawing.SystemColors.Control;
            this.txtNextLock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNextLock.Location = new System.Drawing.Point(192, 3);
            this.txtNextLock.Multiline = true;
            this.txtNextLock.Name = "txtNextLock";
            this.txtNextLock.ReadOnly = true;
            this.txtNextLock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNextLock.Size = new System.Drawing.Size(238, 66);
            this.txtNextLock.TabIndex = 13;
            this.txtNextLock.Text = "None";
            // 
            // lblLockName
            // 
            this.lblLockName.Location = new System.Drawing.Point(64, 3);
            this.lblLockName.Name = "lblLockName";
            this.lblLockName.Size = new System.Drawing.Size(122, 13);
            this.lblLockName.TabIndex = 14;
            this.lblLockName.Text = "None";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(441, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 73);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(899, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 73);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(960, 2);
            this.label3.TabIndex = 15;
            // 
            // CastingSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "CastingSheet";
            this.Text = "Casting Sheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CastingSheet_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblLock;
        private System.Windows.Forms.TextBox txtNextLock;
        private System.Windows.Forms.Label lblLockName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

