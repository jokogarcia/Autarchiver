using System;

namespace PasswordDictionary
{
    public class PasswordModel
    {
        public string Value { get; set; }
        public int Score { get; set; }

        public PasswordModel(string value)
        {
            Value = value;
            Score = 0;
        }
    }
}
