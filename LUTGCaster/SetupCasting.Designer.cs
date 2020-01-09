namespace LUTGCaster
{
    partial class SetupCasting
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
            this.btnAddShow = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panShows = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddShow
            // 
            this.btnAddShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddShow.Location = new System.Drawing.Point(12, 409);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(75, 40);
            this.btnAddShow.TabIndex = 31;
            this.btnAddShow.Text = "Add Show";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Click += new System.EventHandler(this.BtnAddShow_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(746, 409);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 40);
            this.btnLoad.TabIndex = 32;
            this.btnLoad.Text = "Load Sheet";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panShows
            // 
            this.panShows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panShows.AutoScroll = true;
            this.panShows.Location = new System.Drawing.Point(0, 0);
            this.panShows.Name = "panShows";
            this.panShows.Size = new System.Drawing.Size(984, 318);
            this.panShows.TabIndex = 33;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(842, 409);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 40);
            this.btnGenerate.TabIndex = 34;
            this.btnGenerate.Text = "Generate Casting Sheet";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // SetupCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panShows);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAddShow);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "SetupCasting";
            this.Text = "Setup Casting Sheet...";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panShows;
        private System.Windows.Forms.Button btnGenerate;
    }
}