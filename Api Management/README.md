# AZURE API MANAGEMENT

API Management provides the core functionality to ensure a successful API program through developer engagement, business insights, analytics, security, and protection. Each API consists of one or more operations, and each API can be added to one or more products. To use an API, developers subscribe to a product that contains that API, and then they can call the API's operation, subject to any usage policies that may be in effect.

The system is made up of the following components:

* The **API gateway** is the endpoint that:
  - Accepts API calls and routes them to your backend(s).
  - Verifies API keys, JWT tokens, certificates, and other credentials.
  - Enforces usage quotas and rate limits.
  - Transforms your API on the fly without code modifications.
  - Caches backend responses where set up.
  - Logs call metadata for analytics purposes.

* The **Azure portal** is the administrative interface where you set up your API program. Use it to:
  - Define or import API schema.
  - Package APIs into products.
  - Set up policies like quotas or transformations on the APIs.
  - Get insights from analytics.
  - Manage users.

* The **Developer portal** serves as the main web presence for developers, where they can:
  - Read API documentation.
  - Try out an API via the interactive console.
  - Create an account and subscribe to get API keys.
  - Access analytics on their own usage.

Exercises:
- [Create a backend API](https://learn.microsoft.com/en-us/training/modules/explore-api-management/8-import-api) 
- [Lab 08](https://microsoftlearning.github.io/AZ-204-DevelopingSolutionsforMicrosoftAzure/Instructions/Labs/AZ-204_lab_08.html) :white_check_mark:


References:
- [Explore Api Management](https://learn.microsoft.com/en-us/training/modules/explore-api-management/)
- [AZ-204: Implement API Management](https://learn.microsoft.com/en-us/training/paths/az-204-implement-api-management/)
- [All modules about APIM on MS Learn...](https://learn.microsoft.com/en-us/training/browse/?terms=api%20management)
