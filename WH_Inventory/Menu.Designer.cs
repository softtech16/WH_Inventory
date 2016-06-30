namespace WH_Inventory
{
    partial class Menu
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
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnstockin = new System.Windows.Forms.Button();
            this.btnstockout = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.lblwid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnproduct
            // 
            this.btnproduct.Location = new System.Drawing.Point(13, 33);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(75, 23);
            this.btnproduct.TabIndex = 0;
            this.btnproduct.Text = "Product";
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnstockin
            // 
            this.btnstockin.Location = new System.Drawing.Point(13, 83);
            this.btnstockin.Name = "btnstockin";
            this.btnstockin.Size = new System.Drawing.Size(75, 23);
            this.btnstockin.TabIndex = 1;
            this.btnstockin.Text = "Stock IN";
            this.btnstockin.UseVisualStyleBackColor = true;
            this.btnstockin.Click += new System.EventHandler(this.btnstockin_Click);
            // 
            // btnstockout
            // 
            this.btnstockout.Location = new System.Drawing.Point(150, 83);
            this.btnstockout.Name = "btnstockout";
            this.btnstockout.Size = new System.Drawing.Size(75, 23);
            this.btnstockout.TabIndex = 2;
            this.btnstockout.Text = "Stock OUT";
            this.btnstockout.UseVisualStyleBackColor = true;
            this.btnstockout.Click += new System.EventHandler(this.btnstockout_Click);
            // 
            // btnreport
            // 
            this.btnreport.Location = new System.Drawing.Point(150, 33);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(75, 23);
            this.btnreport.TabIndex = 3;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnuser
            // 
            this.btnuser.Location = new System.Drawing.Point(89, 127);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(75, 23);
            this.btnuser.TabIndex = 4;
            this.btnuser.Text = "User";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // lblwid
            // 
            this.lblwid.AutoSize = true;
            this.lblwid.Location = new System.Drawing.Point(13, 14);
            this.lblwid.Name = "lblwid";
            this.lblwid.Size = new System.Drawing.Size(23, 13);
            this.lblwid.TabIndex = 5;
            this.lblwid.Text = "wid";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 162);
            this.Controls.Add(this.lblwid);
            this.Controls.Add(this.btnuser);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnstockout);
            this.Controls.Add(this.btnstockin);
            this.Controls.Add(this.btnproduct);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btnstockin;
        private System.Windows.Forms.Button btnstockout;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Label lblwid;
    }
}