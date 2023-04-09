namespace proiect_securitate
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
            this.text_to_encrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_box_cipher_chosen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCriptat = new System.Windows.Forms.Label();
            this.textDecryptat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Text_cheie = new System.Windows.Forms.Label();
            this.text_box_key = new System.Windows.Forms.TextBox();
            this.button_cipher = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_to_encrypt
            // 
            this.text_to_encrypt.Location = new System.Drawing.Point(339, 7);
            this.text_to_encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_to_encrypt.Name = "text_to_encrypt";
            this.text_to_encrypt.Size = new System.Drawing.Size(359, 22);
            this.text_to_encrypt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introdu textul care doresti sa decriptezi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alege un cipher pentru criptare si decriptare";
            // 
            // combo_box_cipher_chosen
            // 
            this.combo_box_cipher_chosen.FormattingEnabled = true;
            this.combo_box_cipher_chosen.Items.AddRange(new object[] {
            "Cezar",
            "Vigenere"});
            this.combo_box_cipher_chosen.Location = new System.Drawing.Point(339, 47);
            this.combo_box_cipher_chosen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_box_cipher_chosen.Name = "combo_box_cipher_chosen";
            this.combo_box_cipher_chosen.Size = new System.Drawing.Size(160, 24);
            this.combo_box_cipher_chosen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text criptat";
            // 
            // textCriptat
            // 
            this.textCriptat.AutoSize = true;
            this.textCriptat.Location = new System.Drawing.Point(117, 214);
            this.textCriptat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textCriptat.Name = "textCriptat";
            this.textCriptat.Size = new System.Drawing.Size(13, 17);
            this.textCriptat.TabIndex = 5;
            this.textCriptat.Text = "-";
            // 
            // textDecryptat
            // 
            this.textDecryptat.AutoSize = true;
            this.textDecryptat.Location = new System.Drawing.Point(117, 245);
            this.textDecryptat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textDecryptat.Name = "textDecryptat";
            this.textDecryptat.Size = new System.Drawing.Size(13, 17);
            this.textDecryptat.TabIndex = 7;
            this.textDecryptat.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Text decryptat";
            // 
            // Text_cheie
            // 
            this.Text_cheie.AutoSize = true;
            this.Text_cheie.Location = new System.Drawing.Point(16, 85);
            this.Text_cheie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text_cheie.Name = "Text_cheie";
            this.Text_cheie.Size = new System.Drawing.Size(166, 17);
            this.Text_cheie.TabIndex = 8;
            this.Text_cheie.Text = "Introdu cheia de criptare:";
            // 
            // text_box_key
            // 
            this.text_box_key.Location = new System.Drawing.Point(196, 85);
            this.text_box_key.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_box_key.Name = "text_box_key";
            this.text_box_key.Size = new System.Drawing.Size(132, 22);
            this.text_box_key.TabIndex = 9;
            // 
            // button_cipher
            // 
            this.button_cipher.Location = new System.Drawing.Point(20, 128);
            this.button_cipher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cipher.Name = "button_cipher";
            this.button_cipher.Size = new System.Drawing.Size(100, 58);
            this.button_cipher.TabIndex = 10;
            this.button_cipher.Text = "Foloseste cipher";
            this.button_cipher.UseVisualStyleBackColor = true;
            this.button_cipher.Click += new System.EventHandler(this.button_cipher_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "test iron";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cipher);
            this.Controls.Add(this.text_box_key);
            this.Controls.Add(this.Text_cheie);
            this.Controls.Add(this.textDecryptat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCriptat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_box_cipher_chosen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_to_encrypt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_to_encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_box_cipher_chosen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textCriptat;
        private System.Windows.Forms.Label textDecryptat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Text_cheie;
        private System.Windows.Forms.TextBox text_box_key;
        private System.Windows.Forms.Button button_cipher;
        private System.Windows.Forms.Button button1;
    }
}

