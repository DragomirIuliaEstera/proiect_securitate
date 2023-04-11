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
            this.label6 = new System.Windows.Forms.Label();
            this.Text_cheie = new System.Windows.Forms.Label();
            this.text_box_key = new System.Windows.Forms.TextBox();
            this.button_cipher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_server = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.textCriptat = new System.Windows.Forms.TextBox();
            this.textDecriptat = new System.Windows.Forms.TextBox();
            this.label1b = new System.Windows.Forms.Label();
            this.label2b = new System.Windows.Forms.Label();
            this.text_cheie_decriptare = new System.Windows.Forms.Label();
            this.text_to_decrypt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_to_encrypt
            // 
            this.text_to_encrypt.Location = new System.Drawing.Point(339, 7);
            this.text_to_encrypt.Margin = new System.Windows.Forms.Padding(4);
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
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introdu textul pe care doresti sa-l criptezi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alege un cipher pentru criptare";
            // 
            // combo_box_cipher_chosen
            // 
            this.combo_box_cipher_chosen.FormattingEnabled = true;
            this.combo_box_cipher_chosen.Items.AddRange(new object[] {
            "Cezar",
            "Vigenere"});
            this.combo_box_cipher_chosen.Location = new System.Drawing.Point(339, 47);
            this.combo_box_cipher_chosen.Margin = new System.Windows.Forms.Padding(4);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Text decriptat";
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
            this.text_box_key.Location = new System.Drawing.Point(207, 85);
            this.text_box_key.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_key.Name = "text_box_key";
            this.text_box_key.Size = new System.Drawing.Size(132, 22);
            this.text_box_key.TabIndex = 9;
            // 
            // button_cipher
            // 
            this.button_cipher.Location = new System.Drawing.Point(20, 128);
            this.button_cipher.Margin = new System.Windows.Forms.Padding(4);
            this.button_cipher.Name = "button_cipher";
            this.button_cipher.Size = new System.Drawing.Size(100, 58);
            this.button_cipher.TabIndex = 10;
            this.button_cipher.Text = "Foloseste cipher";
            this.button_cipher.UseVisualStyleBackColor = true;
            this.button_cipher.Click += new System.EventHandler(this.button_cipher_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alege o optiune";
            // 
            // btn_server
            // 
            this.btn_server.Location = new System.Drawing.Point(228, 137);
            this.btn_server.Margin = new System.Windows.Forms.Padding(4);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(199, 58);
            this.btn_server.TabIndex = 12;
            this.btn_server.Text = "Server";
            this.btn_server.UseVisualStyleBackColor = true;
            this.btn_server.Click += new System.EventHandler(this.btn_server_Click);
            // 
            // btn_client
            // 
            this.btn_client.Location = new System.Drawing.Point(456, 137);
            this.btn_client.Margin = new System.Windows.Forms.Padding(4);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(199, 58);
            this.btn_client.TabIndex = 13;
            this.btn_client.Text = "Client";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(139, 128);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 58);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "Inapoi";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // textCriptat
            // 
            this.textCriptat.Location = new System.Drawing.Point(120, 211);
            this.textCriptat.Margin = new System.Windows.Forms.Padding(4);
            this.textCriptat.Name = "textCriptat";
            this.textCriptat.Size = new System.Drawing.Size(253, 22);
            this.textCriptat.TabIndex = 15;
            // 
            // textDecriptat
            // 
            this.textDecriptat.Location = new System.Drawing.Point(120, 242);
            this.textDecriptat.Margin = new System.Windows.Forms.Padding(4);
            this.textDecriptat.Name = "textDecriptat";
            this.textDecriptat.Size = new System.Drawing.Size(253, 22);
            this.textDecriptat.TabIndex = 16;
            // 
            // label1b
            // 
            this.label1b.AutoSize = true;
            this.label1b.Location = new System.Drawing.Point(17, 12);
            this.label1b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1b.Name = "label1b";
            this.label1b.Size = new System.Drawing.Size(280, 17);
            this.label1b.TabIndex = 17;
            this.label1b.Text = "Introdu textul pe care doresti sa-l decriptezi";
            // 
            // label2b
            // 
            this.label2b.AutoSize = true;
            this.label2b.Location = new System.Drawing.Point(17, 50);
            this.label2b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2b.Name = "label2b";
            this.label2b.Size = new System.Drawing.Size(220, 17);
            this.label2b.TabIndex = 18;
            this.label2b.Text = "Alege un cipher pentru decriptare";
            // 
            // text_cheie_decriptare
            // 
            this.text_cheie_decriptare.AutoSize = true;
            this.text_cheie_decriptare.Location = new System.Drawing.Point(17, 85);
            this.text_cheie_decriptare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text_cheie_decriptare.Name = "text_cheie_decriptare";
            this.text_cheie_decriptare.Size = new System.Drawing.Size(182, 17);
            this.text_cheie_decriptare.TabIndex = 19;
            this.text_cheie_decriptare.Text = "Introdu cheia de decriptare:";
            // 
            // text_to_decrypt
            // 
            this.text_to_decrypt.Location = new System.Drawing.Point(339, 8);
            this.text_to_decrypt.Margin = new System.Windows.Forms.Padding(4);
            this.text_to_decrypt.Name = "text_to_decrypt";
            this.text_to_decrypt.Size = new System.Drawing.Size(359, 22);
            this.text_to_decrypt.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.text_to_decrypt);
            this.Controls.Add(this.text_cheie_decriptare);
            this.Controls.Add(this.label2b);
            this.Controls.Add(this.label1b);
            this.Controls.Add(this.textDecriptat);
            this.Controls.Add(this.textCriptat);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_client);
            this.Controls.Add(this.btn_server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_cipher);
            this.Controls.Add(this.text_box_key);
            this.Controls.Add(this.Text_cheie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_box_cipher_chosen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_to_encrypt);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Text_cheie;
        private System.Windows.Forms.TextBox text_box_key;
        private System.Windows.Forms.Button button_cipher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox textCriptat;
        private System.Windows.Forms.TextBox textDecriptat;
        private System.Windows.Forms.Label label1b;
        private System.Windows.Forms.Label label2b;
        private System.Windows.Forms.Label text_cheie_decriptare;
        private System.Windows.Forms.TextBox text_to_decrypt;
    }
}

