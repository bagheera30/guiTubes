namespace gui_warung_kos
{
    partial class daftarMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(daftarMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tersedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.akun = new System.Windows.Forms.PictureBox();
            this.keranjang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "tambah barang";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(65, 22);
            this.textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 22);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 22);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Stok barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Deskripsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Harga barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "nama barang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.nama,
            this.harga,
            this.deskripsi,
            this.tersedia,
            this.ADD});
            this.dataGridView1.Location = new System.Drawing.Point(38, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // no
            // 
            this.no.HeaderText = "no";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.Width = 50;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.Width = 125;
            // 
            // harga
            // 
            this.harga.HeaderText = "harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 125;
            // 
            // deskripsi
            // 
            this.deskripsi.HeaderText = "descripsi";
            this.deskripsi.MinimumWidth = 6;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Width = 125;
            // 
            // tersedia
            // 
            this.tersedia.HeaderText = "tersedia";
            this.tersedia.MinimumWidth = 6;
            this.tersedia.Name = "tersedia";
            this.tersedia.Width = 125;
            // 
            // ADD
            // 
            this.ADD.HeaderText = "ADD";
            this.ADD.MinimumWidth = 6;
            this.ADD.Name = "ADD";
            this.ADD.Text = "add";
            this.ADD.Width = 125;
            // 
            // akun
            // 
            this.akun.Image = ((System.Drawing.Image)(resources.GetObject("akun.Image")));
            this.akun.Location = new System.Drawing.Point(748, 3);
            this.akun.Name = "akun";
            this.akun.Size = new System.Drawing.Size(40, 37);
            this.akun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.akun.TabIndex = 25;
            this.akun.TabStop = false;
            // 
            // keranjang
            // 
            this.keranjang.Image = ((System.Drawing.Image)(resources.GetObject("keranjang.Image")));
            this.keranjang.Location = new System.Drawing.Point(685, 13);
            this.keranjang.Name = "keranjang";
            this.keranjang.Size = new System.Drawing.Size(35, 27);
            this.keranjang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.keranjang.TabIndex = 24;
            this.keranjang.TabStop = false;
            // 
            // daftarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.akun);
            this.Controls.Add(this.keranjang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "daftarMenu";
            this.Text = "daftarMenu";
            this.Load += new System.EventHandler(this.daftarMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tersedia;
        private System.Windows.Forms.DataGridViewButtonColumn ADD;
        private System.Windows.Forms.PictureBox akun;
        private System.Windows.Forms.PictureBox keranjang;
    }
}