# Kentico EMS Component Development Kit

## Get started

**TODO: define what exe file and its name**

1. Download Kentico installation exe file
    * [`Kentico_12_0_trial.exe` Trial](https://www.kentico.com/download-demo/trial-version)
1. Install Kentico using [the command line](https://docs.kentico.com/K12SP/Installing+Kentico+from+the+command+line).
    * Use provided [Kentico installation profile](/KenticoInstallationProfile.xml) template and define `TargetFolder` attribute of th `IIS` tag (:!: Do not use the same location as the one you have you exe file located)
        * This will install Kentico Administration interface without any site
        * If you wish to adjust the connection to the different database server, [adjust the `SQL` tag in the configuration](https://docs.kentico.com/K12SP/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration)
        * If you wish to add your license to the instance, [adjust the `Licenses` tag in the configuration XML]((https://docs.kentico.com/K12SP/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration))

      ```sh
      .\Kentico_12_0_not_signed.exe KenticoInstallationProfile.xml
      ```

      > If you get an error about already installed program files run command for uninstalling the current program files and then run the previous command again

      ```sh
      .\Kentico_12_0_not_signed.exe /u
      ```

1. [Download this repository](https://github.com/Simply007/ems-mvc-component-development-kit/archive/master.zip) and extract it under the target folder (`TargetFolder`) that was defined in previous step

    > The content should look like this

    ```plain
    .
    ├── CMS
    ├── DevelopmentSite
    ├── DevelopmentSite.sln
    ├── GlobalAssemblyInfo.cs
    ├── Lib
    ├── README.md
    ├── WebApp.sln
    └── ...
    ```

1. Import [the site export package](/DevelopmentSite.zip) according to the ([documentation](https://docs.kentico.com/display/K12SP/Importing+a+site+or+objects))
    * This package contains
        * Site (With `Presentation URL`)
        * Page type (configured for page builder - url pattern `/` and use tab  checkbox)
        * Page by this page type
        * Automatic web farms

1. Adjust connection strings + hash string from [/CMS/web.config](/CMS/web.config) to [/DevelopmentSite/web.config]

1. Register `Development application` in IIS/IIS Express
    * use `<TargetFolder>/DevelopmentSite` as a `Physical path`
    * you could use the same Application pool as is set f administration application

1. Adjust presentation URL in the administration instance

1. Build `DevelopmentSite`
