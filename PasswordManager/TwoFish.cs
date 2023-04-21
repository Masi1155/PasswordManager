using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.IO;
using System.Security.Cryptography;

public static class Twofish
{
    public static byte[] Encrypt(byte[] key, byte[] iv, byte[] data)
    {
        // Create Twofish cipher
        TwofishEngine engine = new TwofishEngine();
        CbcBlockCipher cipher = new CbcBlockCipher(engine);

        // Create key and IV parameters
        KeyParameter keyParam = new KeyParameter(key);
        ParametersWithIV keyParamWithIV = new ParametersWithIV(keyParam, iv);

        // Initialize cipher for encryption
        cipher.Init(true, keyParamWithIV);

        // Create buffer for encrypted data
        byte[] encrypted = new byte[cipher.GetOutputSize(data.Length)];

        // Encrypt data
        int len = cipher.ProcessBytes(data, 0, data.Length, encrypted, 0);
        cipher.DoFinal(encrypted, len);

        return encrypted;
    }

    public static byte[] Decrypt(byte[] key, byte[] iv, byte[] encryptedData)
    {
        // Create Twofish cipher
        TwofishEngine engine = new TwofishEngine();
        CbcBlockCipher cipher = new CbcBlockCipher(engine);

        // Create key and IV parameters
        KeyParameter keyParam = new KeyParameter(key);
        ParametersWithIV keyParamWithIV = new ParametersWithIV(keyParam, iv);

        // Initialize cipher for decryption
        cipher.Init(false, keyParamWithIV);

        // Create buffer for decrypted data
        byte[] decrypted = new byte[cipher.GetOutputSize(encryptedData.Length)];

        // Decrypt data
        int len = cipher.ProcessBytes(encryptedData, 0, encryptedData.Length, decrypted, 0);
        cipher.DoFinal(decrypted, len);

        return decrypted;
    }

    public static void Main()
    {
        byte[] key = new byte[32]; // 256-bit key
        byte[] iv = new byte[16]; // 128-bit IV
        byte[] data = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05 }; // Data to encrypt

        // Generate random key and IV
        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(key);
            rng.GetBytes(iv);
        }

        // Encrypt data
        byte[] encrypted = Encrypt(key, iv, data);

        // Decrypt data
        byte[] decrypted = Decrypt(key, iv, encrypted);

        // Verify that decrypted data matches original data
        bool success = true;
        for (int i = 0; i < data.Length; i++)
        {
            if (decrypted[i] != data[i])
            {
                success = false;
                break;
            }
        }

        Console.WriteLine("Encryption and decryption successful: " + success);
    }
}
