# VisWiz.SDK.Client.BuildsApi

All URIs are relative to *https://api.viswiz.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBuild**](BuildsApi.md#createbuild) | **POST** /projects/{projectID}/builds | Create a build
[**FinishBuild**](BuildsApi.md#finishbuild) | **POST** /builds/{buildID}/finish | Finish a build
[**GetBuildResults**](BuildsApi.md#getbuildresults) | **GET** /builds/{buildID}/results | Get results for a build
[**GetBuilds**](BuildsApi.md#getbuilds) | **GET** /projects/{projectID}/builds | Get builds for a project


<a name="createbuild"></a>
# **CreateBuild**
> Build CreateBuild (string projectID, Body2 body)

Create a build

Create a new build for a project. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class CreateBuildExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BuildsApi();
            var projectID = projectID_example;  // string | The requested project ID
            var body = new Body2(); // Body2 | 

            try
            {
                // Create a build
                Build result = apiInstance.CreateBuild(projectID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildsApi.CreateBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| The requested project ID | 
 **body** | [**Body2**](Body2.md)|  | 

### Return type

[**Build**](Build.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finishbuild"></a>
# **FinishBuild**
> void FinishBuild (string buildID)

Finish a build

Finish a build when all images have been created. This triggers the actual build comparison to execute. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class FinishBuildExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BuildsApi();
            var buildID = buildID_example;  // string | The requested build ID

            try
            {
                // Finish a build
                apiInstance.FinishBuild(buildID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildsApi.FinishBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildID** | **string**| The requested build ID | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildresults"></a>
# **GetBuildResults**
> BuildResults GetBuildResults (string buildID)

Get results for a build

Get the results for a build which has been compared to another build. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class GetBuildResultsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BuildsApi();
            var buildID = buildID_example;  // string | The requested build ID

            try
            {
                // Get results for a build
                BuildResults result = apiInstance.GetBuildResults(buildID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildsApi.GetBuildResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildID** | **string**| The requested build ID | 

### Return type

[**BuildResults**](BuildResults.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuilds"></a>
# **GetBuilds**
> Builds GetBuilds (string projectID)

Get builds for a project

Get a list of all the builds for a project. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class GetBuildsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BuildsApi();
            var projectID = projectID_example;  // string | The requested project ID

            try
            {
                // Get builds for a project
                Builds result = apiInstance.GetBuilds(projectID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildsApi.GetBuilds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| The requested project ID | 

### Return type

[**Builds**](Builds.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

