using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_securitate
{ 
    public partial class Form1 : Form
    {

        bool serverFlag;
        bool clientFlag;
        public Form1()
        {
            InitializeComponent();

            load_form();
        }

        public string Cezar_encrypt(string plaintext, int shift_key)
        {
            string message = plaintext;
            int requiredShift = shift_key;

            byte[] ascii = Encoding.ASCII.GetBytes(message);
            List<int> buffer = new List<int>();

            for (int i = 0; i < ascii.Length; ++i)
            {
                int x = Convert.ToInt32(ascii[i]);
                if (char.IsLetter((char)ascii[i]))
                {
                    if (char.IsUpper((char)ascii[i]))
                    {
                        buffer.Add((x - 65 + requiredShift) % 26);
                    }
                    else
                    {
                        buffer.Add((x - 97 + requiredShift) % 26);
                    }
                }
                else{
                    buffer.Add(x);
                }
            }
            string encryptedMessage = "";
            for (int i = 0; i < ascii.Length; ++i)
            {
                if (char.IsLetter((char)ascii[i]))
                {
                    if (char.IsUpper((char)ascii[i]))
                        encryptedMessage += Char.ConvertFromUtf32(buffer[i] + 65);
                    else
                        encryptedMessage += Char.ConvertFromUtf32(buffer[i] + 97);
                }
                else
                {
                    encryptedMessage += Char.ConvertFromUtf32(buffer[i]);
                }
            }

            return encryptedMessage;
        }

        public string Cezar_decrypt(string crypetd_text,int shift_key)
        {
            string decrypted_text = string.Empty;
            
            foreach(char c in crypetd_text)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    char letter;
                    letter = char.ToLower(c);
                    char shifted_letter = (char)(((letter - shift_key - 'a' + 26) % 26) + 'a');
                    
                    if (isUpper)
                    {
                        shifted_letter = char.ToUpper(shifted_letter);
                        decrypted_text += shifted_letter;
                    }
                    else
                    { 
                        decrypted_text += shifted_letter;
                    }
                }
                else
                {
                    decrypted_text+= c;
                }
            }

            return decrypted_text;
        } 

        public string Vigenere_encryption(string plain_text,string key)
        {
            string encrypted_text = string.Empty;
            int key_length = key.Length;
            int index = 0;

            foreach(char c in plain_text)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    char lower_letter = char.ToLower(c);
                    int key_shift = ((int)key[index]) - 97;
                    int encrypted_letter = (int)lower_letter + key_shift;

                    if(encrypted_letter > 122)
                    {
                        encrypted_letter -= 26;
                    }

                    if (isUpper)
                    {
                        encrypted_letter -= 32;
                    }

                    encrypted_text += ((char)encrypted_letter).ToString();

                    index = (index + 1) % key_length;
                }
                else
                {
                    encrypted_text += c;
                }
            }

            return encrypted_text;
        }

        public string Vigenere_decryption(string encrypted_text, string key)
        {
            string decrypted_text = string.Empty;
            int key_length = key.Length;
            int index = 0;

            foreach (char c in encrypted_text)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    char lower_letter;
                    if (isUpper)
                        lower_letter = char.ToLower(c);
                    else
                    {
                        lower_letter = c;
                    }
                    int lower_letter_alpha = (int)lower_letter - 97;
                    int key_shift;
                    if ((int)key[index]>=65 && (int)key[index] <= 90)
                        key_shift = ((int)key[index]) - 65;
                    else
                        key_shift = ((int)key[index]) - 97;
                    int decrypted_letter;
                    if ((decrypted_letter = (lower_letter_alpha - key_shift)) < 0)
                        decrypted_letter += 26;

                    decrypted_letter += 97;

                    if (isUpper)
                    {
                        decrypted_letter -= 32;
                    }

                    decrypted_text += ((char)decrypted_letter).ToString();

                    index = (index + 1 ) % key_length;
                }
                else
                {
                    decrypted_text += c;
                }
            }

            return decrypted_text;
        }

        private void button_cipher_Click(object sender, EventArgs e)
        {
            if(serverFlag == true)
            {
                label6.Visible = true;
                textDecriptat.Visible = true;
                if (combo_box_cipher_chosen.Text.Equals("Cezar") && text_box_key.Text.ToString() != "" && text_to_decrypt.Text.ToString() != "")
                {
                    try
                    {
                        int shift_key = Int32.Parse(text_box_key.Text.ToString());
                        string input = text_to_decrypt.Text.ToString();
                        textDecriptat.Text = Cezar_decrypt(input, shift_key);
                    }
                    catch (Exception ex) { textDecriptat.Text = "Cheia trebuie sa fie un numar"; }
                }
                else
                if (combo_box_cipher_chosen.Text.Equals("Vigenere") && text_box_key.Text.ToString() != "" && text_to_decrypt.Text.ToString() != "")
                {
                    string input = text_to_decrypt.Text.ToString();
                    string key = text_box_key.Text.ToString().ToLower();
                    textDecriptat.Text = Vigenere_decryption(input, key);
                }
            }
            else if(clientFlag == true)
            {
                label3.Visible = true;
                textCriptat.Visible = true;
                if (combo_box_cipher_chosen.Text.Equals("Cezar") && text_box_key.Text.ToString() != "" && text_to_encrypt.Text.ToString() != "")
                {
                    try
                    {
                        int shift_key = Int32.Parse(text_box_key.Text.ToString());
                        string input = text_to_encrypt.Text.ToString();
                        textCriptat.Text = Cezar_encrypt(input, shift_key);
                    }
                    catch (Exception ex) { textCriptat.Text = "Cheia trebuie sa fie un numar"; }
                }
                else
                if (combo_box_cipher_chosen.Text.Equals("Vigenere") && text_box_key.Text.ToString() != "" && text_to_encrypt.Text.ToString() != "")
                {
                    string input = text_to_encrypt.Text.ToString();
                    string key = text_box_key.Text.ToString().ToLower();
                    textCriptat.Text = Vigenere_encryption(input, key);
                }
            }
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            serverFlag = true;
            label4.Visible = false;
            btn_server.Visible = false;
            btn_client.Visible = false;

            label1b.Visible = true;
            label2b.Visible = true;
            text_to_decrypt.Visible = true;
            text_cheie_decriptare.Visible = true;
            
            combo_box_cipher_chosen.Visible = true;
            text_box_key.Visible = true;
            button_cipher.Visible = true;
            btn_back.Visible = true;
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            clientFlag = true;
            label4.Visible = false;
            btn_server.Visible = false;
            btn_client.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            Text_cheie.Visible = true;
            text_to_encrypt.Visible = true;
            combo_box_cipher_chosen.Visible = true;
            text_box_key.Visible = true;
            button_cipher.Visible = true;
            btn_back.Visible = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            load_form();
        }
        private void load_form()
        {
            label4.Visible = true;
            btn_server.Visible = true;
            btn_client.Visible = true;

            label3.Visible = false;
            label6.Visible = false;
            textDecriptat.Visible = false;
            textCriptat.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            Text_cheie.Visible = false;
            text_to_encrypt.Visible = false;
            combo_box_cipher_chosen.Visible = false;
            text_box_key.Visible = false;
            button_cipher.Visible = false;
            btn_back.Visible = false;
            label1b.Visible = false;
            label2b.Visible = false;
            text_to_decrypt.Visible = false;
            text_cheie_decriptare.Visible = false;
            serverFlag = false;
            clientFlag = false;
        }
    }
}