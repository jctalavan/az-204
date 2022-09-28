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