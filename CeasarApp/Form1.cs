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
            //Tự tích radiobuton Mã Hóa khi load form
            rbtn_mahoa.Checked = true;
            rbtn_giaima.Checked = false;
        }

        private void rbtn_mahoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_mahoa.Checked)
            {
                //Bỏ tích radiobutton giải mã khi radiobutton mã hóa đc tích
                rbtn_giaima.Checked = false;
            }
        }

        private void rbtn_giaima_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtn_giaima.Checked)
            {
                //Bỏ tích radiobutton mã hóa khi radiobutton giải mã đc tích
                rbtn_mahoa.Checked = false;
            }
        }

        private void tbx_key_TextChanged(object sender, EventArgs e)
        {
            if (tbx_key.Text.Trim() != "" && tbx_key.Text != "")
            {
                //Chỉ hiện nút thực hiện khi textbox path có ký tự
                btn_perform.Visible = true;
            }
            else
            {
                btn_perform.Visible = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //khởi tạo đối tượng dùng để mở file
            OpenFileDialog opf = new OpenFileDialog();
            if (rbtn_mahoa.Checked)
            {
                //filter file extension
                opf.Filter = "Text file (*.txt) | *.txt";
            }
            else
            {
                //filter file extension
                opf.Filter = "Text file (*.ceasear) | *.ceasar";
            }
            if (opf.ShowDialog() == DialogResult.OK)
            {
                //Ghi file name đã chọn ra ô textbox path
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
                return;
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
            //Khởi tạo đối tượng để lưu file
            SaveFileDialog sFD = new SaveFileDialog();
            if (rbtn_giaima.Checked)
            {
                //filter file extension
                sFD.Filter = "Text file (*.txt) | *.txt";
            }
            else
            {
                //filter file extension
                sFD.Filter = "Text file (*.ceasar) | *.ceasar";
            }
            if (sFD.ShowDialog() == DialogResult.OK)
            {
                //Ghi hết dữ liệu từ chuỗi ketqua ra file đã chọn
                File.WriteAllText(sFD.FileName, ketqua);
                MessageBox.Show("Hoàn thành!");
            }
            sFD.Dispose();
            tbx_key.Text = "";
        }
    }
}
