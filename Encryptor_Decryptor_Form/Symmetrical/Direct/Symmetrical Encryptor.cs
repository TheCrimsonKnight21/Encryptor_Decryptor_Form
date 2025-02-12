using System.Text;

namespace EncryptorDecryptor
{
    public class SymmetricEncryptor
    {
        private Queue<char> _messageQueue;
        private string _encryptedMessage;
        private string _key;

        public SymmetricEncryptor(char[] arr)
        {
            _messageQueue = new Queue<char>(arr);
        }

        public string Key => _key;

        public string EncryptedMessage => _encryptedMessage;

        public void EncryptMessage()
        {
            GenerateKey();
            StringBuilder encryptedBuilder = new StringBuilder();

            while (_messageQueue.Count > 0)
            {
                for (int i = 0; i < _key.Length; i += 3)
                {
                    if (_messageQueue.Count == 0)
                        break;

                    char currentChar = _messageQueue.Dequeue();

                    // Preserve spaces without encryption
                    if (currentChar == ' ')
                    {
                        encryptedBuilder.Append(currentChar);
                        continue;
                    }

                    int shiftValue = int.Parse(_key.Substring(i, 3));
                    char encryptedChar = (char)(currentChar + shiftValue);
                    encryptedBuilder.Append(encryptedChar);
                }
            }

            _encryptedMessage = encryptedBuilder.ToString();
        }

        private void GenerateKey()
        {
            Random random = new Random();
            StringBuilder keyBuilder = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                int randomValue = random.Next(97, 127);
                int adjustment = (_messageQueue.Peek() % 2) + i; // Adjust based on the queue's first char
                keyBuilder.Append((randomValue + adjustment).ToString("D3")); // Ensure it’s always 3 digits
            }

            _key = keyBuilder.ToString();
        }
    }
}