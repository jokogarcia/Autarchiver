using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordDictionary
{
    public interface IPasswordDictionary
    {
        void AddNewPass(string newPass);
        string GetNext();
        void Rewind();
    }
}
