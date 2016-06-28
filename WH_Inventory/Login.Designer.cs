namespace WH_Inventory
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxuser = new System.Windows.Forms.TextBox();
            this.tbxpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // tbxuser
            // 
            this.tbxuser.Location = new System.Drawing.Point(101, 42);
            this.tbxuser.Name = "tbxuser";
            this.tbxuser.Size = new System.Drawing.Size(100, 20);
            this.tbxuser.TabIndex = 2;
            // 
            // tbxpass
            // 
            this.tbxpass.Location = new System.Drawing.Point(101, 74);
            this.tbxpass.Name = "tbxpass";
            this.tbxpass.Size = new System.Drawing.Size(100, 20);
            this.tbxpass.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(139, 113);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BY :  YU, JOHN KRYPTON C.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 175);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbxpass);
            this.Controls.Add(this.tbxuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxuser;
        private System.Windows.Forms.TextBox tbxpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label3;
    }
}

