using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RC4_Algoritma
{
    class RC4
    {
        private const int N = 256;
        private int[] sbox;
        private string anahtar;
        private string text;

        public RC4(string anahtar, string text)
        {
            this.anahtar = anahtar;
            this.text = text;
        }

        public RC4(string anahtar)
        {
            this.anahtar = anahtar;
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public string Password
        {
            get { return anahtar; }
            set { anahtar = value; }
        } 

        public string Sifrele()
        {
            sbox_olusumu();

            int i = 0, j = 0, k = 0;
            StringBuilder sb = new StringBuilder();
            for (int a = 0; a < text.Length; a++)
            {
                i = (i + 1) % N;
                j = (j + sbox[i]) % N;
                int temp = sbox[i];
                sbox[i] = sbox[j];
                sbox[j] = temp;

                k = sbox[(sbox[i] + sbox[j]) % N];
                int islev_sonuc = ((int)text[a]) ^ k;  
                sb.Append(Convert.ToChar(islev_sonuc));
            }
            return sb.ToString();
        }

        public static string StrToHexStr(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                int v = Convert.ToInt32(str[i]);
                sb.Append(string.Format("{0:X2}", v));
            }
            return sb.ToString();
        }

        public static string HexStrToStr(string hexStr)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hexStr.Length; i += 2)
            {
                int n = Convert.ToInt32(hexStr.Substring(i, 2), 16);
                sb.Append(Convert.ToChar(n));
            }
            return sb.ToString();
        }

        private void sbox_olusumu()
        {
            sbox = new int[N];
            int[] yeni_anahtar = new int[N];
            int n = anahtar.Length;
            for (int a = 0; a < N; a++)
            {
                yeni_anahtar[a] = (int)anahtar[a % n];
                sbox[a] = a;
            }

            int b = 0;
            for (int a = 0; a < N; a++)
            {
                b = (b + sbox[a] + yeni_anahtar[a]) % N;
                int temp = sbox[a];
                sbox[a] = sbox[b];
                sbox[b] = temp;
            }
        }
    }
}
