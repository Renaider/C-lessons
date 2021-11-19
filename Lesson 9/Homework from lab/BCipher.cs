using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class BCipher : ICipher
    {
        const string alf = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string full_alf = alf.ToLower();
        int k;
        string ICipher.Encode(string text)
        {
            var alf_len = full_alf.Length;
            var cipher = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = full_alf.IndexOf(c);
                if (text[i].Equals('г'))
                {
                    k = 1;
                }
                else
                {
                    k = alf_len - 2 * index;
                }
                if (index < 0)
                {
                    cipher += c.ToString();
                }
                else
                {
                    var codeIndex = (alf_len + index + k - 1) % alf_len;
                    cipher += full_alf[codeIndex];
                }
            }
            return cipher;
        }
        string ICipher.Decode(string text)
        {
            var alf_len = full_alf.Length;
            var cipher = "";
            for (int i = 0; i < text.Length; i++)
            {
                k = 0;
                var c = text[i];
                var index = full_alf.IndexOf(c);
                if (text[i].Equals('г'))
                {
                    k = 1;
                }
                else
                {
                    k = alf_len - 2 * index;
                }
                if (index > 0)
                {
                    cipher += c.ToString();
                }
                else
                {
                    var codeIndex = (alf_len + index - k) % alf_len;
                    cipher += full_alf[codeIndex];
                }
            }
            return cipher;
        }
    }
}