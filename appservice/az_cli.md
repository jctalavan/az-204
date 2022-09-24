## AZ CLI 

**az webapp up**

The _az webapp up_ command makes it easy to create and update web apps.

> resourceGroup = nombreGrupoRecursos  
> appName = identificadorWebApp  
> _az webapp up -g $resourceGroup -n $appName --html_

When executed it performs the followingactions:
- Create a default resource group if one isn't specified.
- Create a default app service plan.
- Create an app with the specified name.
- Zip deploy files from the current working directory tothe web app.

*** 

**az webapp list --resource-group RGNAME**

***

**az webapp deployment source config-zip --resource-group RGNAME --src XXX.zip --name WEBAPPNAME**
