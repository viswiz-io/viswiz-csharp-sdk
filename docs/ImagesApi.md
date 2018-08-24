# VisWiz.SDK.Client.ImagesApi

All URIs are relative to *https://api.viswiz.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateImage**](ImagesApi.md#createimage) | **POST** /builds/{buildID}/images | Create an image
[**GetImages**](ImagesApi.md#getimages) | **GET** /builds/{buildID}/images | Get images for a build


<a name="createimage"></a>
# **CreateImage**
> Image CreateImage (string buildID, string name, System.IO.Stream image)

Create an image

Upload a new image for a build. This endpoint accepts only one PNG image per request.  This request requires a `Content-Type: multipart/form-data` HTTP header. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class CreateImageExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImagesApi();
            var buildID = buildID_example;  // string | The requested build ID
            var name = name_example;  // string | The name of the image
            var image = new System.IO.Stream(); // System.IO.Stream | The contents of the image

            try
            {
                // Create an image
                Image result = apiInstance.CreateImage(buildID, name, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImagesApi.CreateImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildID** | **string**| The requested build ID | 
 **name** | **string**| The name of the image | 
 **image** | **System.IO.Stream**| The contents of the image | 

### Return type

[**Image**](Image.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimages"></a>
# **GetImages**
> Images GetImages (string buildID)

Get images for a build

Get a list of all images for a build. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class GetImagesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImagesApi();
            var buildID = buildID_example;  // string | The requested build ID

            try
            {
                // Get images for a build
                Images result = apiInstance.GetImages(buildID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImagesApi.GetImages: " + e.Message );
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

[**Images**](Images.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

