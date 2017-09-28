# IO.Swagger.Api.PaymentmethodsApi

All URIs are relative to *https://api.phone.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccountPaymentMethod**](PaymentmethodsApi.md#createaccountpaymentmethod) | **POST** /accounts/{account_id}/payment-methods | Create an individual payment method.
[**DeleteAccountPaymentMethod**](PaymentmethodsApi.md#deleteaccountpaymentmethod) | **DELETE** /accounts/{account_id}/payment-methods/{pm_id} | Delete an individual payment method.
[**GetAccountPaymentMethod**](PaymentmethodsApi.md#getaccountpaymentmethod) | **GET** /accounts/{account_id}/payment-methods/{pm_id} | Show details of an individual payment method.
[**ListAccountPaymentMethods**](PaymentmethodsApi.md#listaccountpaymentmethods) | **GET** /accounts/{account_id}/payment-methods | Get a list of payment methods for an account.
[**PatchAccountPaymentMethod**](PaymentmethodsApi.md#patchaccountpaymentmethod) | **PATCH** /accounts/{account_id}/payment-methods/{pm_id} | Replace the status of an individual payment method.


<a name="createaccountpaymentmethod"></a>
# **CreateAccountPaymentMethod**
> PaymentFull CreateAccountPaymentMethod (int? accountId, CreatePaymentParams data)

Create an individual payment method.

Create an individual payment method. See Account Payment Methods for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccountPaymentMethodExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PaymentmethodsApi();
            var accountId = 56;  // int? | Account ID
            var data = new CreatePaymentParams(); // CreatePaymentParams | Payment data

            try
            {
                // Create an individual payment method.
                PaymentFull result = apiInstance.CreateAccountPaymentMethod(accountId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.CreateAccountPaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **data** | [**CreatePaymentParams**](CreatePaymentParams.md)| Payment data | 

### Return type

[**PaymentFull**](PaymentFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountpaymentmethod"></a>
# **DeleteAccountPaymentMethod**
> DeleteEntry DeleteAccountPaymentMethod (int? accountId, int? pmId)

Delete an individual payment method.

Delete an individual payment method. See Account Payment Methods for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAccountPaymentMethodExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PaymentmethodsApi();
            var accountId = 56;  // int? | Account ID
            var pmId = 56;  // int? | Payment Method ID

            try
            {
                // Delete an individual payment method.
                DeleteEntry result = apiInstance.DeleteAccountPaymentMethod(accountId, pmId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.DeleteAccountPaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **pmId** | **int?**| Payment Method ID | 

### Return type

[**DeleteEntry**](DeleteEntry.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountpaymentmethod"></a>
# **GetAccountPaymentMethod**
> PaymentFull GetAccountPaymentMethod (int? accountId, int? pmId)

Show details of an individual payment method.

Show details of an individual payment method. See Account Payment Methods for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountPaymentMethodExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PaymentmethodsApi();
            var accountId = 56;  // int? | Account ID
            var pmId = 56;  // int? | Payment Method ID

            try
            {
                // Show details of an individual payment method.
                PaymentFull result = apiInstance.GetAccountPaymentMethod(accountId, pmId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.GetAccountPaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **pmId** | **int?**| Payment Method ID | 

### Return type

[**PaymentFull**](PaymentFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountpaymentmethods"></a>
# **ListAccountPaymentMethods**
> ListPaymentMethods ListAccountPaymentMethods (int? accountId, List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null)

Get a list of payment methods for an account.

Get a list of payment methods for an account. See Account Payment Methods for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAccountPaymentMethodsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PaymentmethodsApi();
            var accountId = 56;  // int? | Account ID
            var filtersId = new List<string>(); // List<string> | ID filter (optional) 
            var sortId = sortId_example;  // string | ID sorting (optional) 
            var limit = 56;  // int? | Max results (optional) 
            var offset = 56;  // int? | Results to skip (optional) 
            var fields = fields_example;  // string | Field set (optional) 

            try
            {
                // Get a list of payment methods for an account.
                ListPaymentMethods result = apiInstance.ListAccountPaymentMethods(accountId, filtersId, sortId, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.ListAccountPaymentMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **filtersId** | [**List&lt;string&gt;**](string.md)| ID filter | [optional] 
 **sortId** | **string**| ID sorting | [optional] 
 **limit** | **int?**| Max results | [optional] 
 **offset** | **int?**| Results to skip | [optional] 
 **fields** | **string**| Field set | [optional] 

### Return type

[**ListPaymentMethods**](ListPaymentMethods.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchaccountpaymentmethod"></a>
# **PatchAccountPaymentMethod**
> PaymentFull PatchAccountPaymentMethod (int? accountId, int? pmId, PatchPaymentParams data = null)

Replace the status of an individual payment method.

Replace the status of an individual payment method. See Account Payment Methods for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchAccountPaymentMethodExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PaymentmethodsApi();
            var accountId = 56;  // int? | Account ID
            var pmId = 56;  // int? | Payment Method ID
            var data = new PatchPaymentParams(); // PatchPaymentParams | Payment data (optional) 

            try
            {
                // Replace the status of an individual payment method.
                PaymentFull result = apiInstance.PatchAccountPaymentMethod(accountId, pmId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentmethodsApi.PatchAccountPaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **pmId** | **int?**| Payment Method ID | 
 **data** | [**PatchPaymentParams**](PatchPaymentParams.md)| Payment data | [optional] 

### Return type

[**PaymentFull**](PaymentFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

