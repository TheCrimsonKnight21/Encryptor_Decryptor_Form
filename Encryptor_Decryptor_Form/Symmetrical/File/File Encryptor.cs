﻿using System.Text;

namespace Encryptor_Decryptor
{
    public class FileEncryptor
    {
        private string key;

        public string Key => key;

        public void EncryptFile(string path)
        {
            GenerateKey();
            int n = 0;
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                byte[] buffer = new byte[fileStream.Length];

                fileStream.Read(buffer, 0, buffer.Length);
                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] = (byte)(buffer[i] ^ int.Parse(key.Substring(n, 3)));
                    n += 3;
                    if (n == 15)
                        n = 0;
                }
                fileStream.Seek(0, SeekOrigin.Begin);
                fileStream.Write(buffer, 0, buffer.Length);
                fileStream.Close();
            }
        }

        private void GenerateKey()
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                int r = random.Next(97, 127);

                sb.Append(r);
            }
            key = sb.ToString();
        }
    }
}