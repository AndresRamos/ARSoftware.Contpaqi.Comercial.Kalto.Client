using System.Text;

namespace ARSoftware.Contpaqi.Comercial.Kalto.Client.Common;

public static class Utils
{
    public static string EncodeBasicAuth(string username, string password)
    {
        var bytes = Encoding.UTF8.GetBytes($"{username}:{password}");
        return Convert.ToBase64String(bytes);
    }
}
