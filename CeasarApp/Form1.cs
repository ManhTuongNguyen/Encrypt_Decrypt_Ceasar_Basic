using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeasarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtn_mahoa.Checked = true;
            rbtn_giaima.Checked = false;
        }

        private void rbtn_mahoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_mahoa.Checked)
            {
                rbtn_giaima.Checked = false;
            }
        }

        private void rbtn_giaima_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtn_giaima.Checked)
            {
                rbtn_mahoa.Checked = false;
            }
        }

        private void tbx_key_TextChanged(object sender, EventArgs e)
        {
            if (tbx_key.Text.Trim() != "" && tbx_key.Text != "")
            {
                btn_perform.Visible = true;
            }
            else
            {
                btn_perform.Visible = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (rbtn_mahoa.Checked)
            {
                opf.Filter = "Text file (*.txt) | *.txt";
            }
            else
            {
                opf.Filter = "Text file (*.ceasear) | *.ceasar";
            }
            if (opf.ShowDialog() == DialogResult.OK)
            {
                tbx_path.Text = opf.FileName;
            }
        }

        private void btn_perform_Click(object sender, EventArgs e)
        {
            int key_decrypt_encrypt = 0;
            string ndung = "";
            if (!File.Exists(tbx_path.Text))
            {
                MessageBox.Show("Tệp tin không tồn tại!\nThử lại!");
            }
            try
            {
                StreamReader strR = new StreamReader(tbx_path.Text);
                ndung = strR.ReadToEnd(); // Nội dung file đã có trong string ndung
                strR.Close(); // Đóng tập tin
                strR.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ATBMTT_B1_Ceasar.CeasarHelper cH = new ATBMTT_B1_Ceasar.CeasarHelper();
            try
            {
                key_decrypt_encrypt = int.Parse(tbx_key.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (Math.Abs(int.Parse(tbx_key.Text)) > cH.chuoiMaHoa.Length)
            {
                MessageBox.Show($"Key phải có giá trị tuyệt đối < {cH.chuoiMaHoa.Length}");
                return;
            }
            string ketqua = "";
            if (rbtn_mahoa.Checked)
            {
                ketqua = cH.maHoa(ndung, key_decrypt_encrypt);
            }
            else
            {
                ketqua = cH.giaiMa(ndung, key_decrypt_encrypt);
            }
            SaveFileDialog sFD = new SaveFileDialog();
            if (rbtn_giaima.Checked)
            {
                sFD.Filter = "Text file (*.txt) | *.txt";
            }
            else
            {
                sFD.Filter = "Text file (*.ceasar) | *.ceasar";
            }
            if (sFD.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sFD.FileName, ketqua);
                MessageBox.Show("Hoàn thành!");
            }
            sFD.Dispose();
            tbx_key.Text = "";
        }
    }
}
