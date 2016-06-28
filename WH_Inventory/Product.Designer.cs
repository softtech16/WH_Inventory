namespace WH_Inventory
{
    partial class Product
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
            this.lblprodname = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.tbxprodname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnaddandsave = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprodname
            // 
            this.lblprodname.AutoSize = true;
            this.lblprodname.Location = new System.Drawing.Point(29, 26);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(75, 13);
            this.lblprodname.TabIndex = 0;
            this.lblprodname.Text = "Product Name";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(32, 78);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(24, 13);
            this.lblmin.TabIndex = 1;
            this.lblmin.Text = "Min";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(82, 78);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(27, 13);
            this.lblmax.TabIndex = 2;
            this.lblmax.Text = "Max";
            // 
            // tbxprodname
            // 
            this.tbxprodname.Location = new System.Drawing.Point(32, 43);
            this.tbxprodname.Name = "tbxprodname";
            this.tbxprodname.Size = new System.Drawing.Size(217, 20);
            this.tbxprodname.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnaddandsave
            // 
            this.btnaddandsave.Location = new System.Drawing.Point(82, 121);
            this.btnaddandsave.Name = "btnaddandsave";
            this.btnaddandsave.Size = new System.Drawing.Size(86, 23);
            this.btnaddandsave.TabIndex = 6;
            this.btnaddandsave.Text = "Add and Save";
            this.btnaddandsave.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(174, 121);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 170);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnaddandsave);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbxprodname);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblprodname);
            this.Name = "Product";
            this.Text = "Product";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Product_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprodname;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.TextBox tbxprodname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnaddandsave;
        private System.Windows.Forms.Button btnsave;
    }
}