> 🟡 **Project status**: maintenance mode<sup>[[?]](https://github.com/Kaifungamedev/.github/blob/main/docs/repo-status.md)</sup>
# getosinfo
getosinfo is a simple libary that you can use to get a device's os informaion (platform, manufacturer, name .etc)

## DOCS
### getting basic info
Add a reference to GetOsinfo in your class:
`using GetOsinfo;`
```
// Device Model (SMG-950U, iPhone12)
var device = Osinfo.Model;

// Manufacturer (Samsung)
var manufacturer = Osinfo.Manufacturer;

// Device Name (Jon's iPhone)
var deviceName = Osinfo.Name;

// Operating System Version Number (12.0)
var version = Osinfo.Version;

// Platform (Android)
var platform = Osinfo.Platform;

// Idiom (Phone)
var idiom = Osinfo.Idiom;

// Device Type (Physical)
var deviceType = Osinfo.DeviceType;
```
### getting os type (Desktop or Mobile)
simply use `Osinfo.GetOSPlatformType(OsTypes.Desktop)`  
you can also check for specific platforms with these:
```
OsTypes.Android;
OsTypes.iOS;
OsTypes.Windows;
OsTypes.Linux;
OsTypes.MacOS;
OsTypes.Mobile;
OsTypes.Desktop;
```
### Idiom
OsIdiom.Idiom correlates a constant string that maps to the type of device the application is running on. The values can be checked with the OsIdiom struct:
```
    OsIdiom.Phone – Phone
    OsIdiom.Tablet – Tablet
    OsIdiom.Desktop – Desktop
    OsIdiom.TV – TV
    OsIdiom.Watch – Watch
    OsIdiom.Unknown – Unknown
```
### Device Type
Osinfo.DeviceType correlates an enumeration to determine if the application is running on a physical or virtual device. A virtual device is a simulator or emulator.
