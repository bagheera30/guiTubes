namespace gui
{
    partial class CartForm
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
<<<<<<< HEAD
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
=======
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(37, 172);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(74, 32);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "total";
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(36, 227);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckout.TabIndex = 4;
            this.buttonCheckout.Text = "checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            // 
>>>>>>> master
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
<<<<<<< HEAD
            this.listBox1.Location = new System.Drawing.Point(67, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 132);
            this.listBox1.TabIndex = 0;
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Name = "cart";
            this.Text = "cart";
            this.ResumeLayout(false);
=======
            this.listBox1.Location = new System.Drawing.Point(26, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 132);
            this.listBox1.TabIndex = 3;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.listBox1);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> master

        }

        #endregion

<<<<<<< HEAD
=======
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonCheckout;
>>>>>>> master
        private System.Windows.Forms.ListBox listBox1;
    }
}