using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_securitate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            label3.Visible = false;
            label6.Visible = false;
            textDecryptat.Visible = false;
            textCriptat.Visible = false;
            //Prelucrat de maxim
            //Comentat de Iulia_E
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

        private void button_cipher_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label6.Visible = true;
            textDecryptat.Visible = true;
            textCriptat.Visible = true;

            if(combo_box_cipher_chosen.Text.Equals("Cezar") && text_box_key.Text.ToString() != "" && text_to_encrypt.Text.ToString() != "")
            {
                int shift_key = Int32.Parse(text_box_key.Text.ToString());
                string input = text_to_encrypt.Text.ToString();
                textDecryptat.Text = Cezar_decrypt(input,shift_key);
            }
            else 
                if(combo_box_cipher_chosen.Text.Equals("Vigenere") && text_box_key.Text.ToString() != "" && text_to_encrypt.Text.ToString() != "")
                {
                    string input= text_to_encrypt.Text.ToString();
                    string key = text_box_key.Text.ToString().ToLower();
                    textCriptat.Text = Vigenere_encryption(input,key);
                }
        }
    }
}
