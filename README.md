# AZURE APP SERVICE

All of these information are taken from the [AZ-204: Create Azure App Service web apps](https://learn.microsoft.com/en-us/training/paths/create-azure-app-service-web-apps/) learning path of Microsoft Learn.

## The goal of the service.

Azure App Service is an HTTP-based service for hosting web applications, REST APIs, and mobile back ends. You can develop in your favorite programming language, be it .NET, .NET Core, Java, Ruby, Node.js, PHP, or Python. Applications run and scale with ease on both Windows and Linux-based environments.

## App Service Plan.

In App Service, an app (Web Apps, API Apps, or Mobile Apps) always runs in an *App Service plan*. An App Service plan defines a set of compute resources for a web app to run. One or more apps can be configured to run on the same computing resources (or in the same App Service plan).

When you create an App Service plan in a certain region, a set of compute resources is created for that plan in that region. Whatever apps you put into this App Service plan run on these compute resources as defined by your App Service plan. Each App Service plan defines:

- Region (West US, East US, etc.)
- Number of VM instances
- Size of VM instances (Small, Medium, Large)
- Pricing tier (Free, Shared, Basic, Standard, Premium, PremiumV2, PremiumV3, Isolated)

The _pricing tier_ of an App Service plan determines what App Service features you get and how much you pay for the plan. There are a few categories of pricing tiers:

- **Shared compute**: Both Free and Shared share the resource pools of your apps with the apps of other customers. These tiers allocate CPU quotas to each app that runs on the shared resources, and the resources can't scale out.
- **Dedicated compute**: The Basic, Standard, Premium, PremiumV2, and PremiumV3 tiers run apps on dedicated Azure VMs. Only apps in the same App Service plan share the same compute resources. The higher the tier, the more VM instances are available to you for scale-out.
- **Isolated**: This tier runs dedicated Azure VMs on dedicated Azure Virtual Networks. It provides network isolation on top of compute isolation to your apps. It provides the maximum scale-out capabilities.
- **Consumption**: This tier is only available to function apps. It scales the functions dynamically depending on workload.

> **Warning**
> App Service Free and Shared (preview) hosting plans are base tiers that run on the same Azure virtual machines as other App Service apps. Some apps might belong to other customers. These tiers are intended to be used only for development and testing purposes.

## Authentication and authorization in App Service.

App Service provides built-in authentication and authorization support, so you can sign in users and access data by writing minimal or no code in your web app, API, and mobile back end, and also Azure Functions. This feature can save you time and effort by providing out-of-the-box authentication with federated identity providers, like Azure AD, Facebook, Google or Twitter, allowing you to focus on the rest of your application.

However, you're not required to use App Service for authentication and authorization. Many web frameworks are bundled with security features, and you can use them if you like. If you need more flexibility than App Service provides, you can also write your own utilities.

> **Note**
> For a better understanding of [how the authentication flow works](https://learn.microsoft.com/en-us/training/modules/introduction-to-azure-app-service/5-authentication-authorization-app-service).

## Networking features

By default, apps hosted in App Service are accessible directly through the internet and can reach only internet-hosted endpoints. But for many applications, you need to control the inbound and outbound network traffic.

There are two main deployment types for Azure App Service. The **multitenant public service hosts App Service plans** in the Free, Shared, Basic, Standard, Premium, PremiumV2, and PremiumV3 pricing SKUs. There is also the **single-tenant App Service Environment (ASE) hosts Isolated SKU App Service plans** directly in your Azure virtual network.

### Multi-tenant App Service networking features.

Because there are many different customers in the same App Service scale unit, you can't connect the App Service network directly to your network.

Instead of connecting the networks, you need features to handle the various aspects of application communication. The features that handle requests to your app can't be used to solve problems when you're making calls from your app. Likewise, the features that solve problems for calls from your app can't be used to solve problems to your app.

| **Inbound features** | **Outbound features** | 
| ------------- | ------------- |
| App-assigned address | Hybrid Connections | 
| Access restrictions	| Gateway-required virtual network integration | 
| Service endpoints	| Virtual network integration | 
| Private endpoints	| | 

## Scale apps in Azure App Service

## Deploy to App Service

App Service supports both automated and manual deployment.

### Automated deployment

Automated deployment, or continuous integration, is a process used to push out new features and bug fixes in a fast and repetitive pattern with minimal impact on end users.

Azure supports automated deployment directly from several sources like Azure Devops, Github or Bitbucket.

### Manual deployment

There are a few options that you can use to manually push your code to Azure:

- *Git*: App Service web apps feature a Git URL that you can add as a remote repository. Pushing to the remote repository will deploy your app.
- *CLI*: webapp up is a feature of the az command-line interface that packages your app and deploys it. Unlike other deployment methods, az webapp up can create a new App Service web app for you if you haven't already created one.
- *Zip deploy*: Use curl or a similar HTTP utility to send a ZIP of your application files to App Service.
- *FTP/S*: FTP or FTPS is a traditional way of pushing your code to many hosting environments, including App Service.

### Deployment slots

When using a Standard App Service Plan tier or better, you can deploy your app to a staging environment and then swap your staging and production slots. The swap operation warms up the necessary worker instances to match your production scale, thus eliminating downtime.

## AZ CLI 
>
> resourceGroup = nombreGrupoRecursos
>
> appName = identificadorWebApp
>
> _az webapp up -g $resourceGroup -n $appName --html_
>
> The _az webapp up_ command makes it easy to create and update web apps. When executed it performs the following actions:
>
> - Create a default resource group if one isn't specified.
> - Create a default app service plan.
> - Create an app with the specified name.
> - Zip deploy files from the current working directory to the web app.





# FUNCTIONS
- Qué son. Comparativa con Logic Apps y WebJobs
- Opciones de hospedaje
- Código: ¿cómo crear e implementar Azure Functions?
- Durable Functions

# BLOB STORAGE
- Explicación del servicio.
- Ciclo de vida de un archivo dentro de Blob storage (tiers: hot, cool, archive)
- Código

# COSMOS DB
- Explicación del servicio.
- APIs admitidas
- Niveles de consistencia.
- Niveles de servicio: DTU
- Particiones. ¿Cómo elegir una partición adecuada? Otro tipo de particiones.
- Código

# SOLUCIONES IAS (Infraestructura como servicio)

## Aprovisionamiento de máquinas virtuales.
- Explicación del servicio.
- Opciones de disponibilidad.
- Determinación del tamaño correcto

## Creación e implementación de plantillas de Azure Resource Manager (ARM)
- Explicación del servicio.
- Explicación distintos modos de implementación.
- Implementación condicional.

## Contenedores: Azure Container Registry
- Explicación del servicio.
- Tiers.
- Exploración de la estructura de un Dockerfile

## Contenedores: Azure Container Instances.
- Explicación del servicio.

# AUTENTICACIÓN Y AUTORIZACIÓN DE LOS USUARIOS 

## Plataforma de identidad de Microsoft

## Autenticación mediante la biblioteca de autenticación de Microsoft

## Implementación de firmas de acceso compartido.

## Microsoft Graph

# IMPLEMENTACIÓN DE SOLUCIONES EN LA NUBE SEGURAS

## Azure Key Vault

## Identidades administradas

## Azure App Configuration

- Explicación del servicio.
- Application Features.

# API MANAGEMENT

- Explicación del servicio

# DESARROLLO DE SOLUCIONES BASADAS EN EVENTOS

## Azure Event Grid

## Azure Event Hub

# DESARROLLO DE SOLUCIONES BASADAS EN MENSAJES

## Service Bus

[Product](https://azure.microsoft.com/en-us/products/service-bus/)

[Documentación](https://learn.microsoft.com/en-us/azure/service-bus-messaging/)

[Lab](https://microsoftlearning.github.io/AZ-204-DevelopingSolutionsforMicrosoftAzure/Instructions/Labs/AZ-204_lab_10.html) :white_check_mark:

Explicación de algunos conceptos avanzados de la capa Premium:

https://www.youtube.com/watch?v=Gd3Oas8JToU&t=914s

# INSTRUMENTACIÓN DE SOLUCIONES PARA ADMITIR LA SUPERVISIÓN Y EL REGISTRO

# INTEGRACIÓN DEL ALMACENAMIENTO EN CACHÉ Y ENTREGA DE CONTENIDO DENTRO DE SOLUCIONES.

***

# LABS

https://microsoftlearning.github.io/AZ-204-DevelopingSolutionsforMicrosoftAzure/
