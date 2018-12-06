using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Разное
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Меню
        private void ОчиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtB_crypt.Clear();
            rtB_deCrypt.Clear();
            tB_keyCrypt.Clear();
            tB_keyDeCrypt.Clear();
        }
        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы: Юдин Никита\nДата создания: 30.11.2018\nСвязь: nikitayudin782@gmail.com", "Информация");
        }


        // Шифрование и дешифрование
        /// Шифрует строку (Строка которую необходимо зашифровать, Ключ шифрования)
        public static string Encrypt(string str, string keyCrypt)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(str), keyCrypt));
        }
        /// Расшифроывает данные из строки (Зашифрованая строка, Ключ шифрования)
        public static string Decrypt(string str, string keyCrypt)
        {
            string Result;
            try
            {
                CryptoStream Cs = InternalDecrypt(Convert.FromBase64String(str), keyCrypt);
                StreamReader Sr = new StreamReader(Cs);

                Result = Sr.ReadToEnd();

                Cs.Close();
                Cs.Dispose();

                Sr.Close();
                Sr.Dispose();
            }
            catch (CryptographicException)
            {
                return null;
            }

            return Result;
        }
        private static byte[] Encrypt(byte[] key, string value)
        {
            SymmetricAlgorithm Sa = Rijndael.Create();
            ICryptoTransform Ct = Sa.CreateEncryptor((new PasswordDeriveBytes(value, null)).GetBytes(16), new byte[16]);

            MemoryStream Ms = new MemoryStream();
            CryptoStream Cs = new CryptoStream(Ms, Ct, CryptoStreamMode.Write);

            Cs.Write(key, 0, key.Length);
            Cs.FlushFinalBlock();

            byte[] Result = Ms.ToArray();

            Ms.Close();
            Ms.Dispose();

            Cs.Close();
            Cs.Dispose();

            Ct.Dispose();

            return Result;
        }
        private static CryptoStream InternalDecrypt(byte[] key, string value)
        {
            SymmetricAlgorithm sa = Rijndael.Create();
            ICryptoTransform ct = sa.CreateDecryptor((new PasswordDeriveBytes(value, null)).GetBytes(16), new byte[16]);

            MemoryStream ms = new MemoryStream(key);
            return new CryptoStream(ms, ct, CryptoStreamMode.Read);
        }
 
        /// Кнопки по шифр. и дешифр.
        private void Btn_crypt_Click(object sender, EventArgs e)
        {
            if (rtB_crypt.Text != "")
            {
                if (tB_keyCrypt.Text != "")
                {
                    string keyCrypt = tB_keyCrypt.Text;
                    rtB_deCrypt.Clear();
                    rtB_deCrypt.AppendText(Encrypt(rtB_crypt.Text, keyCrypt));
                } else MessageBox.Show("Введите ключ.", "Ошибка!");
            } else MessageBox.Show("Введите текст.", "Ошибка!");
        }
        private void Btn_deCrypt_Click(object sender, EventArgs e)
        {
            if (rtB_deCrypt.Text != "")
            {
                if (tB_keyDeCrypt.Text != "")
                {
                    string keyCrypt;
                    rtB_crypt.Clear();
                    keyCrypt = tB_keyDeCrypt.Text;
                    if (Decrypt(rtB_deCrypt.Text, keyCrypt) == null)
                    {
                        MessageBox.Show("Неправильный ключ.", "Ошибка!");
                    } else rtB_crypt.AppendText(Decrypt(rtB_deCrypt.Text, keyCrypt));
                } else MessageBox.Show("Введите ключ.", "Ошибка!");
            } else MessageBox.Show("Введите текст.", "Ошибка!");
        }
        private void CB_randKey_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_randKey.Checked)
            {
                tB_keyCrypt.Clear();
                tB_keyCrypt.Text = Path.GetRandomFileName();
            }
            else tB_keyCrypt.Clear();
        }


        // Файлы
        private void Btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "Txt Files|*.txt"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader fileTxt = new StreamReader(openFile.FileName, Encoding.Default);
                rtB_crypt.Clear();
                rtB_crypt.Text = Convert.ToString(fileTxt.ReadToEnd());
                fileTxt.Close();
            }
        }
        private void Btn_openDeCrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "Txt Files|*.txt"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader fileTxt = new StreamReader(openFile.FileName, Encoding.Default);
                rtB_deCrypt.Clear();
                rtB_deCrypt.Text = Convert.ToString(fileTxt.ReadToEnd());
                fileTxt.Close();
            }
        }
        private void Btn_saveFile_Click(object sender, EventArgs e)
        {
            if (rtB_deCrypt.Text != "")
            {
                SaveFileDialog saveFile = new SaveFileDialog()
                {
                    Filter = "Txt Files|*.txt"
                };
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter saveTxt = new StreamWriter(saveFile.FileName);
                    saveTxt.WriteLine(rtB_deCrypt.Text);
                    saveTxt.Close();
                }
            }
        }


        // ВКонтакте
        private void Btn_VK_Click(object sender, EventArgs e)
        {
            if (Form1.ActiveForm.Width == 770)
            {
                Form1.ActiveForm.Width = 1170;
                webBrowser.Visible = true;
            }
            else
            {
                webBrowser.Visible = false;
                Form1.ActiveForm.Width = 770;
            }
        }
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Visible = true;
            Form1.ActiveForm.Width = 1170;
        }
        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Visible = false;
            Form1.ActiveForm.Width = 770;
        }

    }
}
