# OdinFleet.Model.ServerConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The id of the server configuration | 
**BinaryId** | **int** | The binary id of the server configuration | 
**AppId** | **int** | The app id of the server configuration | 
**Name** | **string** | The name of the server config | 
**Command** | **string** | The command to run in the container (overrides ENTRYPOINT of the Dockerfile) | 
**Args** | **string** | The arguments to pass to the command (overrides CMD of the Dockerfile) | 
**Notes** | **string** | The notes of the server config - to keep track of things and to inform colleagues | 
**RestartPolicy** | [**RestartPolicy**](RestartPolicy.md) | The policy used to restart this server | 
**Resources** | [**ResourceAllocations**](ResourceAllocations.md) | The resources to be used in this config | 
**Env** | [**List&lt;EnvironmentVariableDefinition&gt;**](EnvironmentVariableDefinition.md) | The environment variable definitions to be used in this config | 
**Mounts** | [**List&lt;Mount&gt;**](Mount.md) | The mounts to use | 
**Ports** | [**List&lt;PortDefinition&gt;**](PortDefinition.md) | The ports to expose | 
**ConfigFiles** | [**List&lt;ConfigFile&gt;**](ConfigFile.md) | The config files to use | 
**Binary** | [**Binary**](Binary.md) | The image that is used in this server config | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

