namespace App_Dự_Báo_Thời_Tiết
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbCity = new System.Windows.Forms.Label();
            this.lbMaxtemp = new System.Windows.Forms.Label();
            this.lbMinTemp = new System.Windows.Forms.Label();
            this.lbWindspeedmph = new System.Windows.Forms.Label();
            this.lbWindSpeedkm = new System.Windows.Forms.Label();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.textMaxTemp = new System.Windows.Forms.TextBox();
            this.textHuminidity = new System.Windows.Forms.TextBox();
            this.textKm = new System.Windows.Forms.TextBox();
            this.txbmph = new System.Windows.Forms.TextBox();
            this.txbMinTemp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btShow = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txbCoutry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCity
            // 
            this.lbCity.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(38, 31);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(86, 21);
            this.lbCity.TabIndex = 1;
            this.lbCity.Text = "Thành Phố";
            // 
            // lbMaxtemp
            // 
            this.lbMaxtemp.AutoSize = true;
            this.lbMaxtemp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxtemp.Location = new System.Drawing.Point(12, 81);
            this.lbMaxtemp.Name = "lbMaxtemp";
            this.lbMaxtemp.Size = new System.Drawing.Size(146, 21);
            this.lbMaxtemp.TabIndex = 2;
            this.lbMaxtemp.Text = "Nhiệt Độ Cao Nhất";
            // 
            // lbMinTemp
            // 
            this.lbMinTemp.AutoSize = true;
            this.lbMinTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinTemp.Location = new System.Drawing.Point(12, 128);
            this.lbMinTemp.Name = "lbMinTemp";
            this.lbMinTemp.Size = new System.Drawing.Size(158, 21);
            this.lbMinTemp.TabIndex = 3;
            this.lbMinTemp.Text = "Nhiệt Độ Thấp Nhất ";
            // 
            // lbWindspeedmph
            // 
            this.lbWindspeedmph.AutoSize = true;
            this.lbWindspeedmph.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindspeedmph.Location = new System.Drawing.Point(12, 176);
            this.lbWindspeedmph.Name = "lbWindspeedmph";
            this.lbWindspeedmph.Size = new System.Drawing.Size(128, 21);
            this.lbWindspeedmph.TabIndex = 4;
            this.lbWindspeedmph.Text = "Tốc Độ Gió mph";
            // 
            // lbWindSpeedkm
            // 
            this.lbWindSpeedkm.AutoSize = true;
            this.lbWindSpeedkm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindSpeedkm.Location = new System.Drawing.Point(12, 233);
            this.lbWindSpeedkm.Name = "lbWindSpeedkm";
            this.lbWindSpeedkm.Size = new System.Drawing.Size(133, 21);
            this.lbWindSpeedkm.TabIndex = 5;
            this.lbWindSpeedkm.Text = "Tốc Độ Gió km/h";
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidity.Location = new System.Drawing.Point(38, 289);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(60, 21);
            this.lbHumidity.TabIndex = 6;
            this.lbHumidity.Text = "Độ Ẩm";
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(180, 31);
            this.txbCity.Multiline = true;
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(393, 21);
            this.txbCity.TabIndex = 7;
            // 
            // textMaxTemp
            // 
            this.textMaxTemp.Location = new System.Drawing.Point(180, 80);
            this.textMaxTemp.Multiline = true;
            this.textMaxTemp.Name = "textMaxTemp";
            this.textMaxTemp.ReadOnly = true;
            this.textMaxTemp.Size = new System.Drawing.Size(263, 22);
            this.textMaxTemp.TabIndex = 8;
            this.textMaxTemp.UseSystemPasswordChar = true;
            // 
            // textHuminidity
            // 
            this.textHuminidity.Location = new System.Drawing.Point(180, 288);
            this.textHuminidity.Multiline = true;
            this.textHuminidity.Name = "textHuminidity";
            this.textHuminidity.ReadOnly = true;
            this.textHuminidity.Size = new System.Drawing.Size(263, 22);
            this.textHuminidity.TabIndex = 9;
            this.textHuminidity.UseSystemPasswordChar = true;
            // 
            // textKm
            // 
            this.textKm.Location = new System.Drawing.Point(180, 232);
            this.textKm.Multiline = true;
            this.textKm.Name = "textKm";
            this.textKm.ReadOnly = true;
            this.textKm.Size = new System.Drawing.Size(263, 22);
            this.textKm.TabIndex = 10;
            this.textKm.UseSystemPasswordChar = true;
            // 
            // txbmph
            // 
            this.txbmph.Location = new System.Drawing.Point(180, 179);
            this.txbmph.Multiline = true;
            this.txbmph.Name = "txbmph";
            this.txbmph.ReadOnly = true;
            this.txbmph.Size = new System.Drawing.Size(263, 22);
            this.txbmph.TabIndex = 11;
            this.txbmph.UseSystemPasswordChar = true;
            // 
            // txbMinTemp
            // 
            this.txbMinTemp.Location = new System.Drawing.Point(180, 131);
            this.txbMinTemp.Multiline = true;
            this.txbMinTemp.Name = "txbMinTemp";
            this.txbMinTemp.ReadOnly = true;
            this.txbMinTemp.Size = new System.Drawing.Size(263, 22);
            this.txbMinTemp.TabIndex = 12;
            this.txbMinTemp.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 650);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(486, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 145);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btShow
            // 
            this.btShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.Location = new System.Drawing.Point(686, 254);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(124, 36);
            this.btShow.TabIndex = 14;
            this.btShow.Text = "Dự Báo";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(14, 326);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(834, 272);
            this.dtgv.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(686, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Dự Báo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbCoutry
            // 
            this.txbCoutry.Location = new System.Drawing.Point(686, 31);
            this.txbCoutry.Multiline = true;
            this.txbCoutry.Name = "txbCoutry";
            this.txbCoutry.Size = new System.Drawing.Size(138, 21);
            this.txbCoutry.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCoutry);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txbMinTemp);
            this.Controls.Add(this.txbmph);
            this.Controls.Add(this.textKm);
            this.Controls.Add(this.textHuminidity);
            this.Controls.Add(this.textMaxTemp);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.lbHumidity);
            this.Controls.Add(this.lbWindSpeedkm);
            this.Controls.Add(this.lbWindspeedmph);
            this.Controls.Add(this.lbMinTemp);
            this.Controls.Add(this.lbMaxtemp);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "DỰ BÁO THỜI TIẾT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbMaxtemp;
        private System.Windows.Forms.Label lbMinTemp;
        private System.Windows.Forms.Label lbWindspeedmph;
        private System.Windows.Forms.Label lbWindSpeedkm;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.TextBox textMaxTemp;
        private System.Windows.Forms.TextBox textHuminidity;
        private System.Windows.Forms.TextBox textKm;
        private System.Windows.Forms.TextBox txbmph;
        private System.Windows.Forms.TextBox txbMinTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbCoutry;
        private System.Windows.Forms.Label label1;
    }
}

