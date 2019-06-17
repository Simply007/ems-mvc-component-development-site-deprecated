# Kentico EMS Component Development Kit

## Get started

1. Clone this repository to the destination folder you whant to have configured from you we server

    ```sh
    git clone https://github.com/Simply007/ems-mvc-component-development-kit
    ```

TODO: define what exe file and its name
1. Download Kentico installation exe file 
    * [Trial](https://www.kentico.com/download-demo/trial-version)
    * [Free](https://www.kentico.com/download-demo/free-cms-for-asp-net)
1. Install Kentico using [the command line](https://docs.kentico.com/k12SP/installation/installing-kentico-from-the-command-line).
    * Use provided [Kentico installation profile](/KenticoInstallationProfile.xml) template and define `TargetFolder` attribute of th `IIS` tag (:!: Do not use the same location as the one you have you exe file located)
        * This will install Kentico Administration interface without any site
        * If you wish to adjust the connection to the different database server [adjust the `SQL` tag in the configuration](https://docs.kentico.com/k12/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration)

      ```sh
      .\Kentico_12_0_not_signed.exe KenticoInstallationProfile.xml
      ```

      > If you get an error about already installed program files run command for unitalling the current program files and then run the previous command again

      ```sh
      .\Kentico_12_0_not_signed.exe /u
      ```

1. [Download this repository](https://github.com/Simply007/ems-mvc-component-development-kit/archive/master.zip) and unzip it under the target folder (`TargetFolder`) that was defined in previous step

    * The content should look like this 

    ```
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

1. Import the package with the site
    * Site (Presenation URL)
    * Page type (configured for page builder - url pattern `/` and use tab checkbox)
    * Page by this page type
    * Automatic web farms


1. Adjust connection string + hash string from [/CMS/web.config](/CMS/web.config) to [/DevelopmentSite/web.config]

1. Build both colutions

