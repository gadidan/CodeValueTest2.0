using System;
using System.Collections.Generic;
using System.Text;

namespace CodeValueTest2
{
    interface ICodeValueCipher
    {
        string Encrypt(string data);
        string Decrypt(string data);

    }
}
