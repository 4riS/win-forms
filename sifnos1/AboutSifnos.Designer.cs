namespace sifnos1
{
    partial class AboutSifnos
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label199 = new System.Windows.Forms.Label();
            this.label299 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(353, 94);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(286, 262);
            this.webBrowser1.TabIndex = 6;
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label199.Location = new System.Drawing.Point(54, 94);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(160, 17);
            this.label199.TabIndex = 7;
            this.label199.Text = "Σχετικά με την Σίφνο";
            // 
            // label299
            // 
            this.label299.AutoSize = true;
            this.label299.Location = new System.Drawing.Point(54, 134);
            this.label299.Name = "label299";
            this.label299.Size = new System.Drawing.Size(35, 13);
            this.label299.TabIndex = 8;
            this.label299.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AboutSifnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label299);
            this.Controls.Add(this.label199);
            this.Controls.Add(this.webBrowser1);
            this.Name = "AboutSifnos";
            this.Text = "AboutSifnos";
            this.Load += new System.EventHandler(this.AboutSifnos_Load);
            this.Controls.SetChildIndex(this.webBrowser1, 0);
            this.Controls.SetChildIndex(this.label199, 0);
            this.Controls.SetChildIndex(this.label299, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label299;
        private System.Windows.Forms.Button button1;
    }
}