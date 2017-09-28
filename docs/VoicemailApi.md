# IO.Swagger.Api.VoicemailApi

All URIs are relative to *https://api.phone.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccountVoicemail**](VoicemailApi.md#getaccountvoicemail) | **GET** /accounts/{account_id}/voicemail/{voicemail_id} | This service shows the details of an individual voicemail.
[**ListAccountVoicemail**](VoicemailApi.md#listaccountvoicemail) | **GET** /accounts/{account_id}/voicemail | Get a list of voicemail messages for an account.
[**PatchAccountVoicemail**](VoicemailApi.md#patchaccountvoicemail) | **PATCH** /accounts/{account_id}/voicemail/{voicemail_id} | Update the is_new parameter in a voicemail record.


<a name="getaccountvoicemail"></a>
# **GetAccountVoicemail**
> VoicemailFull GetAccountVoicemail (int? accountId, string voicemailId)

This service shows the details of an individual voicemail.

This service shows the details of an individual voicemail. See Intro to Voicemail for more info on the properties. Note: This API is for users with Account Owner scope access token. Users with Extension User scope token should invoke the Get Voicemail API with the following definition: GET https://api.phone.com/v4/accounts/:account_id/extensions/:extension_id/voicemail/:voicemail_id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountVoicemailExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new VoicemailApi();
            var accountId = 56;  // int? | Account ID
            var voicemailId = voicemailId_example;  // string | Voicemail ID

            try
            {
                // This service shows the details of an individual voicemail.
                VoicemailFull result = apiInstance.GetAccountVoicemail(accountId, voicemailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetAccountVoicemail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **voicemailId** | **string**| Voicemail ID | 

### Return type

[**VoicemailFull**](VoicemailFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountvoicemail"></a>
# **ListAccountVoicemail**
> ListVoicemail ListAccountVoicemail (int? accountId, List<string> filtersId = null, string filtersFrom = null, string filtersTo = null, bool? filtersIsNew = null, string filtersCreatedAt = null, List<string> filtersExtension = null, string sortId = null, string sortCreatedAt = null, int? limit = null, int? offset = null, string fields = null)

Get a list of voicemail messages for an account.

Get a list of voicemail messages for an account. See Intro to Voicemail for more info on the properties. Note: This API is for users with Account Owner scope access token. Users with Extension User scope token should invoke the List Voicemail API with the following definition: GET https://api.phone.com/v4/accounts/:account_id/extensions/:extension_id/voicemail

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAccountVoicemailExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new VoicemailApi();
            var accountId = 56;  // int? | Account ID
            var filtersId = new List<string>(); // List<string> | ID filter (optional) 
            var filtersFrom = filtersFrom_example;  // string | Caller ID filter (optional) 
            var filtersTo = filtersTo_example;  // string | Callee ID filter, the E.164 phone number to send the SMS TO. Note you must encode the + as %2B (optional) 
            var filtersIsNew = true;  // bool? |  (optional) 
            var filtersCreatedAt = filtersCreatedAt_example;  // string | Date string representing the UTC time that sms was created (optional) 
            var filtersExtension = new List<string>(); // List<string> | Extension filter (optional) 
            var sortId = sortId_example;  // string | ID sorting (optional) 
            var sortCreatedAt = sortCreatedAt_example;  // string | Sort by the UTC time that voicemail was created (optional) 
            var limit = 56;  // int? | Max results (optional) 
            var offset = 56;  // int? | Results to skip (optional) 
            var fields = fields_example;  // string | Field set (optional) 

            try
            {
                // Get a list of voicemail messages for an account.
                ListVoicemail result = apiInstance.ListAccountVoicemail(accountId, filtersId, filtersFrom, filtersTo, filtersIsNew, filtersCreatedAt, filtersExtension, sortId, sortCreatedAt, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.ListAccountVoicemail: " + e.Message );
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
 **filtersFrom** | **string**| Caller ID filter | [optional] 
 **filtersTo** | **string**| Callee ID filter, the E.164 phone number to send the SMS TO. Note you must encode the + as %2B | [optional] 
 **filtersIsNew** | **bool?**|  | [optional] 
 **filtersCreatedAt** | **string**| Date string representing the UTC time that sms was created | [optional] 
 **filtersExtension** | [**List&lt;string&gt;**](string.md)| Extension filter | [optional] 
 **sortId** | **string**| ID sorting | [optional] 
 **sortCreatedAt** | **string**| Sort by the UTC time that voicemail was created | [optional] 
 **limit** | **int?**| Max results | [optional] 
 **offset** | **int?**| Results to skip | [optional] 
 **fields** | **string**| Field set | [optional] 

### Return type

[**ListVoicemail**](ListVoicemail.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchaccountvoicemail"></a>
# **PatchAccountVoicemail**
> VoicemailFull PatchAccountVoicemail (int? accountId, string voicemailId, PatchVoicemailParams data = null)

Update the is_new parameter in a voicemail record.

Update the is_new parameter in a voicemail record. See Account Voicemail for more info on the properties. Note: This API is for users with Account Owner scope access token. Users with Extension User scope token should invoke the Patch Voicemail API with the following definition: PATCH https://api.phone.com/v4/accounts/:account_id/extensions/:extension_id/voicemail/:voicemail_id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchAccountVoicemailExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new VoicemailApi();
            var accountId = 56;  // int? | Account ID
            var voicemailId = voicemailId_example;  // string | Voicemail ID
            var data = new PatchVoicemailParams(); // PatchVoicemailParams | Payment data (optional) 

            try
            {
                // Update the is_new parameter in a voicemail record.
                VoicemailFull result = apiInstance.PatchAccountVoicemail(accountId, voicemailId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PatchAccountVoicemail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **voicemailId** | **string**| Voicemail ID | 
 **data** | [**PatchVoicemailParams**](PatchVoicemailParams.md)| Payment data | [optional] 

### Return type

[**VoicemailFull**](VoicemailFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

