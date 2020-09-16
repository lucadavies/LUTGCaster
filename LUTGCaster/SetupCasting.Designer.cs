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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupCasting));
            this.btnAddShow = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panShows = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numUDChoices = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemShow = new System.Windows.Forms.Button();
            this.panShows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddShow
            // 
            this.btnAddShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddShow.Location = new System.Drawing.Point(12, 409);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(85, 40);
            this.btnAddShow.TabIndex = 31;
            this.btnAddShow.Text = "Add Show";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Click += new System.EventHandler(this.BtnAddShow_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(496, 409);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 40);
            this.btnLoad.TabIndex = 32;
            this.btnLoad.Text = "Load Sheet";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // panShows
            // 
            this.panShows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panShows.AutoScroll = true;
            this.panShows.Controls.Add(this.label2);
            this.panShows.Location = new System.Drawing.Point(0, 0);
            this.panShows.Name = "panShows";
            this.panShows.Size = new System.Drawing.Size(734, 403);
            this.panShows.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(734, 403);
            this.label2.TabIndex = 0;
            this.label2.Text = "Show Setup";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(592, 409);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 40);
            this.btnGenerate.TabIndex = 34;
            this.btnGenerate.Text = "Generate Casting Sheet";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // numUDChoices
            // 
            this.numUDChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDChoices.Location = new System.Drawing.Point(339, 421);
            this.numUDChoices.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numUDChoices.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUDChoices.Name = "numUDChoices";
            this.numUDChoices.Size = new System.Drawing.Size(120, 20);
            this.numUDChoices.TabIndex = 35;
            this.numUDChoices.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Number of Choices:";
            // 
            // btnRemShow
            // 
            this.btnRemShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemShow.Enabled = false;
            this.btnRemShow.Location = new System.Drawing.Point(103, 409);
            this.btnRemShow.Name = "btnRemShow";
            this.btnRemShow.Size = new System.Drawing.Size(85, 40);
            this.btnRemShow.TabIndex = 37;
            this.btnRemShow.Text = "Remove Show";
            this.btnRemShow.UseVisualStyleBackColor = true;
            this.btnRemShow.Click += new System.EventHandler(this.BtnRemShow_Click);
            // 
            // SetupCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnRemShow);
            this.Controls.Add(this.btnAddShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUDChoices);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panShows);
            this.Controls.Add(this.btnLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "SetupCasting";
            this.Text = "Setup Casting Sheet...";
            this.panShows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDChoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panShows;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numUDChoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemShow;
    }
}