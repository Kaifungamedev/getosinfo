using Xamarin.Essentials;
using System.Runtime.InteropServices;
namespace GetOsinfo
{
    public class Osinfo
    {
        public static bool OSInfo(string os)
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
}