# IO.Swagger.Api.SubaccountpricingApi

All URIs are relative to *https://api.phone.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccountSubaccountPricing**](SubaccountpricingApi.md#createaccountsubaccountpricing) | **POST** /accounts/{account_id}/subaccounts/{subaccount_id}/pricing | Add a pricing plan to a subaccount.
[**DeleteAccountSubaccountPricing**](SubaccountpricingApi.md#deleteaccountsubaccountpricing) | **DELETE** /accounts/{account_id}/subaccounts/{subaccount_id}/pricing/{pricing_id} | Delete a pricing plan from a subaccount.
[**GetAccountSubaccountPricing**](SubaccountpricingApi.md#getaccountsubaccountpricing) | **GET** /accounts/{account_id}/subaccounts/{subaccount_id}/pricing/{pricing_id} | Get the details of a pricing plan for a subaccount.
[**ListAccountSubaccountPricing**](SubaccountpricingApi.md#listaccountsubaccountpricing) | **GET** /accounts/{account_id}/subaccounts/{subaccount_id}/pricing | Get a list of pricing plans for a subaccount.


<a name="createaccountsubaccountpricing"></a>
# **CreateAccountSubaccountPricing**
> PricingFull CreateAccountSubaccountPricing (int? accountId, int? subaccountId, CreatePricingParams data)

Add a pricing plan to a subaccount.

Add a pricing plan to a subaccount. See Account Subaccount Pricing for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccountSubaccountPricingExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new SubaccountpricingApi();
            var accountId = 56;  // int? | Account ID
            var subaccountId = 56;  // int? | Subaccount ID
            var data = new CreatePricingParams(); // CreatePricingParams | Subaccount pricing data

            try
            {
                // Add a pricing plan to a subaccount.
                PricingFull result = apiInstance.CreateAccountSubaccountPricing(accountId, subaccountId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountpricingApi.CreateAccountSubaccountPricing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **subaccountId** | **int?**| Subaccount ID | 
 **data** | [**CreatePricingParams**](CreatePricingParams.md)| Subaccount pricing data | 

### Return type

[**PricingFull**](PricingFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountsubaccountpricing"></a>
# **DeleteAccountSubaccountPricing**
> DeleteEntry DeleteAccountSubaccountPricing (int? accountId, int? subaccountId, int? pricingId)

Delete a pricing plan from a subaccount.

Delete a pricing plan from a subaccount. See Account Subaccount Pricing for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAccountSubaccountPricingExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new SubaccountpricingApi();
            var accountId = 56;  // int? | Account ID
            var subaccountId = 56;  // int? | Subaccount ID
            var pricingId = 56;  // int? | Pricing Object ID

            try
            {
                // Delete a pricing plan from a subaccount.
                DeleteEntry result = apiInstance.DeleteAccountSubaccountPricing(accountId, subaccountId, pricingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountpricingApi.DeleteAccountSubaccountPricing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **subaccountId** | **int?**| Subaccount ID | 
 **pricingId** | **int?**| Pricing Object ID | 

### Return type

[**DeleteEntry**](DeleteEntry.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountsubaccountpricing"></a>
# **GetAccountSubaccountPricing**
> PricingFull GetAccountSubaccountPricing (int? accountId, int? subaccountId, int? pricingId)

Get the details of a pricing plan for a subaccount.

Get the details of a pricing plan for a subaccount. See Account Subaccount Pricing for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountSubaccountPricingExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new SubaccountpricingApi();
            var accountId = 56;  // int? | Account ID
            var subaccountId = 56;  // int? | Subaccount ID
            var pricingId = 56;  // int? | Pricing Object ID

            try
            {
                // Get the details of a pricing plan for a subaccount.
                PricingFull result = apiInstance.GetAccountSubaccountPricing(accountId, subaccountId, pricingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountpricingApi.GetAccountSubaccountPricing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **subaccountId** | **int?**| Subaccount ID | 
 **pricingId** | **int?**| Pricing Object ID | 

### Return type

[**PricingFull**](PricingFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountsubaccountpricing"></a>
# **ListAccountSubaccountPricing**
> ListPricings ListAccountSubaccountPricing (int? accountId, int? subaccountId, List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null)

Get a list of pricing plans for a subaccount.

Get a list of pricing plans for a subaccount. See Account Subaccount Pricing for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAccountSubaccountPricingExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new SubaccountpricingApi();
            var accountId = 56;  // int? | Account ID
            var subaccountId = 56;  // int? | Subaccount ID
            var filtersId = new List<string>(); // List<string> | ID filter (optional) 
            var sortId = sortId_example;  // string | ID sorting (optional) 
            var limit = 56;  // int? | Max results (optional) 
            var offset = 56;  // int? | Results to skip (optional) 
            var fields = fields_example;  // string | Field set (optional) 

            try
            {
                // Get a list of pricing plans for a subaccount.
                ListPricings result = apiInstance.ListAccountSubaccountPricing(accountId, subaccountId, filtersId, sortId, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountpricingApi.ListAccountSubaccountPricing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **subaccountId** | **int?**| Subaccount ID | 
 **filtersId** | [**List&lt;string&gt;**](string.md)| ID filter | [optional] 
 **sortId** | **string**| ID sorting | [optional] 
 **limit** | **int?**| Max results | [optional] 
 **offset** | **int?**| Results to skip | [optional] 
 **fields** | **string**| Field set | [optional] 

### Return type

[**ListPricings**](ListPricings.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

