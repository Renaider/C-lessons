using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class ACipher : ICipher
    {
        const string alf = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        const int k = 1;
        string ICipher.Encode(string text)
        {
            var full_alf = alf + alf.ToLower();
            var afl_len = full_alf.Length;
            var cipher = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = full_alf.IndexOf(c);
                if (index < 0)
                {
                    cipher += c.ToString();
                }
                else
                {
                    var codeIndex = (afl_len + index + k) % afl_len;
                    cipher += full_alf[codeIndex];
                }
            }
            return cipher;
        }
        string ICipher.Decode(string text)
        {
            var full_alf = alf + alf.ToLower();
            var afl_len = full_alf.Length;
            var cipher = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = full_alf.IndexOf(c);
                if (index < 0)
                {
                    cipher += c.ToString();
                }
                else
                {
                    var codeIndex = (afl_len + index - k) % afl_len;
                    cipher += full_alf[codeIndex];
                }
            }
            return cipher;
        }
    }
}
