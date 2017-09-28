# IO.Swagger.Api.OauthclientsApi

All URIs are relative to *https://api.phone.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAccountOauthClient**](OauthclientsApi.md#deleteaccountoauthclient) | **DELETE** /accounts/{account_id}/oauth/clients/{client_id} | Delete an individual OAuth client.
[**GetAccountOauthClient**](OauthclientsApi.md#getaccountoauthclient) | **GET** /accounts/{account_id}/oauth/clients/{client_id} | Show details of an individual OAuth client.
[**ListAccountOauthClients**](OauthclientsApi.md#listaccountoauthclients) | **GET** /accounts/{account_id}/oauth/clients | Get a list of OAuth clients for an account.


<a name="deleteaccountoauthclient"></a>
# **DeleteAccountOauthClient**
> DeleteEntry DeleteAccountOauthClient (int? accountId, int? clientId)

Delete an individual OAuth client.

Delete an individual OAuth client. See Account OAuth Clients for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAccountOauthClientExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthclientsApi();
            var accountId = 56;  // int? | Account ID
            var clientId = 56;  // int? | Client ID

            try
            {
                // Delete an individual OAuth client.
                DeleteEntry result = apiInstance.DeleteAccountOauthClient(accountId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthclientsApi.DeleteAccountOauthClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **clientId** | **int?**| Client ID | 

### Return type

[**DeleteEntry**](DeleteEntry.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountoauthclient"></a>
# **GetAccountOauthClient**
> OauthClientFull GetAccountOauthClient (int? accountId, int? clientId)

Show details of an individual OAuth client.

Show details of an individual OAuth client. See Account OAuth Clients for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountOauthClientExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthclientsApi();
            var accountId = 56;  // int? | Account ID
            var clientId = 56;  // int? | Client ID

            try
            {
                // Show details of an individual OAuth client.
                OauthClientFull result = apiInstance.GetAccountOauthClient(accountId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthclientsApi.GetAccountOauthClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **clientId** | **int?**| Client ID | 

### Return type

[**OauthClientFull**](OauthClientFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountoauthclients"></a>
# **ListAccountOauthClients**
> ListOauthClients ListAccountOauthClients (int? accountId, List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null)

Get a list of OAuth clients for an account.

Get a list of OAuth clients for an account. See Account OAuth Clients for more info on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAccountOauthClientsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthclientsApi();
            var accountId = 56;  // int? | Account ID
            var filtersId = new List<string>(); // List<string> | ID filter (optional) 
            var sortId = sortId_example;  // string | ID sorting (optional) 
            var limit = 56;  // int? | Max results (optional) 
            var offset = 56;  // int? | Results to skip (optional) 
            var fields = fields_example;  // string | Field set (optional) 

            try
            {
                // Get a list of OAuth clients for an account.
                ListOauthClients result = apiInstance.ListAccountOauthClients(accountId, filtersId, sortId, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthclientsApi.ListAccountOauthClients: " + e.Message );
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

[**ListOauthClients**](ListOauthClients.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

