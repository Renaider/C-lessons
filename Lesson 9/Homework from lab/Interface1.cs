using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    interface ICipher
    {
        string Encode(string text);
        string Decode(string text);
    }
}
