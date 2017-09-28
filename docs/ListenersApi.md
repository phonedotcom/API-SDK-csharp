# IO.Swagger.Api.ListenersApi

All URIs are relative to *https://api.phone.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccountListener**](ListenersApi.md#createaccountlistener) | **POST** /accounts/{account_id}/listeners | Add a listener object to your account that can be used to subscribe an event.
[**DeleteAccountListener**](ListenersApi.md#deleteaccountlistener) | **DELETE** /accounts/{account_id}/listeners/{listener_id} | Delete an individual event listener.
[**GetAccountListener**](ListenersApi.md#getaccountlistener) | **GET** /accounts/{account_id}/listeners/{listener_id} | Show details of an individual listener.
[**ListAccountListeners**](ListenersApi.md#listaccountlisteners) | **GET** /accounts/{account_id}/listeners | Get a list of listeners for an account.
[**ReplaceAccountListener**](ListenersApi.md#replaceaccountlistener) | **PUT** /accounts/{account_id}/listeners/{listener_id} | Update the settings of an individual event listener.


<a name="createaccountlistener"></a>
# **CreateAccountListener**
> ListenerFull CreateAccountListener (int? accountId, CreateListenerParams data = null)

Add a listener object to your account that can be used to subscribe an event.

Add a listener object to your account that can be used to subscribe an event. See Account Listeners for more info on the properties. Note: This API is for users with Account Owner scope access token. Users with Extension User scope token should invoke the Extension level Post Listener API with the following definition: POST https://api.phone.com/v4/accounts/:account_id/extensions/:extension_id/listeners

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccountListenerExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ListenersApi();
            var accountId = 56;  // int? | Account ID
            var data = new CreateListenerParams(); // CreateListenerParams | Account Listeners Data (optional) 

            try
            {
                // Add a listener object to your account that can be used to subscribe an event.
                ListenerFull result = apiInstance.CreateAccountListener(accountId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListenersApi.CreateAccountListener: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **data** | [**CreateListenerParams**](CreateListenerParams.md)| Account Listeners Data | [optional] 

### Return type

[**ListenerFull**](ListenerFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountlistener"></a>
# **DeleteAccountListener**
> DeleteEntry DeleteAccountListener (int? accountId, int? listenerId)

Delete an individual event listener.

Delete an individual event listener. See Account Listeners for more info on the properties. Note: This API is for users with Account Owner scope access token. Users with Extension User scope token should invoke the Extension level Delete Listener API with the following definition: DELETE https://api.phone.com/v4/accounts/:account_id/extensions/:extension_id/listeners/:listener_id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAccountListenerExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ListenersApi();
            var accountId = 56;  // int? | Account ID
            var listenerId = 56;  // int? | Listener ID

            try
            {
                // Delete an individual event listener.
                DeleteEntry result = apiInstance.DeleteAccountListener(accountId, listenerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListenersApi.DeleteAccountListener: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **listenerId** | **int?**| Listener ID | 

### Return type

[**DeleteEntry**](DeleteEntry.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountlistener"></a>
# **GetAccountListener**
> ListenerFull GetAccountListener (int? accountId, int? listenerId)

Show details of an individual listener.

Show details of an individual event listener. See Account Listeners for more info on the properties. Note: This API is for users with Account Owner scope access token. Users with Extension User scope token should invoke the Extension level Get Listener API with the following definition: GET https://api.phone.com/v4/accounts/:account_id/extensions/:extension_id/listeners/:listener_id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountListenerExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ListenersApi();
            var accountId = 56;  // int? | Account ID
            var listenerId = 56;  // int? | Listener ID

            try
            {
                // Show details of an individual listener.
                ListenerFull result = apiInstance.GetAccountListener(accountId, listenerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListenersApi.GetAccountListener: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **listenerId** | **int?**| Listener ID | 

### Return type

[**ListenerFull**](ListenerFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountlisteners"></a>
# **ListAccountListeners**
> ListListeners ListAccountListeners (int? accountId, List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null)

Get a list of listeners for an account.

Get a list of listeners for an account. See Account Listeners for more info on the properties. Note: This API is for users with Account Owner scope access token. Users with Extension User scope token should invoke the Extension level List Listeners API with the following definition: GET https://api.phone.com/v4/accounts/:account_id/extensions/:extension_id/listeners

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAccountListenersExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ListenersApi();
            var accountId = 56;  // int? | Account ID
            var filtersId = new List<string>(); // List<string> | ID filter (optional) 
            var sortId = sortId_example;  // string | ID sorting (optional) 
            var limit = 56;  // int? | Max results (optional) 
            var offset = 56;  // int? | Results to skip (optional) 
            var fields = fields_example;  // string | Field set (optional) 

            try
            {
                // Get a list of listeners for an account.
                ListListeners result = apiInstance.ListAccountListeners(accountId, filtersId, sortId, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListenersApi.ListAccountListeners: " + e.Message );
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

[**ListListeners**](ListListeners.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceaccountlistener"></a>
# **ReplaceAccountListener**
> ListenerFull ReplaceAccountListener (int? accountId, int? listenerId, CreateListenerParams data = null)

Update the settings of an individual event listener.

Update the settings of an individual event listener. See Event Listeners for more detail. Note: This API is for users with Account Owner scope access token. Users with Extension User scope token should invoke the Extension level Replace Listener API with the following definition: PUT https://api.phone.com/v4/accounts/:account_id/extensions/:extension_id/listeners/:listener_id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceAccountListenerExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ListenersApi();
            var accountId = 56;  // int? | Account ID
            var listenerId = 56;  // int? | Listener ID
            var data = new CreateListenerParams(); // CreateListenerParams | Account Listeners Data (optional) 

            try
            {
                // Update the settings of an individual event listener.
                ListenerFull result = apiInstance.ReplaceAccountListener(accountId, listenerId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListenersApi.ReplaceAccountListener: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **listenerId** | **int?**| Listener ID | 
 **data** | [**CreateListenerParams**](CreateListenerParams.md)| Account Listeners Data | [optional] 

### Return type

[**ListenerFull**](ListenerFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

