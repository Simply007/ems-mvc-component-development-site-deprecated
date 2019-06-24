# Kentico EMS Component Development Site

This is a ASP.NET MVC web application with the Kentico EMS Page builder functionality turned on. This repository is used as a source for a nuget package that eriches the component project with an MVC app environment for component development.

## :warning: Disclaimer

> This repo is still in development. It is about to be released after the [Kentico 12 Service pack is released](https://www.kentico.com/product/roadmap).

## Get started

1. Download Kentico installation exe file
    * [`Kentico_12_0_trial.exe` Trial](https://www.kentico.com/download-demo/trial-version)
1. Install Kentico using [the command line](https://docs.kentico.com/K12SP/Installing+Kentico+from+the+command+line).
    * Use provided [Kentico installation profile](/KenticoInstallationProfile.xml) template and define `TargetFolder` attribute of th `IIS` tag (:warning: Do not use the same location as the one you have you exe file located)
        * This will install Kentico Administration interface without any site
        * If you wish to adjust the connection to the different database server, [adjust the `SQL` tag in the configuration](https://docs.kentico.com/K12SP/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration)
        * If you wish to add your license to the instance, [adjust the `Licenses` tag in the configuration XML]((https://docs.kentico.com/K12SP/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration))

      ```sh
      .\Kentico_12_0_trial.exe KenticoInstallationProfile.xml
      ```

      > If you get an error about already installed program files run command for uninstalling the current program files and then run the previous command again

      ```sh
      .\Kentico_12_0_trial.exe /u
      ```

1. Apply the latest [hotfix](https://devnet.kentico.com/download/hotfixes) (or at least 12.0.29) (Service Pack)

1. [Download this repository](https://github.com/Simply007/ems-mvc-component-development-site/archive/master.zip) and extract it under the target folder (`TargetFolder`) that was defined in previous step

    > The content should looks like this

    ```plain
    .
    ├── CMS
    ├── WebApp.sln
    ├── Lib
    ├── DevelopmentSite
    ├── DevelopmentSite.sln
    ├── GlobalAssemblyInfo.cs
    ├── README.md
    └── ...
    ```

1. Run the administration instance (already registered in IIS with `_Admin` suffix)  and import [the site export package](/DevelopmentSite.zip) according to the ([documentation](https://docs.kentico.com/K12SP/Importing+a+site+or+objects))
    * This package contains
        * Site (With `Presentation URL`)
        * Page type (configured for page builder - url pattern `/` and use tab  checkbox)
        * Page by this page type
        * Automatic web farms

1. Adjust connection strings + hash string salt from [/CMS/web.config](/CMS/web.config) to [/DevelopmentSite/ConnectionStrings.config] and [/DevelopmentSite/Appsettings.config]

1. Register `Development application` in IIS/IIS Express
    * use `<TargetFolder>/DevelopmentSite` as a `Physical path`
    * you could use the same Application pool as is set f administration application

1. Adjust presentation URL in the administration instance according to the registration from the previous step

1. Build `DevelopmentSite` in Visual Studio

![Analytics](https://kentico-ga-beacon.azurewebsites.net/api/UA-69014260-4/Kentico/ems-mvc-component-development-site?pixel)
