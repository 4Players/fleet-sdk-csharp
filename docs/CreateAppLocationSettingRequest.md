# OdinFleet.Model.CreateAppLocationSettingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the location setting | 
**ServerConfigId** | **int** | The id of the server configuration that should be deployed | 
**AutoScalerEnabled** | **bool** | Whether auto scaler is enabled | 
**AutoScalerMin** | **int?** | The minimum number of instances that should run at the specific location | [optional] 
**AutoScalerMax** | **int?** | The maximum number of instances that should run at the specific location | [optional] 
**NumInstances** | **int** | The number of instances that should run at the specific location | 
**Placement** | [**Placement**](Placement.md) | The placement settings that define the location and other constraints | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

