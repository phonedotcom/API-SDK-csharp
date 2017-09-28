# IO.Swagger.Api.ContactsApi

All URIs are relative to *https://api.phone.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccountExtensionContact**](ContactsApi.md#createaccountextensioncontact) | **POST** /accounts/{account_id}/extensions/{extension_id}/contacts | Add a new address book contact for an extension.
[**DeleteAccountExtensionContact**](ContactsApi.md#deleteaccountextensioncontact) | **DELETE** /accounts/{account_id}/extensions/{extension_id}/contacts/{contact_id} | Delete a contact from the address book.
[**GetAccountExtensionContact**](ContactsApi.md#getaccountextensioncontact) | **GET** /accounts/{account_id}/extensions/{extension_id}/contacts/{contact_id} | Retrieve the details of an address book contact.
[**ListAccountExtensionContacts**](ContactsApi.md#listaccountextensioncontacts) | **GET** /accounts/{account_id}/extensions/{extension_id}/contacts | Show the Caller ID options a given extension can use.
[**ReplaceAccountExtensionContact**](ContactsApi.md#replaceaccountextensioncontact) | **PUT** /accounts/{account_id}/extensions/{extension_id}/contacts/{contact_id} | Update the info of a contact in the address book.


<a name="createaccountextensioncontact"></a>
# **CreateAccountExtensionContact**
> ContactFull CreateAccountExtensionContact (int? accountId, int? extensionId, CreateContactParams data = null)

Add a new address book contact for an extension.

Add a new address book contact for an extension. See Account Contacts for more info on the fields in each item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccountExtensionContactExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContactsApi();
            var accountId = 56;  // int? | Account ID
            var extensionId = 56;  // int? | Extension ID
            var data = new CreateContactParams(); // CreateContactParams | Contact data (optional) 

            try
            {
                // Add a new address book contact for an extension.
                ContactFull result = apiInstance.CreateAccountExtensionContact(accountId, extensionId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateAccountExtensionContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **extensionId** | **int?**| Extension ID | 
 **data** | [**CreateContactParams**](CreateContactParams.md)| Contact data | [optional] 

### Return type

[**ContactFull**](ContactFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountextensioncontact"></a>
# **DeleteAccountExtensionContact**
> DeleteEntry DeleteAccountExtensionContact (int? accountId, int? extensionId, int? contactId)

Delete a contact from the address book.

Delete a contact from the address book. See Account Contacts for more info on the fields in each item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAccountExtensionContactExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContactsApi();
            var accountId = 56;  // int? | Account ID
            var extensionId = 56;  // int? | Extension ID
            var contactId = 56;  // int? | Contact ID

            try
            {
                // Delete a contact from the address book.
                DeleteEntry result = apiInstance.DeleteAccountExtensionContact(accountId, extensionId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteAccountExtensionContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **extensionId** | **int?**| Extension ID | 
 **contactId** | **int?**| Contact ID | 

### Return type

[**DeleteEntry**](DeleteEntry.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountextensioncontact"></a>
# **GetAccountExtensionContact**
> ContactFull GetAccountExtensionContact (int? accountId, int? extensionId, int? contactId)

Retrieve the details of an address book contact.

Retrieve the details of an address book contact. See Account Contacts for more info on the fields in each item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountExtensionContactExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContactsApi();
            var accountId = 56;  // int? | Account ID
            var extensionId = 56;  // int? | Extension ID
            var contactId = 56;  // int? | Contact ID

            try
            {
                // Retrieve the details of an address book contact.
                ContactFull result = apiInstance.GetAccountExtensionContact(accountId, extensionId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAccountExtensionContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **extensionId** | **int?**| Extension ID | 
 **contactId** | **int?**| Contact ID | 

### Return type

[**ContactFull**](ContactFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountextensioncontacts"></a>
# **ListAccountExtensionContacts**
> ListContacts ListAccountExtensionContacts (int? accountId, int? extensionId, List<string> filtersId = null, List<string> filtersGroupId = null, List<string> filtersUpdatedAt = null, string sortId = null, string sortUpdatedAt = null, int? limit = null, int? offset = null, string fields = null)

Show the Caller ID options a given extension can use.

Show the Caller ID options a given extension can use. See Intro to Caller IDs for more on the properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAccountExtensionContactsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContactsApi();
            var accountId = 56;  // int? | Account ID
            var extensionId = 56;  // int? | Extension ID
            var filtersId = new List<string>(); // List<string> | ID filter (optional) 
            var filtersGroupId = new List<string>(); // List<string> | Group filter (optional) 
            var filtersUpdatedAt = new List<string>(); // List<string> | Updated At filter (optional) 
            var sortId = sortId_example;  // string | ID sorting (optional) 
            var sortUpdatedAt = sortUpdatedAt_example;  // string | Updated At sorting (optional) 
            var limit = 56;  // int? | Max results (optional) 
            var offset = 56;  // int? | Results to skip (optional) 
            var fields = fields_example;  // string | Field set (optional) 

            try
            {
                // Show the Caller ID options a given extension can use.
                ListContacts result = apiInstance.ListAccountExtensionContacts(accountId, extensionId, filtersId, filtersGroupId, filtersUpdatedAt, sortId, sortUpdatedAt, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ListAccountExtensionContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **extensionId** | **int?**| Extension ID | 
 **filtersId** | [**List&lt;string&gt;**](string.md)| ID filter | [optional] 
 **filtersGroupId** | [**List&lt;string&gt;**](string.md)| Group filter | [optional] 
 **filtersUpdatedAt** | [**List&lt;string&gt;**](string.md)| Updated At filter | [optional] 
 **sortId** | **string**| ID sorting | [optional] 
 **sortUpdatedAt** | **string**| Updated At sorting | [optional] 
 **limit** | **int?**| Max results | [optional] 
 **offset** | **int?**| Results to skip | [optional] 
 **fields** | **string**| Field set | [optional] 

### Return type

[**ListContacts**](ListContacts.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceaccountextensioncontact"></a>
# **ReplaceAccountExtensionContact**
> ContactFull ReplaceAccountExtensionContact (int? accountId, int? extensionId, int? contactId, CreateContactParams data = null)

Update the info of a contact in the address book.

Update the info of a contact in the address book. See Account Contacts for more info on the fields in each item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceAccountExtensionContactExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContactsApi();
            var accountId = 56;  // int? | Account ID
            var extensionId = 56;  // int? | Extension ID
            var contactId = 56;  // int? | Contact ID
            var data = new CreateContactParams(); // CreateContactParams | Contact data (optional) 

            try
            {
                // Update the info of a contact in the address book.
                ContactFull result = apiInstance.ReplaceAccountExtensionContact(accountId, extensionId, contactId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ReplaceAccountExtensionContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| Account ID | 
 **extensionId** | **int?**| Extension ID | 
 **contactId** | **int?**| Contact ID | 
 **data** | [**CreateContactParams**](CreateContactParams.md)| Contact data | [optional] 

### Return type

[**ContactFull**](ContactFull.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

