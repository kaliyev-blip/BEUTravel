namespace bilet_satis_kenan_aliyev_5094a1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxYer = new TextBox();
            maskedTextBoxTarix = new MaskedTextBox();
            comboBoxHaraya = new ComboBox();
            comboBoxHaradan = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            textBox4 = new TextBox();
            textBoxFIN = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            listBoxBiletler = new ListBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(654, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(348, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 24);
            label1.Name = "label1";
            label1.Size = new Size(254, 50);
            label1.TabIndex = 3;
            label1.Text = "beu travel";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(textBoxYer);
            groupBox1.Controls.Add(maskedTextBoxTarix);
            groupBox1.Controls.Add(comboBoxHaraya);
            groupBox1.Controls.Add(comboBoxHaradan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 261);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Səyahət İnformasiyası";
            // 
            // textBoxYer
            // 
            textBoxYer.Location = new Point(100, 222);
            textBoxYer.Name = "textBoxYer";
            textBoxYer.Size = new Size(196, 27);
            textBoxYer.TabIndex = 7;
            // 
            // maskedTextBoxTarix
            // 
            maskedTextBoxTarix.Location = new Point(100, 157);
            maskedTextBoxTarix.Mask = "00/00/0000 90:00";
            maskedTextBoxTarix.Name = "maskedTextBoxTarix";
            maskedTextBoxTarix.Size = new Size(196, 27);
            maskedTextBoxTarix.TabIndex = 6;
            maskedTextBoxTarix.ValidatingType = typeof(DateTime);
            // 
            // comboBoxHaraya
            // 
            comboBoxHaraya.FormattingEnabled = true;
            comboBoxHaraya.Items.AddRange(new object[] { "Gənclik", "20 yanvar", "Avtovağzal", "Bİləcəri", "Riyad ticarət mərkəzi", "Şuşa qalası" });
            comboBoxHaraya.Location = new Point(100, 100);
            comboBoxHaraya.Name = "comboBoxHaraya";
            comboBoxHaraya.Size = new Size(196, 28);
            comboBoxHaraya.TabIndex = 5;
            // 
            // comboBoxHaradan
            // 
            comboBoxHaradan.FormattingEnabled = true;
            comboBoxHaradan.Items.AddRange(new object[] { "BMU", "Şuşa qalası", "Rİyad Ticarət Mərkəzi", "Masazırın kruqu", "Xırdalanın kruqu", "Avtovağzal" });
            comboBoxHaradan.Location = new Point(100, 38);
            comboBoxHaradan.Name = "comboBoxHaradan";
            comboBoxHaradan.Size = new Size(196, 28);
            comboBoxHaradan.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 215);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 3;
            label5.Text = "Yer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 157);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 2;
            label4.Text = "Tarix:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 100);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 1;
            label3.Text = "Haraya:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Haradan:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBoxFIN);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(654, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 261);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sərnişin İnformasiyası";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 226);
            button1.Name = "button1";
            button1.Size = new Size(264, 29);
            button1.TabIndex = 8;
            button1.Text = "Səyahət planla";
            button1.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(139, 122);
            maskedTextBox2.Mask = "(+994) 00-000-00-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(165, 27);
            maskedTextBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(139, 170);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 27);
            textBox4.TabIndex = 6;
            // 
            // textBoxFIN
            // 
            textBoxFIN.Location = new Point(139, 73);
            textBoxFIN.Name = "textBoxFIN";
            textBoxFIN.Size = new Size(165, 27);
            textBoxFIN.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 27);
            textBox2.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 177);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 3;
            label9.Text = "E-Mail:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 122);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 2;
            label8.Text = "Telefon:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 73);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 1;
            label7.Text = "FİN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 26);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 0;
            label6.Text = "Ad və Soyad:";
            // 
            // listBoxBiletler
            // 
            listBoxBiletler.FormattingEnabled = true;
            listBoxBiletler.Location = new Point(18, 411);
            listBoxBiletler.Name = "listBoxBiletler";
            listBoxBiletler.Size = new Size(984, 84);
            listBoxBiletler.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(18, 517);
            button2.Name = "button2";
            button2.Size = new Size(342, 29);
            button2.TabIndex = 7;
            button2.Text = "SIyahıdan sil";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Location = new Point(654, 512);
            button3.Name = "button3";
            button3.Size = new Size(348, 29);
            button3.TabIndex = 8;
            button3.Text = "Proqramnan çıx";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 558);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBoxBiletler);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBoxYer;
        private MaskedTextBox maskedTextBoxTarix;
        private ComboBox comboBox2Haraya;
        private ComboBox comboBoxHaradan;
        private TextBox textBoxFIN;
        private ListBox listBoxBiletler;
        private ComboBox comboBoxHaraya;
        private Button button2;
        private Button button3;
    }
}
