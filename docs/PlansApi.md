# VisWiz.SDK.Client.PlansApi

All URIs are relative to *https://api.viswiz.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPlan**](PlansApi.md#cancelplan) | **DELETE** /account/cancel-plan | Cancel the active plan
[**GetPlans**](PlansApi.md#getplans) | **GET** /plans | Get all plans


<a name="cancelplan"></a>
# **CancelPlan**
> void CancelPlan ()

Cancel the active plan

Cancels the active subscription plan for the account. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class CancelPlanExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();

            try
            {
                // Cancel the active plan
                apiInstance.CancelPlan();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.CancelPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplans"></a>
# **GetPlans**
> InlineResponse200 GetPlans ()

Get all plans

Get a list of all the subscription plans available. 

### Example
```csharp
using System;
using System.Diagnostics;
using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace Example
{
    public class GetPlansExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();

            try
            {
                // Get all plans
                InlineResponse200 result = apiInstance.GetPlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.GetPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

