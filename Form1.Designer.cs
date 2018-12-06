namespace Разное
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.cB_randKey = new System.Windows.Forms.CheckBox();
            this.tB_keyCrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_crypt = new System.Windows.Forms.Button();
            this.rtB_crypt = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.tB_keyDeCrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtB_deCrypt = new System.Windows.Forms.RichTextBox();
            this.btn_deCrypt = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_VK = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_openDeCrypt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(754, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВКToolStripMenuItem,
            this.очиститьВсеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьВКToolStripMenuItem
            // 
            this.открытьВКToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.открытьВКToolStripMenuItem.Name = "открытьВКToolStripMenuItem";
            this.открытьВКToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.открытьВКToolStripMenuItem.Text = "ВК";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.ЗакрытьToolStripMenuItem_Click);
            // 
            // очиститьВсеToolStripMenuItem
            // 
            this.очиститьВсеToolStripMenuItem.Name = "очиститьВсеToolStripMenuItem";
            this.очиститьВсеToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.очиститьВсеToolStripMenuItem.Text = "Очистить все";
            this.очиститьВсеToolStripMenuItem.Click += new System.EventHandler(this.ОчиститьВсеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_openFile);
            this.groupBox1.Controls.Add(this.cB_randKey);
            this.groupBox1.Controls.Add(this.tB_keyCrypt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_crypt);
            this.groupBox1.Controls.Add(this.rtB_crypt);
            this.groupBox1.Location = new System.Drawing.Point(18, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(681, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зашифровать";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(326, 186);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(112, 28);
            this.btn_openFile.TabIndex = 5;
            this.btn_openFile.Text = "Открыть";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.Btn_openFile_Click);
            // 
            // cB_randKey
            // 
            this.cB_randKey.AutoSize = true;
            this.cB_randKey.Location = new System.Drawing.Point(208, 189);
            this.cB_randKey.Name = "cB_randKey";
            this.cB_randKey.Size = new System.Drawing.Size(112, 24);
            this.cB_randKey.TabIndex = 4;
            this.cB_randKey.Text = "Случайный";
            this.cB_randKey.UseVisualStyleBackColor = true;
            this.cB_randKey.CheckedChanged += new System.EventHandler(this.CB_randKey_CheckedChanged);
            // 
            // tB_keyCrypt
            // 
            this.tB_keyCrypt.Location = new System.Drawing.Point(70, 187);
            this.tB_keyCrypt.Name = "tB_keyCrypt";
            this.tB_keyCrypt.Size = new System.Drawing.Size(132, 26);
            this.tB_keyCrypt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ключ:";
            // 
            // btn_crypt
            // 
            this.btn_crypt.Location = new System.Drawing.Point(524, 182);
            this.btn_crypt.Name = "btn_crypt";
            this.btn_crypt.Size = new System.Drawing.Size(150, 36);
            this.btn_crypt.TabIndex = 1;
            this.btn_crypt.Text = "Зашифровать";
            this.btn_crypt.UseVisualStyleBackColor = true;
            this.btn_crypt.Click += new System.EventHandler(this.Btn_crypt_Click);
            // 
            // rtB_crypt
            // 
            this.rtB_crypt.Location = new System.Drawing.Point(7, 27);
            this.rtB_crypt.Name = "rtB_crypt";
            this.rtB_crypt.Size = new System.Drawing.Size(667, 149);
            this.rtB_crypt.TabIndex = 0;
            this.rtB_crypt.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_openDeCrypt);
            this.groupBox2.Controls.Add(this.btn_saveFile);
            this.groupBox2.Controls.Add(this.tB_keyDeCrypt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rtB_deCrypt);
            this.groupBox2.Controls.Add(this.btn_deCrypt);
            this.groupBox2.Location = new System.Drawing.Point(18, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(681, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расшифровать";
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.Location = new System.Drawing.Point(326, 201);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(112, 28);
            this.btn_saveFile.TabIndex = 6;
            this.btn_saveFile.Text = "Сохранить";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Click += new System.EventHandler(this.Btn_saveFile_Click);
            // 
            // tB_keyDeCrypt
            // 
            this.tB_keyDeCrypt.Location = new System.Drawing.Point(70, 202);
            this.tB_keyDeCrypt.Name = "tB_keyDeCrypt";
            this.tB_keyDeCrypt.Size = new System.Drawing.Size(132, 26);
            this.tB_keyDeCrypt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ключ:";
            // 
            // rtB_deCrypt
            // 
            this.rtB_deCrypt.Location = new System.Drawing.Point(14, 27);
            this.rtB_deCrypt.Name = "rtB_deCrypt";
            this.rtB_deCrypt.Size = new System.Drawing.Size(660, 164);
            this.rtB_deCrypt.TabIndex = 2;
            this.rtB_deCrypt.Text = "";
            // 
            // btn_deCrypt
            // 
            this.btn_deCrypt.Location = new System.Drawing.Point(524, 197);
            this.btn_deCrypt.Name = "btn_deCrypt";
            this.btn_deCrypt.Size = new System.Drawing.Size(150, 36);
            this.btn_deCrypt.TabIndex = 2;
            this.btn_deCrypt.Text = "Расшифровать";
            this.btn_deCrypt.UseVisualStyleBackColor = true;
            this.btn_deCrypt.Click += new System.EventHandler(this.Btn_deCrypt_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(762, 32);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(390, 477);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.Url = new System.Uri("https://m.vk.com/im", System.UriKind.Absolute);
            this.webBrowser.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_VK
            // 
            this.btn_VK.Location = new System.Drawing.Point(706, 30);
            this.btn_VK.Name = "btn_VK";
            this.btn_VK.Size = new System.Drawing.Size(41, 477);
            this.btn_VK.TabIndex = 4;
            this.btn_VK.Text = "ВК";
            this.btn_VK.UseVisualStyleBackColor = true;
            this.btn_VK.Click += new System.EventHandler(this.Btn_VK_Click);
            // 
            // btn_openDeCrypt
            // 
            this.btn_openDeCrypt.Location = new System.Drawing.Point(208, 202);
            this.btn_openDeCrypt.Name = "btn_openDeCrypt";
            this.btn_openDeCrypt.Size = new System.Drawing.Size(112, 28);
            this.btn_openDeCrypt.TabIndex = 7;
            this.btn_openDeCrypt.Text = "Открыть";
            this.btn_openDeCrypt.UseVisualStyleBackColor = true;
            this.btn_openDeCrypt.Click += new System.EventHandler(this.Btn_openDeCrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 521);
            this.Controls.Add(this.btn_VK);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Шифрование";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_crypt;
        private System.Windows.Forms.RichTextBox rtB_crypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtB_deCrypt;
        private System.Windows.Forms.Button btn_deCrypt;
        private System.Windows.Forms.CheckBox cB_randKey;
        private System.Windows.Forms.TextBox tB_keyCrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_keyDeCrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_saveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_VK;
        private System.Windows.Forms.ToolStripMenuItem открытьВКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_openDeCrypt;
    }
}

