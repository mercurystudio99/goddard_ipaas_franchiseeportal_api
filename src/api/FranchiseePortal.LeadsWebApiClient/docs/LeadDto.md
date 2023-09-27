# FranchiseePortal.LeadsWebApiClient.Model.LeadDto
Lead output DTO for sending lead summary info in responses

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SchoolId** | **long** | ID of school associated to lead | [optional] 
**FirstName** | **string** |  | [optional] 
**LastName** | **string** |  | [optional] 
**AdditionalRemarks** | **string** |  | [optional] 
**StreetLine1** | **string** |  | [optional] 
**City** | **string** |  | [optional] 
**ZipCode** | **string** |  | [optional] 
**MobilePhone** | **string** |  | [optional] 
**HomePhone** | **string** |  | [optional] 
**WorkPhone** | **string** |  | [optional] 
**PrimaryPhone** | **string** |  | [optional] [readonly] 
**EmailAddress** | **string** |  | [optional] 
**ReferredBy** | **ReferredBy** |  | [optional] 
**StartDate** | **DateTime** |  | [optional] 
**ContactPreference** | **int?** |  | [optional] 
**SchoolChildLeads** | [**List&lt;ChildLead&gt;**](ChildLead.md) |  | [optional] 
**ProgramsOfInterest** | **List&lt;string&gt;** |  | [optional] 
**DaysOfInterest** | [**List&lt;DaysOfInterest&gt;**](DaysOfInterest.md) |  | [optional] 
**SchoolParentLeadId** | **string** |  | [optional] 
**CreatedOn** | **DateTime?** |  | [optional] 
**GuidId** | **Guid** |  | [optional] 
**TourQuestions** | **string** | Additional questions when scheduling tour | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

