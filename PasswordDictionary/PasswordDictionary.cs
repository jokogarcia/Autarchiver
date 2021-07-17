using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordDictionary
{
    public class PasswordDictionary : IPasswordDictionary
    {
        private List<PasswordModel> _passwords;
        private int index=0;
        private string pathToArchive;
        public void AddNewPass(string newPass)
        {
            var inList = _passwords.Find(x => x.Value.Equals(newPass));
            if(inList != null)
            {
                inList.Score++;
            }
            else
            {
                _passwords.Add(new PasswordModel(newPass));
            }
            SaveToDisk();
        }

        private void SaveToDisk()
        {
            throw new NotImplementedException();
        }

        public string GetNext()
        {
            try
            {
                return _passwords[index++].Value;
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }

        public void Rewind()
        {
            index = 0;
        }
    }
}
