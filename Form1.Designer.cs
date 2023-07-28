
namespace AryaSoft
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.server_txt = new System.Windows.Forms.TextBox();
            this.Database_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Back_Up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // server_txt
            // 
            this.server_txt.Location = new System.Drawing.Point(89, 80);
            this.server_txt.Name = "server_txt";
            this.server_txt.Size = new System.Drawing.Size(161, 22);
            this.server_txt.TabIndex = 0;
            // 
            // Database_txt
            // 
            this.Database_txt.Location = new System.Drawing.Point(89, 139);
            this.Database_txt.Name = "Database_txt";
            this.Database_txt.Size = new System.Drawing.Size(161, 22);
            this.Database_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "DataBase:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(89, 190);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Windows";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(89, 231);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Authentication";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(114, 332);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(165, 22);
            this.username_txt.TabIndex = 6;
            this.username_txt.TextChanged += new System.EventHandler(this.username_txt_TextChanged);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(114, 373);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(165, 22);
            this.password_txt.TabIndex = 7;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // btn_Select
            // 
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Select.Location = new System.Drawing.Point(577, 312);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 10;
            this.btn_Select.Text = "...";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(393, 313);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(161, 22);
            this.txtPath.TabIndex = 11;
            this.txtPath.TextChanged += new System.EventHandler(this.btn_Select_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Back_Up
            // 
            this.btn_Back_Up.AutoSize = true;
            this.btn_Back_Up.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Back_Up.Location = new System.Drawing.Point(394, 368);
            this.btn_Back_Up.Name = "btn_Back_Up";
            this.btn_Back_Up.Size = new System.Drawing.Size(123, 26);
            this.btn_Back_Up.TabIndex = 14;
            this.btn_Back_Up.Text = "BackUP";
            this.btn_Back_Up.UseVisualStyleBackColor = true;
            this.btn_Back_Up.Click += new System.EventHandler(this.btn_Back_Up_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 522);
            this.Controls.Add(this.btn_Back_Up);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Database_txt);
            this.Controls.Add(this.server_txt);
            this.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.Name = "Form1";
            this.Text = "AryaSoft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server_txt;
        private System.Windows.Forms.TextBox Database_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.TextBox username_txt;
        public System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Back_Up;
    }
}

