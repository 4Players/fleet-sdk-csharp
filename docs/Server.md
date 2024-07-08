# OdinFleet.Model.Server

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The ID of the service | 
**AppLocationSettingId** | **int** | The ID of the location setting | 
**Instance** | **int** | The ID of the instance | 
**Name** | **string** |  | 
**Addr** | **string** | The IP address of the node | 
**CreatedAt** | **DateTime** | When the service was created | 
**UpdatedAt** | **DateTime** | When the service was last updated | 
**Location** | [**Location**](Location.md) | The location of the node | 
**Env** | [**Dictionary&lt;string, EnvironmentVariable&gt;**](EnvironmentVariable.md) | The environment variables of the service | 
**Ports** | [**Dictionary&lt;string, Port&gt;**](Port.md) | The port definitions of the service | 
**RestartPolicy** | [**RestartPolicy**](RestartPolicy.md) | The restart policy of the service | 
**Resources** | [**ResourceAllocations**](ResourceAllocations.md) | The resource allocations of the service | 
**Status** | [**DockerTaskStatus**](DockerTaskStatus.md) | The status of the task | 
**ServerConfig** | [**ServerConfig**](ServerConfig.md) | The server configuration | 
**Backup** | [**Backup**](Backup.md) | The last backup of the service | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

