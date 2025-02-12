using System.Text;

namespace Encryptor_Decryptor
{
    public class SymmetricalDecryptor
    {
        private const int KeySegmentLength = 3; // Length of the key segments
        private string _key;
        private Queue<char> _encryptedCharacters = new();
        private string _decryptedMessage;

        public SymmetricalDecryptor(string key, char[] encrypted)
        {
            _key = key;
            foreach (char c in encrypted)
            {
                _encryptedCharacters.Enqueue(c);
            }
        }

        public string DecryptedMessage => _decryptedMessage;

        public void Decrypt()
        {
            StringBuilder decryptedStringBuilder = new StringBuilder();
            int keyLength = _key.Length;

            while (_encryptedCharacters.Count > 0)
            {
                for (int i = 0; i < keyLength; i += KeySegmentLength)
                {
                    if (_encryptedCharacters.Count == 0)
                        break;

                    char currentChar = _encryptedCharacters.Dequeue();

                    // Preserve spaces
                    if (currentChar == ' ')
                    {
                        decryptedStringBuilder.Append(currentChar);
                        continue;
                    }

                    int keySegment = int.Parse(_key.Substring(i, KeySegmentLength));
                    char decryptedChar = Convert.ToChar(currentChar - keySegment);
                    decryptedStringBuilder.Append(decryptedChar);
                }
            }
            _decryptedMessage = decryptedStringBuilder.ToString();
        }
    }
}