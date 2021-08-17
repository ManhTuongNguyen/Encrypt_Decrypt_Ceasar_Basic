using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBMTT_B1_Ceasar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbx_needEncrypt_TextChanged(object sender, EventArgs e)
        {
            this.tbx_needEncrypt.ForeColor = Color.Black;
            if (tbx_needEncrypt.Text.Trim() != "" && tbx_needEncrypt.Text != "")
            {
                this.btn_Encrypt.Visible = true;
            }
            else
            {
                this.btn_Encrypt.Visible = false;
            }
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            int key;
            var mahoa = new CeasarHelper();
            //MessageBox.Show(mahoa.chuoiMaHoa.Length.ToString());
            MessageBox.Show(mahoa.chuoiMaHoa[0].ToString());
            MessageBox.Show(mahoa.chuoiMaHoa[mahoa.chuoiMaHoa.Length - 1].ToString(), (mahoa.chuoiMaHoa.Length - 1).ToString());
            try
            {
                key = int.Parse(tbx_keyEncrypt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if(Math.Abs(key) > mahoa.chuoiMaHoa.Length)
            {
                MessageBox.Show($"Key mã hóa phải có giá trị tuyệt đối < {mahoa.chuoiMaHoa.Length}");
                return;
            }
            this.tbx_needDecrypt.Text = mahoa.maHoa(this.tbx_needEncrypt.Text, key).ToString();
            this.tbx_keyEncrypt.Text = null;
            //this.tbx_needEncrypt.Text = null;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {

            int key;
            var giaima = new CeasarHelper();
            try
            {
                key = int.Parse(tbx_keyDecrypt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (Math.Abs(key) > giaima.chuoiMaHoa.Length)
            {
                MessageBox.Show($"Key mã hóa phải có giá trị tuyệt đối < {giaima.chuoiMaHoa.Length}");
                return;
            }
            this.tbx_Decrypted.Text = giaima.giaiMa(this.tbx_needDecrypt.Text, key).ToString();
        }
    }
}
