namespace Sınav_Akıllı_Saat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtadımuzulugu = new TextBox();
            btnadınuzunlugukaydedildi = new Button();
            label2 = new Label();
            txtadımsayısı = new TextBox();
            btnAdımSayısı = new Button();
            label3 = new Label();
            cmbSaat = new ComboBox();
            label4 = new Label();
            cmbDakika = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            btnHesapla = new Button();
            btnDakikadaKatedilenMesafe = new Button();
            txtToplamMesafe = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 158);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 0;
            label1.Text = "Adım Uzunluğunu Giriniz";
            // 
            // txtadımuzulugu
            // 
            txtadımuzulugu.Location = new Point(316, 155);
            txtadımuzulugu.Name = "txtadımuzulugu";
            txtadımuzulugu.Size = new Size(150, 31);
            txtadımuzulugu.TabIndex = 1;
            txtadımuzulugu.TextChanged += txtadımuzulugu_TextChanged;
            // 
            // btnadınuzunlugukaydedildi
            // 
            btnadınuzunlugukaydedildi.Location = new Point(503, 149);
            btnadınuzunlugukaydedildi.Name = "btnadınuzunlugukaydedildi";
            btnadınuzunlugukaydedildi.Size = new Size(112, 34);
            btnadınuzunlugukaydedildi.TabIndex = 2;
            btnadınuzunlugukaydedildi.Text = "Kaydet";
            btnadınuzunlugukaydedildi.UseVisualStyleBackColor = true;
            btnadınuzunlugukaydedildi.Click += btnadınuzunlugukaydedildi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(287, 25);
            label2.TabIndex = 3;
            label2.Text = "Bir Dakikadaki Adım Sayınızı Giriniz";
            // 
            // txtadımsayısı
            // 
            txtadımsayısı.Location = new Point(316, 85);
            txtadımsayısı.Name = "txtadımsayısı";
            txtadımsayısı.Size = new Size(150, 31);
            txtadımsayısı.TabIndex = 4;
            // 
            // btnAdımSayısı
            // 
            btnAdımSayısı.Location = new Point(500, 90);
            btnAdımSayısı.Name = "btnAdımSayısı";
            btnAdımSayısı.Size = new Size(112, 34);
            btnAdımSayısı.TabIndex = 5;
            btnAdımSayısı.Text = "Kaydet";
            btnAdımSayısı.UseVisualStyleBackColor = true;
            btnAdımSayısı.Click += btnAdımSayısı_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 264);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 6;
            label3.Text = "Koşu Süresi";
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbSaat.Location = new Point(12, 438);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(270, 33);
            cmbSaat.TabIndex = 7;
            cmbSaat.SelectedIndexChanged += cmbSaat_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 386);
            label4.Name = "label4";
            label4.Size = new Size(235, 25);
            label4.TabIndex = 8;
            label4.Text = "Günlük Koşu Sattinizi Seçiniz";
            // 
            // cmbDakika
            // 
            cmbDakika.FormattingEnabled = true;
            cmbDakika.Location = new Point(512, 438);
            cmbDakika.Name = "cmbDakika";
            cmbDakika.Size = new Size(227, 33);
            cmbDakika.TabIndex = 9;
            cmbDakika.SelectedIndexChanged += cmbDakika_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(528, 386);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 10;
            label5.Text = "Dakika Sayınızı Giriniz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 306);
            label6.Name = "label6";
            label6.Size = new Size(189, 25);
            label6.TabIndex = 11;
            label6.Text = "Koşulan Mesafe Giriniz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 334);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(441, 31);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(203, 513);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(391, 34);
            btnHesapla.TabIndex = 13;
            btnHesapla.Text = "Günlük Katedilen  Mesafeyi Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnDakikadaKatedilenMesafe
            // 
            btnDakikadaKatedilenMesafe.Location = new Point(377, 217);
            btnDakikadaKatedilenMesafe.Name = "btnDakikadaKatedilenMesafe";
            btnDakikadaKatedilenMesafe.Size = new Size(297, 34);
            btnDakikadaKatedilenMesafe.TabIndex = 14;
            btnDakikadaKatedilenMesafe.Text = "Hesapla";
            btnDakikadaKatedilenMesafe.UseVisualStyleBackColor = true;
            btnDakikadaKatedilenMesafe.Click += btnDakikadaKatedilenMesafe_Click;
            // 
            // txtToplamMesafe
            // 
            txtToplamMesafe.Location = new Point(68, 217);
            txtToplamMesafe.Name = "txtToplamMesafe";
            txtToplamMesafe.Size = new Size(255, 31);
            txtToplamMesafe.TabIndex = 15;
            txtToplamMesafe.Text = "Dakikada Katedilen Mesafe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 622);
            Controls.Add(txtToplamMesafe);
            Controls.Add(btnDakikadaKatedilenMesafe);
            Controls.Add(btnHesapla);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbDakika);
            Controls.Add(label4);
            Controls.Add(cmbSaat);
            Controls.Add(label3);
            Controls.Add(btnAdımSayısı);
            Controls.Add(txtadımsayısı);
            Controls.Add(label2);
            Controls.Add(btnadınuzunlugukaydedildi);
            Controls.Add(txtadımuzulugu);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtadımuzulugu;
        private Button btnadınuzunlugukaydedildi;
        private Label label2;
        private TextBox txtadımsayısı;
        private Button btnAdımSayısı;
        private Label label3;
        private ComboBox cmbSaat;
        private Label label4;
        private ComboBox cmbDakika;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Button btnHesapla;
        private Button btnDakikadaKatedilenMesafe;
        private TextBox txtToplamMesafe;
    }
}
