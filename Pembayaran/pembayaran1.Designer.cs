namespace Pembayaran
{
    partial class pembayaran1
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
            this.infotagihan = new System.Windows.Forms.Label();
            this.tagihan = new System.Windows.Forms.TextBox();
            this.infopembayaran = new System.Windows.Forms.Label();
            this.pembayaran = new System.Windows.Forms.TextBox();
            this.infometodepembayaran = new System.Windows.Forms.Label();
            this.infometode = new System.Windows.Forms.TextBox();
            this.qrisRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.ewalletRadioButton = new System.Windows.Forms.RadioButton();
            this.bayar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infotagihan
            // 
            this.infotagihan.AutoSize = true;
            this.infotagihan.Location = new System.Drawing.Point(13, 13);
            this.infotagihan.Name = "infotagihan";
            this.infotagihan.Size = new System.Drawing.Size(57, 16);
            this.infotagihan.TabIndex = 0;
            this.infotagihan.Text = "Tagihan";
            this.infotagihan.Click += new System.EventHandler(this.infotagihan_Click);
            // 
            // tagihan
            // 
            this.tagihan.Location = new System.Drawing.Point(16, 33);
            this.tagihan.Name = "tagihan";
            this.tagihan.Size = new System.Drawing.Size(100, 22);
            this.tagihan.TabIndex = 1;
            this.tagihan.TextChanged += new System.EventHandler(this.tagihan_TextChanged);
            // 
            // infopembayaran
            // 
            this.infopembayaran.AutoSize = true;
            this.infopembayaran.Location = new System.Drawing.Point(16, 62);
            this.infopembayaran.Name = "infopembayaran";
            this.infopembayaran.Size = new System.Drawing.Size(85, 16);
            this.infopembayaran.TabIndex = 2;
            this.infopembayaran.Text = "Pembayaran";
            // 
            // pembayaran
            // 
            this.pembayaran.Location = new System.Drawing.Point(16, 82);
            this.pembayaran.Name = "pembayaran";
            this.pembayaran.Size = new System.Drawing.Size(100, 22);
            this.pembayaran.TabIndex = 3;
            // 
            // infometodepembayaran
            // 
            this.infometodepembayaran.AutoSize = true;
            this.infometodepembayaran.Location = new System.Drawing.Point(16, 111);
            this.infometodepembayaran.Name = "infometodepembayaran";
            this.infometodepembayaran.Size = new System.Drawing.Size(134, 16);
            this.infometodepembayaran.TabIndex = 4;
            this.infometodepembayaran.Text = "Metode Pembayaran";
            // 
            // infometode
            // 
            this.infometode.Location = new System.Drawing.Point(19, 131);
            this.infometode.Name = "infometode";
            this.infometode.Size = new System.Drawing.Size(100, 22);
            this.infometode.TabIndex = 5;
            this.infometode.TextChanged += new System.EventHandler(this.infometode_TextChanged);
            // 
            // qrisRadioButton
            // 
            this.qrisRadioButton.AutoSize = true;
            this.qrisRadioButton.Location = new System.Drawing.Point(19, 160);
            this.qrisRadioButton.Name = "qrisRadioButton";
            this.qrisRadioButton.Size = new System.Drawing.Size(52, 20);
            this.qrisRadioButton.TabIndex = 6;
            this.qrisRadioButton.TabStop = true;
            this.qrisRadioButton.Text = "Qris";
            this.qrisRadioButton.UseVisualStyleBackColor = true;
            this.qrisRadioButton.CheckedChanged += new System.EventHandler(this.qrisRadioButton_CheckedChanged);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(19, 187);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(59, 20);
            this.cashRadioButton.TabIndex = 7;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            this.cashRadioButton.CheckedChanged += new System.EventHandler(this.cashRadioButton_CheckedChanged);
            // 
            // ewalletRadioButton
            // 
            this.ewalletRadioButton.AutoSize = true;
            this.ewalletRadioButton.Location = new System.Drawing.Point(19, 214);
            this.ewalletRadioButton.Name = "ewalletRadioButton";
            this.ewalletRadioButton.Size = new System.Drawing.Size(75, 20);
            this.ewalletRadioButton.TabIndex = 8;
            this.ewalletRadioButton.TabStop = true;
            this.ewalletRadioButton.Text = "E-wallet";
            this.ewalletRadioButton.UseVisualStyleBackColor = true;
            this.ewalletRadioButton.CheckedChanged += new System.EventHandler(this.ewalletRadioButton_CheckedChanged);
            // 
            // bayar
            // 
            this.bayar.Location = new System.Drawing.Point(19, 241);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(75, 23);
            this.bayar.TabIndex = 9;
            this.bayar.Text = "BAYAR";
            this.bayar.UseVisualStyleBackColor = true;
            this.bayar.Click += new System.EventHandler(this.bayar_Click);
            // 
            // pembayaran1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 275);
            this.Controls.Add(this.bayar);
            this.Controls.Add(this.ewalletRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.qrisRadioButton);
            this.Controls.Add(this.infometode);
            this.Controls.Add(this.infometodepembayaran);
            this.Controls.Add(this.pembayaran);
            this.Controls.Add(this.infopembayaran);
            this.Controls.Add(this.tagihan);
            this.Controls.Add(this.infotagihan);
            this.Name = "pembayaran1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infotagihan;
        private System.Windows.Forms.TextBox tagihan;
        private System.Windows.Forms.Label infopembayaran;
        private System.Windows.Forms.TextBox pembayaran;
        private System.Windows.Forms.Label infometodepembayaran;
        private System.Windows.Forms.TextBox infometode;
        private System.Windows.Forms.RadioButton qrisRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton ewalletRadioButton;
        private System.Windows.Forms.Button bayar;
    }
}

