using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBMTT_B1_Ceasar
{
    public class CeasarHelper
    {
        public char[] chuoiMaHoa = {'h', 'i','p', '5', '6', 'b', 'c', 'd', '7', 'y', '8', 'q', 'z', '1', 'j', 'g', 'o',
                'w', '3', '4', '2', 'r', 'n', 'a', 'e', 'f', 's', 'x', 't', 'u', 'v', '9', ' ', 'k', 'l', 'm'};
        private int keyGiaiMa { get; set; }
        private int keyMaHoa { get; set; }

        private string needDecrypt { get; set; }
        private string needEncrypt { get; set; }
        public string maHoa(string chuoimahoa, int key)
        {
            string stringEncrypted = "";
            this.keyMaHoa = key;
            this.needEncrypt = chuoimahoa;
            foreach (var onechar in this.needEncrypt)
            {
                //int i = chuoimahoa.IndexOf(onechar);
                if (!Array.Exists(chuoiMaHoa, element => element == onechar))
                {
                    stringEncrypted += onechar;
                    continue;
                }
                int i = Array.IndexOf(chuoiMaHoa, onechar);
                i += keyMaHoa;
                if (i > chuoiMaHoa.Length - 1)
                    i -= (chuoiMaHoa.Length - 1);
                if (i < 0)
                    i = i + chuoiMaHoa.Length - 1;
                stringEncrypted += chuoiMaHoa[i];
            }
            return stringEncrypted;
        }

        public string giaiMa(string chuoigiaima, int key)
        {
            string stringDecrypted = "";
            this.keyGiaiMa = key;
            this.needDecrypt = chuoigiaima;
            foreach (var onechar in this.needDecrypt)
            {
                //int i = chuoigiaima.IndexOf(onechar);
                if (!Array.Exists(chuoiMaHoa, element => element == onechar))
                {
                    stringDecrypted += onechar;
                    continue;
                }
                int i = Array.IndexOf(chuoiMaHoa, onechar);
                i -= keyGiaiMa;
                if (i > chuoiMaHoa.Length - 1)
                    i -= (chuoiMaHoa.Length - 1);
                if (i < 0)
                    i = i + chuoiMaHoa.Length - 1;
                stringDecrypted += chuoiMaHoa[i];
            }
            return stringDecrypted;
        }
    }
}