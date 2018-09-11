namespace sifnos1
{
    partial class LogInForm
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
            this.components = new System.ComponentModel.Container();
            this.guest = new System.Windows.Forms.Button();
            this.loggedin = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guest
            // 
            this.guest.BackColor = System.Drawing.SystemColors.Info;
            this.guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.guest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guest.Location = new System.Drawing.Point(74, 214);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(105, 43);
            this.guest.TabIndex = 0;
            this.guest.Text = "ΕΠΙΣΚΕΠΤΗΣ";
            this.guest.UseVisualStyleBackColor = false;
            this.guest.Click += new System.EventHandler(this.guest_Click);
            // 
            // loggedin
            // 
            this.loggedin.BackColor = System.Drawing.SystemColors.Info;
            this.loggedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loggedin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loggedin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loggedin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loggedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggedin.Location = new System.Drawing.Point(568, 225);
            this.loggedin.Name = "loggedin";
            this.loggedin.Size = new System.Drawing.Size(91, 40);
            this.loggedin.TabIndex = 1;
            this.loggedin.Text = "ΣΥΝΔΕΣΗ";
            this.loggedin.UseVisualStyleBackColor = false;
            this.loggedin.Click += new System.EventHandler(this.loggedin_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.Info;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Location = new System.Drawing.Point(567, 276);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(91, 43);
            this.register.TabIndex = 2;
            this.register.Text = "ΕΓΓΡΑΦΗ";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(559, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(260, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "ΚΑΛΩΣ ΗΡΘΑΤΕ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(49, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Συνεχίστε ως επισκέπτης";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(448, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Όνομα Χρήστη :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(439, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Κωδικός Χρήστη :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(466, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Αλλιώς κάντε ";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.loggedin);
            this.Controls.Add(this.guest);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.Controls.SetChildIndex(this.guest, 0);
            this.Controls.SetChildIndex(this.loggedin, 0);
            this.Controls.SetChildIndex(this.register, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guest;
        private System.Windows.Forms.Button loggedin;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

