# VisWiz.SDK.Client.ProjectsApi

All URIs are relative to *https://api.viswiz.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProject**](ProjectsApi.md#createproject) | **POST** /projects | Create a project
[**GetProjectNotifications**](ProjectsApi.md#getprojectnotifications) | **GET** /projects/{projectID}/notifications | Get notifications settings
[**GetProjects**](ProjectsApi.md#getprojects) | **GET** /projects | Get all projects
[**UpdateProjectNotifications**](ProjectsApi.md#updateprojectnotifications) | **PUT** /projects/{projectID}/notifications | Update notifications settings


<a name="createproject"></a>
# **CreateProject**
> Project CreateProject (Body1 body)

Create a project

Create a new project for the account. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class CreateProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProjectsApi();
            var body = new Body1(); // Body1 | 

            try
            {
                // Create a project
                Project result = apiInstance.CreateProject(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.CreateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectnotifications"></a>
# **GetProjectNotifications**
> Notifications GetProjectNotifications (string projectID)

Get notifications settings

Get the notifications settings for a project. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class GetProjectNotificationsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProjectsApi();
            var projectID = projectID_example;  // string | The requested project ID

            try
            {
                // Get notifications settings
                Notifications result = apiInstance.GetProjectNotifications(projectID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetProjectNotifications: " + e.Message );
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

[**Notifications**](Notifications.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojects"></a>
# **GetProjects**
> InlineResponse2002 GetProjects ()

Get all projects

Get a list of all the projects for the account. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class GetProjectsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProjectsApi();

            try
            {
                // Get all projects
                InlineResponse2002 result = apiInstance.GetProjects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprojectnotifications"></a>
# **UpdateProjectNotifications**
> Notifications UpdateProjectNotifications (string projectID, Notifications body)

Update notifications settings

Update the notifications settings for a project. All fields are optional. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class UpdateProjectNotificationsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProjectsApi();
            var projectID = projectID_example;  // string | The requested project ID
            var body = new Notifications(); // Notifications | 

            try
            {
                // Update notifications settings
                Notifications result = apiInstance.UpdateProjectNotifications(projectID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.UpdateProjectNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| The requested project ID | 
 **body** | [**Notifications**](Notifications.md)|  | 

### Return type

[**Notifications**](Notifications.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

