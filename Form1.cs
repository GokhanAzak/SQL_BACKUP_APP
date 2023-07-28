using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Windows.Forms;


namespace AryaSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {

            //YOL DİZİNİN KODU
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "yedeklnecek yolu beliritniz";
            saveFileDialog1.Filter = "yedekleme dosyaları(*.bak)|*.bak|Tüm dosyalar(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txtPath.Text = saveFileDialog1.FileName;

            }




        }

        private void btn_Back_Up_Click(object sender, EventArgs e)
        {

            //Server connection 3 adet parametre alıyor serverIstance usarname,password
            Server dbserver = new Server(new ServerConnection(Database_txt.Text));
            Backup dbBackUP = new Backup();

            dbBackUP.Action = BackupActionType.Database;
            dbBackUP.Database = Database_txt.Text;
            //EKSİK VAR BAK
            //HATA VAR
            dbBackUP.Devices.AddDevice("C:\\SilSonra\\CRM.bak", BackupDeviceType.File);



            dbBackUP.Initialize = false;

            dbBackUP.SqlBackup(dbserver);

            dbBackUP.Complete += DbBackUP_Complete;


        }

        //YEDEKLEME BASARLI POPUP
        private void DbBackUP_Complete(object sender, ServerMessageEventArgs e)
        {
            try
            {
                MessageBox.Show("YEDEKLEME BAŞARALI", "WARNİNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("YEDEKLEME BAŞARISIZ", "WARNİNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            if (username_txt.Text == "admin" && username_txt.Text == "12345")
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            //www.bilisimkonulari.com
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            if (password_txt.Text == "admin" && password_txt.Text == "12345")
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            //www.bilisimkonulari.com
            {
                MessageBox.Show("Hatalı Giriş");
            }

        }
    }
}
