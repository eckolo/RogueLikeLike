using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

/// <summary>
/// 暗号化クラス
/// </summary>
public static class CryptManager
{
    const int BLOCK_SIZE = 128;
    const int KEY_SIZE = 128;
    const string AES_IV = @"dQlBBThPqLvdP5QF";
    const string AES_KEY = @"5xFOj3GMUtzDqbQ9";

    readonly static RijndaelManaged rijndael = new RijndaelManaged()
    {
        BlockSize = BLOCK_SIZE,
        KeySize = KEY_SIZE,
        Padding = PaddingMode.Zeros,
        Mode = CipherMode.CBC,
        Key = Encoding.UTF8.GetBytes(AES_KEY),
        IV = Encoding.UTF8.GetBytes(AES_IV)
    };

    /// <summary>
    /// 文字列を暗号化する
    /// </summary>
    /// <param name="text">平文</param>
    /// <returns>暗号文</returns>
    public static string EncodeCrypt(this string text)
    {
        ICryptoTransform encrypt = rijndael.CreateEncryptor();
        var memoryStream = new MemoryStream();
        var cryptStream = new CryptoStream(memoryStream, encrypt, CryptoStreamMode.Write);

        byte[] text_bytes = Encoding.UTF8.GetBytes(text);

        cryptStream.Write(text_bytes, 0, text_bytes.Length);
        cryptStream.FlushFinalBlock();

        byte[] encrypted = memoryStream.ToArray();

        return Convert.ToBase64String(encrypted);
    }

    /// <summary>
    /// 暗号文を解読する
    /// </summary>
    /// <param name="cryptText">暗号文</param>
    /// <returns>平文</returns>
    public static string DecodeCrypt(this string cryptText)
    {
        ICryptoTransform decryptor = rijndael.CreateDecryptor();

        byte[] encrypted = Convert.FromBase64String(cryptText);
        byte[] planeText = new byte[encrypted.Length];

        var memoryStream = new MemoryStream(encrypted);
        var cryptStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

        cryptStream.Read(planeText, 0, planeText.Length);

        return Encoding.UTF8.GetString(planeText).Replace("\0", "");
    }
}