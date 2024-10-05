using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;
using System.Text;

public static class SecureHelp
{
    public static string Hash(string data)
    {
        byte[] textToByter = Encoding.UTF8.GetBytes(data);
        SHA256Managed mySHA256 = new SHA256Managed();

        byte[] hashValue = mySHA256.ComputeHash(textToByter);

        return GetHexStringFromHash(hashValue);
    }

    private static string GetHexStringFromHash(byte[] hash)
    {
        string hexstring = string.Empty;

        foreach(byte b in hash)
        {
            hexstring += b.ToString("x2");
        }
        return hexstring; 
    }
}
