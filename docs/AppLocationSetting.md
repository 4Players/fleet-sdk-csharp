# OdinFleet.Model.AppLocationSetting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The id of the app location setting | 
**Name** | **string** | The name of the app location setting | 
**AppId** | **int** | The app id of the app location setting | 
**ServerConfigId** | **int** | The server config id of the app location setting | 
**NumInstances** | **int** | The number of instances that should run at the specific location | 
**AutoScalerEnabled** | **bool** | Whether the auto scaler is enabled | 
**AutoScalerMin** | **int** | The minimum number of instances that should run at the specific location | [optional] 
**AutoScalerMax** | **int** | The maximum number of instances that should run at the specific location | [optional] 
**Placement** | [**Placement**](Placement.md) | The placement to use | 
**ServerConfig** | [**ServerConfig**](ServerConfig.md) | The server config to use | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

