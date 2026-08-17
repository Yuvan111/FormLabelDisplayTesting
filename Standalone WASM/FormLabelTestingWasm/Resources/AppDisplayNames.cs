using System.Globalization;
using System.Resources;

namespace FormLabelTestingWasm.Resources;

public static class AppDisplayNames
{
    private static readonly ResourceManager ResourceManager =
        new("FormLabelTestingWasm.Resources.AppDisplayNames", typeof(AppDisplayNames).Assembly);

    public static string LocalizationTest => GetString(nameof(LocalizationTest));
    public static string CurrentCulture => GetString(nameof(CurrentCulture));
    public static string DirectResourceOutput => GetString(nameof(DirectResourceOutput));
    public static string DisplayNameOutput => GetString(nameof(DisplayNameOutput));
    public static string DisplayPrecedence => GetString(nameof(DisplayPrecedence));
    public static string FullName => GetString(nameof(FullName));
    public static string PhoneNumber => GetString(nameof(PhoneNumber));
    public static string Validate => GetString(nameof(Validate));
    public static string RequiredMessage => GetString(nameof(RequiredMessage));
    public static string PhoneFormatMessage => GetString(nameof(PhoneFormatMessage));

    private static string GetString(string name) =>
        ResourceManager.GetString(name, CultureInfo.CurrentUICulture) ?? name;
}