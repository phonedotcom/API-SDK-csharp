# IO.Swagger.Model.VoicemailFull
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique Voicemail ID. Read-only. | [optional] 
**DownloadUrl** | **string** | Name. Required. | [optional] 
**Extension** | [**ExtensionSummary**](ExtensionSummary.md) | Extension where the voicemail is saved into. | [optional] 
**From** | [**FromObject**](FromObject.md) | The caller&#39;s information | [optional] 
**To** | **string** | The phone number where the caller is calling | [optional] 
**IsNew** | **bool?** | True when Voicemail is new; False when Voicemail has been listened | [optional] 
**CreatedAt** | **int?** | Date string representing the UTC time that the object was created in the Phone.com API system. | [optional] 
**Folder** | **string** | Folder name where voicemail is saved | [optional] 
**Duration** | **int?** | Length of voicemail in seconds | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

