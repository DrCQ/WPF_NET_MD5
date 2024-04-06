# WPF_NET_MD5
The WPF_NET_MD5 repositiory contains an WPF **Template Application** for NET 8.0, based on MDIX ([MaterialDesingInXAML](http://materialdesigninxaml.net/)) Themens (V 5.0) and Colors (V 3.0). This Application is using the Community Toolkit 8.2 and the MS Dependency Injection to realize MVVM patterns. The application code is written in VB.NET.

### *Dark* mode example
<img width="475" alt="main-view-dark" src="https://github.com/DrCQ/WPF_NET_MD5/assets/49019093/82d1dd26-2363-4755-ac76-679f5d408d6e">

### *Light* mode example

<img width="472" alt="main-view-light" src="https://github.com/DrCQ/WPF_NET_MD5/assets/49019093/7da39fd5-ea6d-46d3-9545-a6381a51256d">

## Layout
The `MainWindow` contains following elements:
1. Application's toolbar with the main `Menu` and `Window` buttons
2. Application's Title with `Popup` control to switch between the *Dark* and *Light* mode
3. Working area - reserved for the final application
4. Application's `StatusBar` with Notfication's overview

## Functionality
The **Template Application** provides following functions:
1. IAppDataService `interface` and ApplicationDataService `class` used for the dependency injection
2. AppNotification `class` used for notifications (error, warning or info)
3. NotificationMessage `class` based on Community Toolkit to send AppNotification's
4. Helper classes supporting the XAML development (like *CommandItemAssist*)
5. Converter classes (like *Boolean2Visibility*, *Counter2Visibility* etc.)
6. About dialog and Notifications dialog

## Dialog example
<img width="583" alt="about-dialog" src="https://github.com/DrCQ/WPF_NET_MD5/assets/49019093/75074a14-08fa-406e-b6de-4e3de3a5638a">
