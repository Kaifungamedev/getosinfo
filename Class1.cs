using Xamarin.Essentials;
using System.Runtime.InteropServices;
namespace GetOsinfo
{
    public class Osinfo
    {
        public static readonly string Model = DeviceInfo.Model.ToString();

        public static readonly string Manufacturer = DeviceInfo.Manufacturer.ToString();

        public static readonly string DeviceName = DeviceInfo.Name.ToString();

        public static readonly string Version = DeviceInfo.VersionString.ToString();

        public static readonly string Idiom = DeviceInfo.Idiom.ToString();

        public static readonly string DeviceType = DeviceInfo.DeviceType.ToString();

        public static bool GetOSPlatformType(string os)
        {
            var platform = DeviceInfo.Platform;
            if (platform == DevicePlatform.Android && (os == "Android" || os == "Mobile"))
            {
                return true;
            }
            else if (platform == DevicePlatform.iOS && (os == "iOS" || os == "Mobile"))
            {
                return true;
            }
            else if (platform == DevicePlatform.Unknown)
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && (os == "Pc" || os == "Windows"))
                {
                    return true;
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && (os == "Pc" || os == "Linux"))
                {
                    return true;
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && (os == "Pc" || os == "MacOS"))
                {
                    return true;
                }
            }

            return false;
        }
    }
    public class OsTypes
    {
        public const string Android = "Android";
        public const string iOS = "iOS";
        public const string Windows = "Windows";
        public const string Linux = "Linux";
        public const string MacOS = "MacOS";
        public const string Mobile = "Mobile";
        public const string Desktop = "Pc";
    }
    public class OsIdiom
    {
        public const string Phone = "Phone";
        public const string Tablet = "Tablet";
        public const string Desktop = "Desktop";
        public const string TV = "TV";
        public const string Watch = "Watch";
        public const string Unknown = "Unknown";
    }
}