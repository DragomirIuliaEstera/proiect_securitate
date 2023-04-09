using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
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
        public Form1()
        {
            InitializeComponent();
           
            label3.Visible = false;
            label6.Visible = false;
            textDecryptat.Visible = false;
            textCriptat.Visible = false;
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

        public string Vigenere_decryption(string plain_text, string key)
        {//
            string encrypted_text = string.Empty;
            int key_length = key.Length;
            int index = 0;

            foreach (char c in plain_text)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    char lower_letter = char.ToLower(c);
                    int key_shift = ((int)key[index]) - 97;
                    int encrypted_letter = (int)lower_letter + key_shift;

                    if (encrypted_letter > 122)
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
                try
                {
                    int shift_key = Int32.Parse(text_box_key.Text.ToString());
                    string input = text_to_encrypt.Text.ToString();
                    textCriptat.Text = Cezar_encrypt(input, shift_key);
                    textDecryptat.Text = Cezar_decrypt(textCriptat.Text, shift_key);
                }
                catch(Exception ex) { textCriptat.Text = "Cheia trebuie sa fie un numar"; }
            }
            else 
                if(combo_box_cipher_chosen.Text.Equals("Vigenere") && text_box_key.Text.ToString() != "" && text_to_encrypt.Text.ToString() != "")
                {
                    string input= text_to_encrypt.Text.ToString();
                    string key = text_box_key.Text.ToString().ToLower();
                    textCriptat.Text = Vigenere_encryption(input,key);
                    //textDecryptat.Text = Cezar_decrypt(textCriptat.Text,shift_key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            run_cmd("ok", "7 7");
        }

        public string run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "hello.exe";
            start.Arguments = string.Format("\"{0}\" \"{1}\"", cmd, args);
            start.UseShellExecute = false;// Do not use OS shell
            start.CreateNoWindow = true; // We don't need new window
            start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
            start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                    string result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")
                    return result;
                }
            }
            //Console.WriteLine("server started");
        }
    }
}
/*
 * var eng = IronPython.Hosting.Python.CreateEngine();
            var scope = eng.CreateScope();
            eng.Execute(@"
import socket

def server():
    host = '10.1.24.64' #Server ip
    port = 4000
    s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    s.bind((host, port))
    while True:
        data, addr = s.recvfrom(1024)
        data = data.decode('utf-8')
        data = data.upper()
        s.sendto(data.encode('utf-8'), addr)
    c.close()
    return 'Server started'
", scope);
            dynamic server = scope.GetVariable("server");
            //Console.WriteLine(server());
 * 
 * */
