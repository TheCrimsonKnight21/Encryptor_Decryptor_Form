using System;
using System.IO;

namespace Encryptor_Decryptor
{
    public class FileDecryptor
    {
        public void DecryptFile(string path, string key)
        {
            if (string.IsNullOrEmpty(path) || string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Path and key must not be null or empty.");
            }

            if (key.Length < 3)
            {
                throw new ArgumentException("Key must be at least 3 characters long.");
            }

            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
                {
                    byte[] buffer = new byte[8192]; // Read in chunks
                    int bytesRead;
                    int keyIndex = 0;

                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        for (int i = 0; i < bytesRead; i++)
                        {
                            // Use the key cyclically
                            int keyValue = int.Parse(key.Substring(keyIndex, 3));
                            buffer[i] ^= (byte)keyValue;

                            keyIndex = (keyIndex + 3) % key.Length; // Cycle through the key
                        }

                        // Seek back to the beginning of the current read
                        fileStream.Seek(-bytesRead, SeekOrigin.Current);
                        fileStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}