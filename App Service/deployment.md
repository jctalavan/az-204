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