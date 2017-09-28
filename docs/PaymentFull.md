# IO.Swagger.Model.PaymentFull
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Payment Method ID | [optional] 
**VoipId** | **int?** | API Account ID | [optional] 
**Status** | **string** | &#39;primary&#39; &#x3D; primary card used for billing; &#39;onfile&#39; &#x3D; card on file; &#39;hidden&#39; &#x3D; deleted card; | [optional] 
**Nickname** | **string** | Name of Card | [optional] 
**Type** | **string** | &#39;cc&#39; for credit card | [optional] 
**CreatedAt** | **int?** | Time payment record is created | [optional] 
**Contact** | [**ContactResponse**](ContactResponse.md) | Detail of contact person | [optional] 
**DeclineCount** | **int?** | Number of times the payment method was declined | [optional] 
**NextChargeDate** | **int?** | Next billing date | [optional] 
**UpdatedAt** | **int?** | Last time the payment method was updated | [optional] 
**CcToken** | **string** | Encrypted credit card token to be used for billing | [optional] 
**CcNumber** | **string** | Credit card number partially masked with xxxxxxxx | [optional] 
**CcExp** | **string** | Credit card expiration date | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

