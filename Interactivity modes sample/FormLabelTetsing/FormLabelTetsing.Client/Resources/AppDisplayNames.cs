using System.Globalization;
using System.Resources;

namespace FormLabelTetsing.Client.Resources;

public static class AppDisplayNames
{
    private static readonly ResourceManager ResourceManager = new(
        "FormLabelTetsing.Client.Resources.AppDisplayNames",
        typeof(AppDisplayNames).Assembly);

    public static string FullName => GetString(nameof(FullName));

    public static string PhoneNumber => GetString(nameof(PhoneNumber));

    private static string GetString(string name) =>
        ResourceManager.GetString(name, CultureInfo.CurrentUICulture) ?? name;
}
