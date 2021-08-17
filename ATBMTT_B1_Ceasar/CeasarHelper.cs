using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBMTT_B1_Ceasar
{
    public class CeasarHelper
    {
        //chuỗi ký tự dùng để thực hiện mã hóa ceasar
        public char[] chuoiMaHoa = {'h', 'i','p', '5', '6', 'b', 'c', 'd', '7', 'y', '8', 'q', 'z', '1', 'j', 'g', 'o',
                'w', '3', '4', '2', 'r', 'n', 'a', 'e', 'f', 's', 'x', 't', 'u', 'v', '9', ' ', 'k', 'l', 'm'};
        private int keyGiaiMa { get; set; }
        private int keyMaHoa { get; set; }

        private string needDecrypt { get; set; }
        private string needEncrypt { get; set; }
        public string maHoa(string chuoimahoa, int key)
        {
            //Mã hóa dữ liệu với phương pháp ceasar
            string stringEncrypted = "";
            this.needEncrypt = chuoimahoa;
            foreach (var onechar in this.needEncrypt)
            {
                //int i = chuoimahoa.IndexOf(onechar);
                if (!Array.Exists(chuoiMaHoa, element => element == onechar))
                {
                    //Trường hợp ký tự không tồn tại trong chuỗi có sẵn
                    //Bỏ qua ký tự này và tiếp tục với các ký tự tiếp theo
                    stringEncrypted += onechar;
                    continue;
                }
                int i = Array.IndexOf(chuoiMaHoa, onechar);
                //Thuật toán seasar, thay đổi giá trị có trong bảng ký tự bằng một giá trị khác với khóa keyMaHoa
                this.keyMaHoa = key;
                if (keyMaHoa > 0)
                    while (keyMaHoa > 0)
                    {
                        i++;
                        if (i == chuoiMaHoa.Length)
                        {
                            i = 0;
                        }
                        keyMaHoa--;
                    }
                else
                    while (keyMaHoa < 0)
                    {
                        i--;
                        if (i == -1)
                        {
                            i = chuoiMaHoa.Length - 1;
                        }
                        keyMaHoa++;
                    }
                stringEncrypted += chuoiMaHoa[i];
            }
            return stringEncrypted;
        }

        public string giaiMa(string chuoigiaima, int key)
        {
            //
            string stringDecrypted = "";
            this.keyGiaiMa = key;
            this.needDecrypt = chuoigiaima;
            foreach (var onechar in this.needDecrypt)
            {
                //int i = chuoigiaima.IndexOf(onechar);
                if (!Array.Exists(chuoiMaHoa, element => element == onechar))
                {
                    //Trường hợp ký tự cần giải mã không có trong bảng chữ cái
                    //bỏ qua ký tự này và giải mã ký tự khác
                    stringDecrypted += onechar;
                    continue;
                }
                int i = Array.IndexOf(chuoiMaHoa, onechar);
                //Thuật toán seasar, lấy lại giá trị gốc với những ký tự có trong bảng chữ cái với khóa keyGiaiMa
                this.keyGiaiMa = key;
                if (keyGiaiMa > 0)
                    while (- keyGiaiMa < 0)
                    {
                        i--;
                        if (i == -1)
                        {
                            i = chuoiMaHoa.Length - 1;
                        }
                        keyGiaiMa--;
                    }
                else
                    while (- keyGiaiMa > 0)
                    {
                        i++;
                        if (i == chuoiMaHoa.Length)
                        {
                            i = 0;
                        }
                        keyGiaiMa++;
                    }
                stringDecrypted += chuoiMaHoa[i];
            }
            return stringDecrypted;
        }
    }
}