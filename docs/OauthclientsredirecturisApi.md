# IO.Swagger.Api.OauthclientsredirecturisApi

All URIs are relative to *https://api.phone.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccountOauthClientsRedirectUri**](OauthclientsredirecturisApi.md#createaccountoauthclientsredirecturi) | **POST** /accounts/{account_id}/oauth/clients/{client_id}/redirect-uris | Create an OAuth Client Redirect URI record.
[**DeleteAccountOauthClientsRedirectUri**](OauthclientsredirecturisApi.md#deleteaccountoauthclientsredirecturi) | **DELETE** /accounts/{account_id}/oauth/clients/{client_id}/redirect-uris/{uri_id} | Delete an OAuth Client Redirect URI record.
[**GetAccountOauthClientsRedirectUri**](OauthclientsredirecturisApi.md#getaccountoauthclientsredirecturi) | **GET** /accounts/{account_id}/oauth/clients/{client_id}/redirect-uris/{uri_id} | Get details of an OAuth Client Redirect URI record.
[**ListAccountOauthClientsRedirectUris**](OauthclientsredirecturisApi.md#listaccountoauthclientsredirecturis) | **GET** /accounts/{account_id}/oauth/clients/{client_id}/redirect-uris | Get a list of OAuth Client Redirect URIs for an account.


<a name="createaccountoauthclientsredirecturi"></a>
# **CreateAccountOauthClientsRedirectUri**
> OauthClientRedirectUriFull CreateAccountOauthClientsRedirectUri (int? accountId, int? clientId, CreateRedirectUriParams data = null)

Create an OAuth Client Redirect URI record.

Create an OAuth Client Redirect URI record.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccountOauthClientsRedirectUriExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthclientsredirecturisApi();
            var accountId = 56;  // int? | Account ID
            var clientId = 56;  // int? | Client ID
            var data = new CreateRedirectUriParams(); // CreateRedirectUriParams | Redirect Uri data (optional) 

            try
            {
                // Create an OAuth Client Redirect URI record.
                OauthClientRedirectUriFull result = apiInstance.CreateAccountOauthClientsRedirectUri(accountId, clientId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthclientsredirecturisApi.CreateAccountOauthClientsRedirectUri: " + e.Message );
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
 **data** | [**CreateRedirectUriParams**](CreateRedirectUriParams.md)| Redirect Uri data | [optional] 

### Return type

[**OauthClientRedirectUriFull**](OauthClientRedirectUriFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountoauthclientsredirecturi"></a>
# **DeleteAccountOauthClientsRedirectUri**
> DeleteEntry DeleteAccountOauthClientsRedirectUri (int? accountId, int? clientId, int? uriId)

Delete an OAuth Client Redirect URI record.

Delete an OAuth Client Redirect URI record.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAccountOauthClientsRedirectUriExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthclientsredirecturisApi();
            var accountId = 56;  // int? | Account ID
            var clientId = 56;  // int? | Client ID
            var uriId = 56;  // int? | Redirect URI ID

            try
            {
                // Delete an OAuth Client Redirect URI record.
                DeleteEntry result = apiInstance.DeleteAccountOauthClientsRedirectUri(accountId, clientId, uriId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthclientsredirecturisApi.DeleteAccountOauthClientsRedirectUri: " + e.Message );
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
 **uriId** | **int?**| Redirect URI ID | 

### Return type

[**DeleteEntry**](DeleteEntry.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountoauthclientsredirecturi"></a>
# **GetAccountOauthClientsRedirectUri**
> OauthClientRedirectUriFull GetAccountOauthClientsRedirectUri (int? accountId, int? clientId, int? uriId)

Get details of an OAuth Client Redirect URI record.

Get details of an OAuth Client Redirect URI record.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountOauthClientsRedirectUriExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthclientsredirecturisApi();
            var accountId = 56;  // int? | Account ID
            var clientId = 56;  // int? | Client ID
            var uriId = 56;  // int? | Redirect URI ID

            try
            {
                // Get details of an OAuth Client Redirect URI record.
                OauthClientRedirectUriFull result = apiInstance.GetAccountOauthClientsRedirectUri(accountId, clientId, uriId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthclientsredirecturisApi.GetAccountOauthClientsRedirectUri: " + e.Message );
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
 **uriId** | **int?**| Redirect URI ID | 

### Return type

[**OauthClientRedirectUriFull**](OauthClientRedirectUriFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountoauthclientsredirecturis"></a>
# **ListAccountOauthClientsRedirectUris**
> ListOauthClientsRedirectUris ListAccountOauthClientsRedirectUris (int? accountId, int? clientId, List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null)

Get a list of OAuth Client Redirect URIs for an account.

Get a list of OAuth Client Redirect URIs for an account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAccountOauthClientsRedirectUrisExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthclientsredirecturisApi();
            var accountId = 56;  // int? | Account ID
            var clientId = 56;  // int? | Client ID
            var filtersId = new List<string>(); // List<string> | ID filter (optional) 
            var sortId = sortId_example;  // string | ID sorting (optional) 
            var limit = 56;  // int? | Max results (optional) 
            var offset = 56;  // int? | Results to skip (optional) 
            var fields = fields_example;  // string | Field set (optional) 

            try
            {
                // Get a list of OAuth Client Redirect URIs for an account.
                ListOauthClientsRedirectUris result = apiInstance.ListAccountOauthClientsRedirectUris(accountId, clientId, filtersId, sortId, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthclientsredirecturisApi.ListAccountOauthClientsRedirectUris: " + e.Message );
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
 **filtersId** | [**List&lt;string&gt;**](string.md)| ID filter | [optional] 
 **sortId** | **string**| ID sorting | [optional] 
 **limit** | **int?**| Max results | [optional] 
 **offset** | **int?**| Results to skip | [optional] 
 **fields** | **string**| Field set | [optional] 

### Return type

[**ListOauthClientsRedirectUris**](ListOauthClientsRedirectUris.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

