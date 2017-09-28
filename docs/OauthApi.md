# IO.Swagger.Api.OauthApi

All URIs are relative to *https://api.phone.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOauthAccessToken**](OauthApi.md#createoauthaccesstoken) | **POST** /oauth/access-token | To create an access token via the /oauth/access-token API, an API user may choose any one of the grant types it supports: Authorization Code Grant, Client Credential Grant, Password Credential Grant or Refresh Token Grant.
[**CreateOauthAuthorization**](OauthApi.md#createoauthauthorization) | **GET** /oauth/authorization | Create Authorization Code or Access Token.
[**GetOauthAccessToken**](OauthApi.md#getoauthaccesstoken) | **GET** /oauth/access-token | Retrieve details of an access token, such as scope, expiration and extension ID.


<a name="createoauthaccesstoken"></a>
# **CreateOauthAccessToken**
> OauthAccessToken CreateOauthAccessToken (CreateOauthParams data = null)

To create an access token via the /oauth/access-token API, an API user may choose any one of the grant types it supports: Authorization Code Grant, Client Credential Grant, Password Credential Grant or Refresh Token Grant.

To create an access token via the /oauth/access-token API, an API user may choose any one of the grant types it supports: Authorization Code Grant, Client Credential Grant, Password Credential Grant or Refresh Token Grant. For Authorization Code Grant, the input parameter 'code' is generated via the Create Authorization API. NOTE: The Create Access Token API now accepts requests in query string format as well as JSON body format. See OAuth for more details on how to obtain client id and client secret to create an access token at real time.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOauthAccessTokenExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthApi();
            var data = new CreateOauthParams(); // CreateOauthParams | Oauth data (optional) 

            try
            {
                // To create an access token via the /oauth/access-token API, an API user may choose any one of the grant types it supports: Authorization Code Grant, Client Credential Grant, Password Credential Grant or Refresh Token Grant.
                OauthAccessToken result = apiInstance.CreateOauthAccessToken(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthApi.CreateOauthAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**CreateOauthParams**](CreateOauthParams.md)| Oauth data | [optional] 

### Return type

[**OauthAccessToken**](OauthAccessToken.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createoauthauthorization"></a>
# **CreateOauthAuthorization**
> void CreateOauthAuthorization (string clientId, string responseType, string scope, string redirectUri)

Create Authorization Code or Access Token.

Create Authorization Code or Access Token. The /oauth/authorization API supports Authorization Grant and Implicit Grant. In Authorization Grant, this API returns a code (response_type=code) for clients implemented in a browser using a scripting language such as JavaScript. Users may then use the code via the Create Access Token API to create an access token. The Implicit Grant is a simplified authorization code flow. In the implicit flow, instead of issuing the client an authorization code, the client is issued an access token (response_type=token) directly. See OAuth for more details on how to obtain client id and client secret to create authorization code access token at real time.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOauthAuthorizationExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthApi();
            var clientId = clientId_example;  // string | Client ID
            var responseType = responseType_example;  // string | 'token' for Implicit Grant; 'code' for Authorization Code Grant
            var scope = scope_example;  // string | account-owner, extension-user and/or methods:ALL, separated by space (%20)
            var redirectUri = redirectUri_example;  // string | The URL where the response data of this API is redirected to

            try
            {
                // Create Authorization Code or Access Token.
                apiInstance.CreateOauthAuthorization(clientId, responseType, scope, redirectUri);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthApi.CreateOauthAuthorization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID | 
 **responseType** | **string**| &#39;token&#39; for Implicit Grant; &#39;code&#39; for Authorization Code Grant | 
 **scope** | **string**| account-owner, extension-user and/or methods:ALL, separated by space (%20) | 
 **redirectUri** | **string**| The URL where the response data of this API is redirected to | 

### Return type

void (empty response body)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthaccesstoken"></a>
# **GetOauthAccessToken**
> GetOauthAccessToken GetOauthAccessToken ()

Retrieve details of an access token, such as scope, expiration and extension ID.

Retrieve details of an access token, such as scope, expiration and extension ID. Voip ID will be returned as well if scope contains account-owner scope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOauthAccessTokenExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new OauthApi();

            try
            {
                // Retrieve details of an access token, such as scope, expiration and extension ID.
                GetOauthAccessToken result = apiInstance.GetOauthAccessToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthApi.GetOauthAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetOauthAccessToken**](GetOauthAccessToken.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

