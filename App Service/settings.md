## Application settings

In App Service, app settings are variables passed as environment variables to the application code. For Linux apps and custom containers, App Service passes app settings to the container using the --env flag to set the environment variable in the container.

For ASP.NET and ASP.NET Core developers, setting app settings in App Service are like setting them in <appSettings> in Web.config or appsettings.json, but the values in App Service override the ones in Web.config or appsettings.json. You can keep development settings (for example, local MySQL password) in Web.config or appsettings.json, but production secrets (for example, Azure MySQL database password) safe in App Service. The same code uses your development settings when you debug locally, and it uses your production secrets when deployed to Azure.

App settings are always encrypted when stored (encrypted-at-rest).

## General settings

In the **Configuration > General** settings section you can configure some common settings for your app. _Some settings require you to scale up to higher pricing tiers_.

Below is a list of the currently available settings:

-**Stack settings**: The software stack to run the app, including the language and SDK versions. For Linux apps and custom container apps, you can also set an optional start-up command or file.

Establishing the stack settings which includes the programming language.

-**Platform settings**: Lets you configure settings for the hosting platform, including:

-**Bitness**: 32-bit or 64-bit.

-**WebSocket protocol**: For ASP.NET SignalR or socket.io, for example.

-**Always On**: Keep the app loaded even when there's no traffic. By default, Always On is not enabled and the app is unloaded after 20 minutes without any incoming requests. It's required for continuous WebJobs or for WebJobs that are triggered using a CRON expression.

-**Managed pipeline version**: The IIS pipeline mode. Set it to Classic if you have a legacy app that requires an older version of IIS.

-**HTTP version**: Set to 2.0 to enable support for HTTPS/2 protocol.

-**ARR affinity**: In a multi-instance deployment, ensure that the client is routed to the same instance for the life of the session. You can set this option to Off for stateless applications.

-**Debugging**: Enable remote debugging for ASP.NET, ASP.NET Core, or Node.js apps. This option turns off automatically after 48 hours.

-**Incoming client certificates**: require client certificates in mutual authentication. TLS mutual authentication is used to restrict access to your app by enabling different types of authentication for it.