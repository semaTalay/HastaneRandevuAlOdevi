namespace HastaneRandevuAlOdevi
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dtpTarih = new DateTimePicker();
            cboxPoliklinik = new ComboBox();
            txtAdSoyad = new TextBox();
            mtxtTelefon = new MaskedTextBox();
            mtxtTc = new MaskedTextBox();
            btnRandevuOlustur = new Button();
            rdb15 = new RadioButton();
            rdb14 = new RadioButton();
            rdb13 = new RadioButton();
            rdb12 = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rdbErkek = new RadioButton();
            rdbKadin = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            lstKisiler = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(551, 501);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtpTarih);
            tabPage1.Controls.Add(cboxPoliklinik);
            tabPage1.Controls.Add(txtAdSoyad);
            tabPage1.Controls.Add(mtxtTelefon);
            tabPage1.Controls.Add(mtxtTc);
            tabPage1.Controls.Add(btnRandevuOlustur);
            tabPage1.Controls.Add(rdb15);
            tabPage1.Controls.Add(rdb14);
            tabPage1.Controls.Add(rdb13);
            tabPage1.Controls.Add(rdb12);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(543, 473);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Randevu Oluştur";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(127, 349);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(149, 23);
            dtpTarih.TabIndex = 12;
            // 
            // cboxPoliklinik
            // 
            cboxPoliklinik.FormattingEnabled = true;
            cboxPoliklinik.Items.AddRange(new object[] { "Göz", "Dahiliye", "KBB", "Çocuk Hastalıkları", "Kardiyoloji" });
            cboxPoliklinik.Location = new Point(127, 309);
            cboxPoliklinik.Name = "cboxPoliklinik";
            cboxPoliklinik.Size = new Size(149, 23);
            cboxPoliklinik.TabIndex = 11;
            cboxPoliklinik.Text = "Poliklinik Seçiniz";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(110, 88);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(166, 23);
            txtAdSoyad.TabIndex = 10;
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(110, 116);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(166, 23);
            mtxtTelefon.TabIndex = 9;
            // 
            // mtxtTc
            // 
            mtxtTc.Location = new Point(110, 48);
            mtxtTc.Mask = "00000000000";
            mtxtTc.Name = "mtxtTc";
            mtxtTc.Size = new Size(166, 23);
            mtxtTc.TabIndex = 8;
            mtxtTc.ValidatingType = typeof(int);
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(68, 446);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(169, 23);
            btnRandevuOlustur.TabIndex = 7;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // rdb15
            // 
            rdb15.AutoSize = true;
            rdb15.Location = new Point(144, 408);
            rdb15.Name = "rdb15";
            rdb15.Size = new Size(52, 19);
            rdb15.TabIndex = 6;
            rdb15.TabStop = true;
            rdb15.Text = "15.00";
            rdb15.UseVisualStyleBackColor = true;
            // 
            // rdb14
            // 
            rdb14.AutoSize = true;
            rdb14.Location = new Point(19, 408);
            rdb14.Name = "rdb14";
            rdb14.Size = new Size(52, 19);
            rdb14.TabIndex = 5;
            rdb14.TabStop = true;
            rdb14.Text = "14.00";
            rdb14.UseVisualStyleBackColor = true;
            // 
            // rdb13
            // 
            rdb13.AutoSize = true;
            rdb13.Location = new Point(144, 383);
            rdb13.Name = "rdb13";
            rdb13.Size = new Size(52, 19);
            rdb13.TabIndex = 4;
            rdb13.TabStop = true;
            rdb13.Text = "13.00";
            rdb13.UseVisualStyleBackColor = true;
            // 
            // rdb12
            // 
            rdb12.AutoSize = true;
            rdb12.Location = new Point(19, 383);
            rdb12.Name = "rdb12";
            rdb12.Size = new Size(52, 19);
            rdb12.TabIndex = 3;
            rdb12.TabStop = true;
            rdb12.Text = "12.00";
            rdb12.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 344);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 2;
            label7.Text = "Tarih";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 312);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 2;
            label6.Text = "Poliklinik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 272);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 2;
            label5.Text = "Randevu Bilgileri";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbErkek);
            groupBox1.Controls.Add(rdbKadin);
            groupBox1.Location = new Point(27, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(100, 49);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 0;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(6, 49);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(55, 19);
            rdbKadin.TabIndex = 0;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadın";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 119);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 0;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 88);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 0;
            label3.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 56);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 0;
            label2.Text = "TC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Hasta Bilgileri";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstKisiler);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(543, 473);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Randevular";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstKisiler
            // 
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 15;
            lstKisiler.Location = new Point(7, 50);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(536, 409);
            lstKisiler.TabIndex = 0;
            lstKisiler.SelectedIndexChanged += lstKisiler_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 504);
            Controls.Add(tabControl1);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rdbErkek;
        private RadioButton rdbKadin;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private DateTimePicker dtpTarih;
        private ComboBox cboxPoliklinik;
        private TextBox txtAdSoyad;
        private MaskedTextBox mtxtTelefon;
        private MaskedTextBox mtxtTc;
        private Button btnRandevuOlustur;
        private RadioButton rdb15;
        private RadioButton rdb14;
        private RadioButton rdb13;
        private RadioButton rdb12;
        private ListBox lstKisiler;
    }
}