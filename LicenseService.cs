using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace FileFinder;

static class LicenseService
{
    // ВАЖНО: замени на свою секретную фразу перед публикацией и никому не раскрывай!
    internal const string Secret = "Bn$0ftW4r3-F!l3F1nd3r-2026-S3cr3tK3y#9xQZ";

    private const string RegPath  = @"Software\BNSoftware\FileFinder";
    private const string RegEmail = "LicenseEmail";
    private const string RegKey   = "LicenseKey";

    public static LicenseInfo? Current { get; private set; }

    public static void Initialize() => Current = Load();

    private static LicenseInfo? Load()
    {
        using var reg = Registry.CurrentUser.OpenSubKey(RegPath);
        if (reg == null) return null;

        string? email = reg.GetValue(RegEmail) as string;
        string? key   = reg.GetValue(RegKey)   as string;
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(key)) return null;

        return ValidateKey(email, key, out DateTime expiry)
            ? new LicenseInfo(email, key, expiry)
            : null;
    }

    public static bool Activate(string email, string key, out LicenseInfo? info)
    {
        info = null;
        email = email.ToLowerInvariant().Trim();
        key   = key.ToUpperInvariant().Trim();

        if (!ValidateKey(email, key, out DateTime expiry)) return false;

        using var reg = Registry.CurrentUser.CreateSubKey(RegPath);
        reg.SetValue(RegEmail, email);
        reg.SetValue(RegKey,   key);

        info = Current = new LicenseInfo(email, key, expiry);
        return true;
    }

    public static bool ValidateKey(string email, string key, out DateTime expiry)
    {
        expiry = DateTime.MinValue;

        // Формат: BNFF-YYYYMM-XXXX-XXXX
        string[] parts = key.ToUpperInvariant().Trim().Split('-');
        if (parts.Length != 4 || parts[0] != "BNFF") return false;
        if (parts[1].Length != 6)                     return false;
        if (parts[2].Length != 4 || parts[3].Length != 4) return false;

        if (!int.TryParse(parts[1][..4], out int year)  || year  < 2024) return false;
        if (!int.TryParse(parts[1][4..], out int month) || month < 1 || month > 12) return false;

        expiry = new DateTime(year, month, DateTime.DaysInMonth(year, month));

        string expected = ComputeHmac(email.ToLowerInvariant().Trim(), parts[1]);
        return (parts[2] + parts[3]) == expected;
    }

    // Используется в KeyGenerator
    public static string GenerateKey(string email, DateTime expiry)
    {
        string expiryStr = expiry.ToString("yyyyMM");
        string hmac = ComputeHmac(email.ToLowerInvariant().Trim(), expiryStr);
        return $"BNFF-{expiryStr}-{hmac[..4]}-{hmac[4..8]}";
    }

    private static string ComputeHmac(string email, string expiryStr)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(Secret);
        byte[] msgBytes = Encoding.UTF8.GetBytes(email + "|" + expiryStr);
        using var hmac  = new HMACSHA256(keyBytes);
        return Convert.ToHexString(hmac.ComputeHash(msgBytes))[..8].ToUpperInvariant();
    }
}

public record LicenseInfo(string Email, string Key, DateTime Expiry)
{
    public bool IsActive => DateTime.Today <= Expiry;
}
