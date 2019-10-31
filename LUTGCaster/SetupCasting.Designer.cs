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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.btnAddShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(1407, 408);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(153, 41);
            this.BtnGenerate.TabIndex = 11;
            this.BtnGenerate.Text = "Generate Casting Sheet";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnAddShow
            // 
            this.btnAddShow.Location = new System.Drawing.Point(12, 426);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(75, 23);
            this.btnAddShow.TabIndex = 31;
            this.btnAddShow.Text = "Add Show";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Click += new System.EventHandler(this.btnAddShow_Click);
            // 
            // SetupCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 461);
            this.Controls.Add(this.btnAddShow);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "SetupCasting";
            this.Text = "SetupCasting";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button btnAddShow;
    }
}