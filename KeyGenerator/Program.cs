using System.Security.Cryptography;
using System.Text;

// ВАЖНО: должен совпадать с LicenseService.Secret в основном проекте!
const string Secret = "Bn$0ftW4r3-F!l3F1nd3r-2026-S3cr3tK3y#9xQZ";

Console.WriteLine("=== FileFinder Key Generator ===");
Console.WriteLine();

while (true)
{
    Console.Write("E-mail покупателя (или Enter для выхода): ");
    string? email = Console.ReadLine()?.Trim().ToLowerInvariant();
    if (string.IsNullOrEmpty(email)) break;

    Console.Write("Срок действия в месяцах [12]: ");
    string? monthsInput = Console.ReadLine()?.Trim();
    int months = string.IsNullOrEmpty(monthsInput) ? 12 : int.Parse(monthsInput);

    DateTime expiry = DateTime.Today.AddMonths(months);
    expiry = new DateTime(expiry.Year, expiry.Month, DateTime.DaysInMonth(expiry.Year, expiry.Month));

    string expiryStr = expiry.ToString("yyyyMM");
    byte[] keyBytes  = Encoding.UTF8.GetBytes(Secret);
    byte[] msgBytes  = Encoding.UTF8.GetBytes(email + "|" + expiryStr);
    using var hmac   = new HMACSHA256(keyBytes);
    string hash      = Convert.ToHexString(hmac.ComputeHash(msgBytes))[..8].ToUpperInvariant();
    string licenseKey = $"BNFF-{expiryStr}-{hash[..4]}-{hash[4..8]}";

    Console.WriteLine();
    Console.WriteLine($"  Ключ:         {licenseKey}");
    Console.WriteLine($"  Действует до: {expiry:dd.MM.yyyy}");
    Console.WriteLine();
}
