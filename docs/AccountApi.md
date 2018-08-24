# VisWiz.SDK.Client.AccountApi

All URIs are relative to *https://api.viswiz.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhook**](AccountApi.md#createwebhook) | **POST** /webhooks | Create a new webhook
[**GetAccount**](AccountApi.md#getaccount) | **GET** /account | Get account info
[**GetWebhooks**](AccountApi.md#getwebhooks) | **GET** /webhooks | Get all webhooks


<a name="createwebhook"></a>
# **CreateWebhook**
> WebHook CreateWebhook (Body body)

Create a new webhook

When a build comparison is finished a POST HTTP request will be triggered towards all webhooks configured for the account.  The following query parameters are sent with each request:  - `branch` - `buildID` - `comparisonBranch` - `comparisonBuildID` - `diffImagesCount` - `diffPercentage` - `imagesCount` - `projectID` 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class CreateWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi();
            var body = new Body(); // Body | 

            try
            {
                // Create a new webhook
                WebHook result = apiInstance.CreateWebhook(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.CreateWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)|  | 

### Return type

[**WebHook**](WebHook.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccount"></a>
# **GetAccount**
> Account GetAccount ()

Get account info

Get the current account information 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                // Get account info
                Account result = apiInstance.GetAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Account**](Account.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> InlineResponse2001 GetWebhooks ()

Get all webhooks

Get the list of webhooks configured for the account. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                // Get all webhooks
                InlineResponse2001 result = apiInstance.GetWebhooks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

