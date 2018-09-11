namespace sifnos1
{
    partial class AboutUs
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
            this.label100 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.button155 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label100.Location = new System.Drawing.Point(88, 124);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(155, 18);
            this.label100.TabIndex = 6;
            this.label100.Text = "Ονόματα Δημιουργών ";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label111.Location = new System.Drawing.Point(88, 164);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(417, 16);
            this.label111.TabIndex = 7;
            this.label111.Text = "Την κατασκευή της συγκεγριμένης εφαρμογής επιμελήθηκε η ομάδα :";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label122.Location = new System.Drawing.Point(88, 205);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(250, 16);
            this.label122.TabIndex = 8;
            this.label122.Text = "Γεωργούλης Αριστοτέλης / ΜΠΠΛ15012";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label144.Location = new System.Drawing.Point(88, 244);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(199, 16);
            this.label144.TabIndex = 9;
            this.label144.Text = "Σανιδάς Γεώργιος / ΜΠΠΛ15062";
            // 
            // button155
            // 
            this.button155.Location = new System.Drawing.Point(91, 291);
            this.button155.Name = "button155";
            this.button155.Size = new System.Drawing.Size(117, 49);
            this.button155.TabIndex = 10;
            this.button155.Text = "OK";
            this.button155.UseVisualStyleBackColor = true;
            this.button155.Click += new System.EventHandler(this.button155_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sifnos1.Properties.Resources.mainMenuBg;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button155);
            this.Controls.Add(this.label144);
            this.Controls.Add(this.label122);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.label100);
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            this.Load += new System.EventHandler(this.AboutUs_Load);
            this.Controls.SetChildIndex(this.label100, 0);
            this.Controls.SetChildIndex(this.label111, 0);
            this.Controls.SetChildIndex(this.label122, 0);
            this.Controls.SetChildIndex(this.label144, 0);
            this.Controls.SetChildIndex(this.button155, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Button button155;
    }
}